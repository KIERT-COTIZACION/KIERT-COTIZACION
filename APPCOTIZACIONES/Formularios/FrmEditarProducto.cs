using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmEditarProducto : Form
    {
        private readonly int _productoId;
        private Producto _producto;
        private List<InventarioItem> _tallasColoresTemp = new List<InventarioItem>();

        public FrmEditarProducto(int productoId)
        {
            InitializeComponent();

            _productoId = productoId;

            // ✅ Cargar el producto
            CargarProducto();

            try { TemaService.AplicarTemaAFormulario(this); } catch { }
        }

        // ==========================================================
        // CARGAR PRODUCTO CON SUS TALLAS/COLORES
        // ==========================================================
        private void CargarProducto()
        {
            try
            {
                var productos = Repositorio.ObtenerProductos();
                _producto = productos.FirstOrDefault(p => p.Id == _productoId);

                if (_producto == null)
                {
                    MessageBox.Show("No se encontró el producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                // Cargar datos en los controles
                txtCodigo.Text = _producto.Codigo;
                txtDescripcion.Text = _producto.Descripcion;
                txtPrecio.Text = _producto.Precio.ToString("0.00");
                txtStock.Text = _producto.Stock.ToString();

                // Cargar tallas/colores
                _tallasColoresTemp = Repositorio.ObtenerInventarioPorProducto(_productoId)
                    .Select(i => new InventarioItem
                    {
                        Id = i.Id,
                        ProductoId = i.ProductoId,
                        Talla = i.Talla,
                        Color = i.Color,
                        Cantidad = i.Cantidad
                    }).ToList();

                RefrescarTallasColores();

                lblTitulo.Text = $"✏️ Editando: {_producto.Codigo}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar producto:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void RefrescarTallasColores()
        {
            dgvTallasColores.Rows.Clear();

            foreach (var tc in _tallasColoresTemp)
            {
                dgvTallasColores.Rows.Add(
                    tc.Talla ?? "—",
                    tc.Color ?? "—"
                );
            }
        }

        // ==========================================================
        // AGREGAR TALLA/COLOR
        // ==========================================================
        private void btnAgregarTC_Click(object sender, EventArgs e)
        {
            string tallaTexto = cmbTalla.Text.Trim();
            string colorTexto = cmbColor.Text.Trim();

            if (string.IsNullOrEmpty(tallaTexto) && string.IsNullOrEmpty(colorTexto))
            {
                MessageBox.Show("Ingrese al menos una talla o un color.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTalla.Focus();
                return;
            }

            var tallas = string.IsNullOrEmpty(tallaTexto)
                ? new List<string> { "—" }
                : tallaTexto.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(t => t.Trim())
                            .Where(t => !string.IsNullOrEmpty(t))
                            .ToList();

            var colores = string.IsNullOrEmpty(colorTexto)
                ? new List<string> { "—" }
                : colorTexto.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(c => c.Trim())
                            .Where(c => !string.IsNullOrEmpty(c))
                            .ToList();

            int agregados = 0;
            int duplicados = 0;

            foreach (var talla in tallas)
            {
                foreach (var color in colores)
                {
                    bool yaExiste = _tallasColoresTemp.Any(x =>
                        (x.Talla ?? "—") == talla && (x.Color ?? "—") == color);

                    if (yaExiste)
                    {
                        duplicados++;
                        continue;
                    }

                    _tallasColoresTemp.Add(new InventarioItem
                    {
                        Talla = talla,
                        Color = color,
                        Cantidad = 0
                    });

                    agregados++;
                }
            }

            RefrescarTallasColores();

            if (agregados > 0)
            {
                cmbTalla.Text = "";
                cmbColor.Text = "";
                cmbTalla.Focus();

                string msg = $"✅ Se agregaron {agregados} talla(s)/color(es).";
                if (duplicados > 0)
                    msg += $"\n\n⚠️ {duplicados} ya estaban.";
                MessageBox.Show(msg, "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (duplicados > 0)
            {
                MessageBox.Show("Todas las tallas/colores ya estaban en la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ==========================================================
        // QUITAR TALLA/COLOR
        // ==========================================================
        private void btnQuitarTC_Click(object sender, EventArgs e)
        {
            if (dgvTallasColores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una talla/color.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string talla = dgvTallasColores.CurrentRow.Cells[0].Value?.ToString();
            string color = dgvTallasColores.CurrentRow.Cells[1].Value?.ToString();

            var item = _tallasColoresTemp.FirstOrDefault(x =>
                (x.Talla ?? "—") == talla && (x.Color ?? "—") == color);

            if (item != null)
            {
                _tallasColoresTemp.Remove(item);
                RefrescarTallasColores();
            }
        }

        // ==========================================================
        // GUARDAR CAMBIOS
        // ==========================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el CÓDIGO.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Ingrese la DESCRIPCIÓN.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio < 0)
            {
                MessageBox.Show("Ingrese un PRECIO válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Ingrese un STOCK válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (_tallasColoresTemp.Count == 0)
            {
                MessageBox.Show("Debe tener al menos una talla o color.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 1. Validar código duplicado (si cambió)
                var existentes = Repositorio.ObtenerProductos();
                bool codigoDuplicado = existentes.Any(p =>
                    p.Id != _productoId &&
                    p.Codigo.Equals(txtCodigo.Text.Trim(), StringComparison.OrdinalIgnoreCase));

                if (codigoDuplicado)
                {
                    MessageBox.Show($"Ya existe OTRO producto con el código '{txtCodigo.Text.Trim()}'.",
                        "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Actualizar producto
                _producto.Codigo = txtCodigo.Text.Trim();
                _producto.Descripcion = txtDescripcion.Text.Trim();
                _producto.Precio = precio;
                _producto.Stock = stock;
                Repositorio.ActualizarProducto(_producto);

                // 3. Sincronizar tallas/colores
                var actuales = Repositorio.ObtenerInventarioPorProducto(_productoId);

                // 3a. Eliminar las que ya no están
                int eliminados = 0;
                foreach (var inv in actuales)
                {
                    bool sigueExistiendo = _tallasColoresTemp.Any(t =>
                        (t.Talla ?? "—") == (inv.Talla ?? "—") &&
                        (t.Color ?? "—") == (inv.Color ?? "—"));

                    if (!sigueExistiendo)
                    {
                        Repositorio.EliminarInventario(inv.Id);
                        eliminados++;
                    }
                }

                // 3b. Insertar las nuevas
                int insertados = 0;
                foreach (var tc in _tallasColoresTemp)
                {
                    bool yaExiste = actuales.Any(i =>
                        (i.Talla ?? "—") == (tc.Talla ?? "—") &&
                        (i.Color ?? "—") == (tc.Color ?? "—"));

                    if (!yaExiste)
                    {
                        Repositorio.InsertarInventario(_productoId, tc.Talla, tc.Color, 0);
                        insertados++;
                    }
                }

                MessageBox.Show(
                    $"✅ Producto actualizado correctamente.\n\n" +
                    $"Código: {_producto.Codigo}\n" +
                    $"Descripción: {_producto.Descripcion}\n" +
                    $"Precio: {precio:N2}\n" +
                    $"Stock: {stock}\n" +
                    $"Tallas/colores agregados: {insertados}\n" +
                    $"Tallas/colores eliminados: {eliminados}",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar con OK para que el padre recargue
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "❌ Error al guardar:\n\n" +
                    "Mensaje: " + ex.Message + "\n\n" +
                    "InnerException: " + (ex.InnerException?.Message ?? "(ninguna)"),
                    "Error detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // CANCELAR
        // ==========================================================
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Descartar los cambios?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }
    }
}
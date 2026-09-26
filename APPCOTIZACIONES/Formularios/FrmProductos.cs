using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmProductos : Form
    {
        private Producto _actual;
        private List<InventarioItem> _tallasColoresTemp = new List<InventarioItem>();

        public FrmProductos()
        {
            InitializeComponent();

            dgvProductos.AutoGenerateColumns = false;
            dgvTallasColores.AutoGenerateColumns = false;

            Cargar();                 // Carga los productos en dgvProductos
            LimpiarCamposTexto();     // Solo limpia campos de texto y variables
            RefrescarTallasColores(); // Asegura que dgvTallasColores esté vacío

            try { TemaService.AplicarTemaAFormulario(this); } catch { }
        }

        // ✅ MÉTODO QUE EL DESIGNER LLAMA
        private void FrmProductos_Load(object sender, EventArgs e) { }

        // ==========================================================
        // CARGAR PRODUCTOS
        // ==========================================================
        private void Cargar()
        {
            try
            {
                dgvProductos.Rows.Clear();

                var productos = Repositorio.ObtenerProductos()
                    .GroupBy(p => p.Id)
                    .Select(g => g.First())
                    .OrderBy(p => p.Codigo)
                    .ToList();

                foreach (var p in productos)
                {
                    dgvProductos.Rows.Add(
                        p.Id,
                        p.Codigo,
                        p.Descripcion,
                        p.Precio.ToString("N2"),
                        p.Stock
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ==========================================================
        // ✅ LIMPIAR SOLO CAMPOS DE TEXTO
        // Se usa SOLO después de guardar
        // NO borra las tallas/colores de la tabla
        // ==========================================================
        private void LimpiarCamposTexto()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbTalla.Text = "";
            cmbColor.Text = "";

            _actual = null;
            // ❌ NO limpiamos _tallasColoresTemp
            // ❌ NO llamamos a RefrescarTallasColores()

            txtCodigo.Focus();
        }

        // ==========================================================
        // ✅ LIMPIAR TODO (campos + tallas/colores + tabla productos)
        // Se usa en el BOTÓN LIMPIAR
        // ==========================================================
        private void LimpiarTodo()
        {
            // Limpiar campos de texto
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            cmbTalla.Text = "";
            cmbColor.Text = "";

            // Limpiar variables internas
            _actual = null;
            _tallasColoresTemp.Clear();

            // ✅ Limpiar TODAS las tablas del formulario
            dgvTallasColores.Rows.Clear();
            dgvProductos.Rows.Clear();   // <-- Ahora también limpia la tabla de productos

            txtCodigo.Focus();
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
        // FUNCIÓN AUXILIAR: Agregar tallas/colores de los combos
        // ==========================================================
        private int AgregarTallasColoresDesdeCombos()
        {
            string tallaTexto = cmbTalla.Text.Trim();
            string colorTexto = cmbColor.Text.Trim();

            if (string.IsNullOrEmpty(tallaTexto) && string.IsNullOrEmpty(colorTexto))
                return 0;

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

            foreach (var talla in tallas)
            {
                foreach (var color in colores)
                {
                    bool yaExiste = _tallasColoresTemp.Any(x =>
                        (x.Talla ?? "—") == talla && (x.Color ?? "—") == color);

                    if (yaExiste) continue;

                    if (_actual != null)
                    {
                        var inventarioActual = Repositorio.ObtenerInventarioPorProducto(_actual.Id);
                        bool yaEnBD = inventarioActual.Any(i =>
                            (i.Talla ?? "—") == talla && (i.Color ?? "—") == color);

                        if (yaEnBD) continue;
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

            if (agregados > 0)
                RefrescarTallasColores();

            return agregados;
        }

        // ==========================================================
        // BOTÓN GUARDAR PRODUCTO COMPLETO
        // ==========================================================
        private void btnGuardarTodo_Click(object sender, EventArgs e)
        {
            // ============ 1. VALIDAR DATOS ============
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                MessageBox.Show("Ingrese el CÓDIGO del producto.", "Validación",
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

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
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

            // ============ 2. AGREGAR TALLAS/COLORES DE LOS COMBOS ============
            AgregarTallasColoresDesdeCombos();

            // ============ 3. VALIDAR QUE HAYA AL MENOS 1 TALLA/COLOR ============
            if (_tallasColoresTemp.Count == 0)
            {
                MessageBox.Show(
                    "Debe agregar al menos una TALLA o un COLOR.\n\n" +
                    "Escriba la talla y/o el color y presione GUARDAR.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTalla.Focus();
                return;
            }

            // ============ 4. GUARDAR ============
            try
            {
                if (_actual == null)
                {
                    // ---------- PRODUCTO NUEVO ----------
                    var existentes = Repositorio.ObtenerProductos();
                    if (existentes.Any(p =>
                        p.Codigo.Equals(txtCodigo.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
                    {
                        MessageBox.Show($"Ya existe un producto con el código '{txtCodigo.Text.Trim()}'.",
                            "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int nuevoId = Repositorio.InsertarProducto(new Producto
                    {
                        Codigo = txtCodigo.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                        Precio = precio,
                        Stock = stock
                    });

                    int insertados = 0;
                    foreach (var tc in _tallasColoresTemp)
                    {
                        Repositorio.InsertarInventario(nuevoId, tc.Talla, tc.Color, 0);
                        insertados++;
                    }

                    MessageBox.Show(
                        $"✅ Producto guardado.\n\n" +
                        $"Código: {txtCodigo.Text.Trim()}\n" +
                        $"Descripción: {txtDescripcion.Text.Trim()}\n" +
                        $"Precio: {precio:N2}\n" +
                        $"Stock: {stock}\n" +
                        $"Tallas/colores guardados: {insertados}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Cargar();
                    LimpiarCamposTexto();  // ✅ Solo limpia campos de texto
                }
                else
                {
                    // ---------- PRODUCTO EXISTENTE ----------
                    _actual.Codigo = txtCodigo.Text.Trim();
                    _actual.Descripcion = txtDescripcion.Text.Trim();
                    _actual.Precio = precio;
                    _actual.Stock = stock;
                    Repositorio.ActualizarProducto(_actual);

                    var inventarioActual = Repositorio.ObtenerInventarioPorProducto(_actual.Id);
                    int insertados = 0;

                    foreach (var tc in _tallasColoresTemp)
                    {
                        bool yaExiste = inventarioActual.Any(i =>
                            (i.Talla ?? "—") == (tc.Talla ?? "—") &&
                            (i.Color ?? "—") == (tc.Color ?? "—"));

                        if (!yaExiste)
                        {
                            Repositorio.InsertarInventario(_actual.Id, tc.Talla, tc.Color, 0);
                            insertados++;
                        }
                    }

                    MessageBox.Show(
                        $"✅ Producto actualizado.\n\n" +
                        $"Nuevas tallas/colores: {insertados}",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Cargar();
                    LimpiarCamposTexto();  // ✅ Solo limpia campos de texto
                }
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
        // QUITAR TALLA/COLOR
        // ==========================================================
        private void btnQuitarTC_Click(object sender, EventArgs e)
        {
            if (dgvTallasColores.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una talla/color de la lista.", "Aviso",
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
        // ✅ BOTÓN LIMPIAR: LIMPIA TODO
        // Campos de texto + tallas/colores + tabla de productos
        // ==========================================================
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "¿Limpiar TODO el formulario?\n\n" +
                "Se borrarán:\n" +
                "• Código\n" +
                "• Descripción\n" +
                "• Precio\n" +
                "• Stock\n" +
                "• Talla\n" +
                "• Color\n" +
                "• La lista de tallas/colores\n" +
                "• La lista de productos (solo visual)\n\n" +
                "⚠️ Los productos YA GUARDADOS en la base de datos NO se borrarán.",
                "Confirmar limpieza",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // ✅ Limpiar TODO (incluye ambas tablas)
                LimpiarTodo();

                MessageBox.Show(
                    "🧹 Formulario limpiado.\n\n" +
                    "Listo para agregar un nuevo producto.",
                    "Limpiar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        // ==========================================================
        // EDITAR PRODUCTO
        // ==========================================================
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);

            var productos = Repositorio.ObtenerProductos();
            var p = productos.FirstOrDefault(x => x.Id == id);

            if (p == null) return;

            _actual = p;
            txtCodigo.Text = p.Codigo;
            txtDescripcion.Text = p.Descripcion;
            txtPrecio.Text = p.Precio.ToString("0.00");
            txtStock.Text = p.Stock.ToString();

            _tallasColoresTemp = Repositorio.ObtenerInventarioPorProducto(p.Id)
                .Select(i => new InventarioItem
                {
                    Id = i.Id,
                    ProductoId = i.ProductoId,
                    Talla = i.Talla,
                    Color = i.Color,
                    Cantidad = i.Cantidad
                }).ToList();

            RefrescarTallasColores();

            MessageBox.Show(
                $"✏️ Editando: {p.Codigo}\n\n" +
                $"Tallas/colores actuales: {_tallasColoresTemp.Count}\n\n" +
                $"Para agregar más:\n" +
                $"1. Escriba tallas/colores (varias separadas por coma)\n" +
                $"2. Presione '💾 GUARDAR PRODUCTO COMPLETO'",
                "Editar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==========================================================
        // ELIMINAR PRODUCTO
        // ==========================================================
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
            string codigo = dgvProductos.CurrentRow.Cells[1].Value?.ToString();
            string descripcion = dgvProductos.CurrentRow.Cells[2].Value?.ToString();

            if (MessageBox.Show(
                $"¿Eliminar el producto?\n\n" +
                $"Código: {codigo}\n" +
                $"Descripción: {descripcion}\n\n" +
                $"Se eliminarán también sus tallas y colores.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Repositorio.EliminarProducto(id);
                    Cargar();
                    LimpiarTodo();

                    MessageBox.Show("Producto eliminado.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==========================================================
        // CERRAR
        // ==========================================================
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
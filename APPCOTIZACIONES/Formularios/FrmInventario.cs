using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmInventario : Form
    {
        public FrmInventario()
        {
            InitializeComponent();

            // ✅ CLAVE: evitar columnas automáticas
            dgvInventario.AutoGenerateColumns = false;

            // Estilo filas alternas
            dgvInventario.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(250, 248, 245);

            // Alineaciones
            dgvInventario.Columns["colPrecio"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;
            dgvInventario.Columns["colStock"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvInventario.Columns["colId"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            CargarInventario();

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void CargarInventario(string filtro = "")
        {
            try
            {
                dgvInventario.Rows.Clear();
                var productos = Repositorio.ObtenerProductos();

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    productos = productos.Where(p =>
                        (p.Codigo ?? "").ToLower().Contains(filtro.ToLower()) ||
                        (p.Descripcion ?? "").ToLower().Contains(filtro.ToLower())
                    ).ToList();
                }

                int totalProductos = 0;
                int stockTotal = 0;
                decimal valorTotal = 0;

                foreach (var p in productos)
                {
                    var items = Repositorio.ObtenerInventarioPorProducto(p.Id);

                    string tallas = items.Count > 0
                        ? string.Join(", ", items.Select(i => i.Talla)
                                                 .Where(t => !string.IsNullOrEmpty(t))
                                                 .Distinct())
                        : "—";
                    string colores = items.Count > 0
                        ? string.Join(", ", items.Select(i => i.Color)
                                                 .Where(c => !string.IsNullOrEmpty(c))
                                                 .Distinct())
                        : "—";

                    dgvInventario.Rows.Add(
                        p.Id,
                        p.Codigo ?? "-",
                        p.Descripcion ?? "-",
                        p.Precio.ToString("N2"),
                        p.Stock,
                        tallas,
                        colores
                    );

                    totalProductos++;
                    stockTotal += p.Stock;
                    valorTotal += p.Stock * p.Precio;
                }

                lblTotalProductos.Text = $"📦 Total Productos: {totalProductos}";
                lblStockTotal.Text = $"📊 Stock Total: {stockTotal} unidades";
                lblValorInventario.Text = $"💰 Valor Inventario: S/ {valorTotal:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarInventario(txtBuscar.Text.Trim());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // ✅ Botón actualizar funcional: limpia filtro y recarga
            txtBuscar.Clear();
            CargarInventario();
            txtBuscar.Focus();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            new FrmProductos().ShowDialog();
            CargarInventario();
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            new FrmProductos().ShowDialog();
            CargarInventario();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            string nombre = dgvInventario.CurrentRow.Cells[2].Value?.ToString();

            if (MessageBox.Show($"¿Eliminar '{nombre}'?\n\nEliminará también sus tallas y colores.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    Repositorio.EliminarProducto(id);
                    MessageBox.Show("Producto eliminado.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarInventario();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarStock_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int id = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            int stockActual = Convert.ToInt32(dgvInventario.CurrentRow.Cells[4].Value);

            using (var dlg = new FrmInputBox("Actualizar Stock",
                $"Stock actual: {stockActual}\n\nIngrese el nuevo stock:",
                stockActual.ToString()))
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (int.TryParse(dlg.Valor, out int nuevoStock) && nuevoStock >= 0)
                    {
                        try
                        {
                            Repositorio.ActualizarStockProducto(id, nuevoStock);
                            MessageBox.Show($"Stock actualizado a {nuevoStock} unidades.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarInventario();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al actualizar:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un número válido.", "Validación",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnAgregarTallaColor_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int prodId = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            string nombre = dgvInventario.CurrentRow.Cells[2].Value?.ToString();

            using (var dlg = new FrmAgregarTallaColor(prodId, nombre))
            {
                dlg.ShowDialog();
                CargarInventario();
            }
        }

        private void btnEditarTallaColor_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int prodId = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            string nombre = dgvInventario.CurrentRow.Cells[2].Value?.ToString();

            // Paso 1: elegir qué talla/color editar
            using (var sel = new FrmSelectorTallaColor(prodId, nombre))
            {
                if (sel.ShowDialog() != DialogResult.OK || sel.ItemSeleccionado == null)
                    return;

                // Paso 2: abrir el editor
                using (var edit = new FrmEditarTallaColor(sel.ItemSeleccionado, nombre))
                {
                    if (edit.ShowDialog() == DialogResult.OK)
                        CargarInventario();
                }
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvInventario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int prodId = Convert.ToInt32(dgvInventario.CurrentRow.Cells[0].Value);
            using (var dlg = new FrmDetalleProducto(prodId))
            {
                dlg.ShowDialog();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            // Vacío — listo por si necesitas algo al cargar
        }
    }
}
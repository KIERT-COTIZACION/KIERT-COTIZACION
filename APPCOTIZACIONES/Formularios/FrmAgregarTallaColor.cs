using System;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmAgregarTallaColor : Form
    {
        private int _productoId;

        public FrmAgregarTallaColor(int productoId, string productoNombre)
        {
            InitializeComponent();
            _productoId = productoId;
            lblProducto.Text = "📦 Producto: " + productoNombre;

            // ✅ Evitar columnas automáticas
            dgvExistentes.AutoGenerateColumns = false;
            dgvExistentes.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(250, 248, 245);

            CargarExistentes();

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void CargarExistentes()
        {
            try
            {
                var items = Repositorio.ObtenerInventarioPorProducto(_productoId);
                dgvExistentes.Rows.Clear();
                foreach (var it in items)
                    dgvExistentes.Rows.Add(it.Id, it.Talla, it.Color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tallas/colores:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // ✅ Ya NO se pide cantidad (se ingresa en FrmProductos al crear)
            if (string.IsNullOrWhiteSpace(txtTalla.Text))
            {
                MessageBox.Show("Ingrese una talla.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTalla.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                MessageBox.Show("Ingrese un color.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtColor.Focus();
                return;
            }

            try
            {
                // ✅ Cantidad por defecto = 0, se actualizará desde stock del producto
                Repositorio.InsertarInventario(_productoId,
                    txtTalla.Text.Trim().ToUpper(),
                    txtColor.Text.Trim(), 0);

                MessageBox.Show("Talla/Color agregado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarExistentes();
                txtTalla.Clear();
                txtColor.Clear();
                txtTalla.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmEditarTallaColor : Form
    {
        private InventarioItem _item;

        public FrmEditarTallaColor(InventarioItem item, string productoNombre)
        {
            InitializeComponent();
            _item = item;
            lblProducto.Text = "📦 Producto: " + productoNombre;

            txtTalla.Text = item.Talla ?? "";
            txtColor.Text = item.Color ?? "";

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
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
                Repositorio.ActualizarTallaColor(_item.Id,
                    txtTalla.Text.Trim().ToUpper(),
                    txtColor.Text.Trim());

                MessageBox.Show("Talla/Color actualizado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
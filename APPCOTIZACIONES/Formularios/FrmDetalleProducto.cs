using System;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Datos;

namespace COTIZACIONES.Formularios
{
    public partial class FrmDetalleProducto : Form
    {
        private int _productoId;

        public FrmDetalleProducto(int productoId)
        {
            InitializeComponent();
            _productoId = productoId;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            try
            {
                var p = Repositorio.ObtenerProductos().FirstOrDefault(x => x.Id == _productoId);
                if (p == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    Close();
                    return;
                }

                lblCodigo.Text = "Código: " + (p.Codigo ?? "-");
                lblNombre.Text = "Nombre: " + (p.Descripcion ?? "-");
                lblPrecio.Text = "Precio: S/ " + p.Precio.ToString("N2");
                lblStock.Text = "Stock Total: " + p.Stock + " unidades";

                var items = Repositorio.ObtenerInventarioPorProducto(_productoId);
                dgvTallas.Rows.Clear();
                foreach (var it in items)
                    dgvTallas.Rows.Add(it.Talla, it.Color, it.Cantidad);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
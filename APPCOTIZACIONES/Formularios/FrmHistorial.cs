using System;
using System.Windows.Forms;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmHistorial : Form
    {
        public FrmHistorial()
        {
            InitializeComponent();
            Cargar();

            // Aplicar tema guardado
            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void Cargar(string filtro = "")
        {
            try
            {
                var lista = CotizacionService.ObtenerHistorial(filtro);
                dgvCotizaciones.DataSource = null;
                dgvCotizaciones.DataSource = lista;

                if (dgvCotizaciones.Columns.Count > 0)
                {
                    if (dgvCotizaciones.Columns["Subtotal"] != null)
                        dgvCotizaciones.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
                    if (dgvCotizaciones.Columns["Impuesto"] != null)
                        dgvCotizaciones.Columns["Impuesto"].DefaultCellStyle.Format = "N2";
                    if (dgvCotizaciones.Columns["Total"] != null)
                        dgvCotizaciones.Columns["Total"].DefaultCellStyle.Format = "N2";

                    // Ocultar columnas técnicas si existen
                    if (dgvCotizaciones.Columns["Id"] != null)
                        dgvCotizaciones.Columns["Id"].Visible = false;
                    if (dgvCotizaciones.Columns["UsuarioId"] != null)
                        dgvCotizaciones.Columns["UsuarioId"].Visible = false;
                }

                lblTotal.Text = $"Total de cotizaciones: {lista.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar historial:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar(txtBuscar.Text.Trim());
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            Cargar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
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

            try { TemaService.AplicarTemaAFormulario(this); } catch { }
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
                    if (dgvCotizaciones.Columns["IGV"] != null)
                        dgvCotizaciones.Columns["IGV"].DefaultCellStyle.Format = "N2";
                    if (dgvCotizaciones.Columns["Impuesto"] != null)
                        dgvCotizaciones.Columns["Impuesto"].DefaultCellStyle.Format = "N2";
                    if (dgvCotizaciones.Columns["Total"] != null)
                        dgvCotizaciones.Columns["Total"].DefaultCellStyle.Format = "N2";

                    // Ocultar columnas técnicas
                    if (dgvCotizaciones.Columns["Id"] != null)
                        dgvCotizaciones.Columns["Id"].Visible = false;
                    if (dgvCotizaciones.Columns["UsuarioId"] != null)
                        dgvCotizaciones.Columns["UsuarioId"].Visible = false;
                    if (dgvCotizaciones.Columns["ClienteId"] != null)
                        dgvCotizaciones.Columns["ClienteId"].Visible = false;
                    if (dgvCotizaciones.Columns["Detalles"] != null)
                        dgvCotizaciones.Columns["Detalles"].Visible = false;
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

        private void FrmHistorial_Load(object sender, EventArgs e)
        {
        }

        // ✅ DOBLE CLIC
        private void dgvCotizaciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirDetalle(e.RowIndex);
        }

        // ✅ BOTÓN VER DETALLE
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvCotizaciones.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una cotización de la lista.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            AbrirDetalle(dgvCotizaciones.CurrentRow.Index);
        }

        // ✅ MÉTODO COMÚN
        private void AbrirDetalle(int rowIndex)
        {
            if (rowIndex < 0) return;

            string numero = dgvCotizaciones.Rows[rowIndex].Cells["Numero"].Value?.ToString();
            if (string.IsNullOrEmpty(numero))
            {
                MessageBox.Show("No se pudo obtener el número de cotización.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var frm = new FrmDetalleCotizacion(numero);
            frm.ShowDialog();

            // Recargar por si acaso
            Cargar(txtBuscar.Text.Trim());
        }
    }
}
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmDetalleCotizacion : Form
    {
        private readonly string _numero;
        private Modelos.Cotizacion _cot;

        public FrmDetalleCotizacion(string numero)
        {
            InitializeComponent();
            _numero = numero;
            CargarDetalle();
        }

        private void CargarDetalle()
        {
            try
            {
                _cot = CotizacionService.ObtenerPorNumero(_numero);
                if (_cot == null)
                {
                    MessageBox.Show("No se encontró la cotización.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                    return;
                }

                // ---------- CABECERA ----------
                lblNumero.Text = "Cotización N°: " + _cot.Numero;
                lblFecha.Text = "Fecha: " + _cot.Fecha.ToString("dd/MM/yyyy HH:mm");
                lblCliente.Text = "Cliente: " + (_cot.ClienteNombre ?? "—");
                lblDocumento.Text = "Documento: " + (_cot.ClienteDocumento ?? "—");
                lblObservaciones.Text = "Observaciones: " + (_cot.Observaciones ?? "—");

                // ---------- DETALLE ----------
                dgvDetalle.DataSource = null;
                dgvDetalle.DataSource = _cot.Detalles.Select(d => new
                {
                    Código = d.Codigo,
                    Descripción = d.Descripcion,
                    Talla = d.Talla ?? "—",
                    Color = d.Color ?? "—",
                    Precio = d.Precio,
                    Cantidad = d.Cantidad,
                    Subtotal = d.Subtotal
                }).ToList();

                if (dgvDetalle.Columns.Count > 0)
                {
                    if (dgvDetalle.Columns["Precio"] != null)
                        dgvDetalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
                    if (dgvDetalle.Columns["Subtotal"] != null)
                        dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";

                    if (dgvDetalle.Columns["Descripción"] != null)
                    {
                        dgvDetalle.Columns["Descripción"].AutoSizeMode =
                            DataGridViewAutoSizeColumnMode.Fill;
                        dgvDetalle.Columns["Descripción"].FillWeight = 200;
                        dgvDetalle.Columns["Descripción"].DefaultCellStyle.WrapMode =
                            DataGridViewTriState.True;
                    }
                }

                // ---------- TOTALES ----------
                lblSubtotal.Text = $"Subtotal: {_cot.Subtotal:F2}";
                lblIGV.Text = _cot.ConIGV
                    ? $"IGV ({_cot.PorcentajeIGV}%): {_cot.Impuesto:F2}"
                    : "IGV: NO APLICA";
                lblTotal.Text = $"TOTAL: {_cot.Total:F2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalle:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnExportarPdf_Click(object sender, EventArgs e)
        {
            if (_cot == null) return;

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                sfd.FileName = $"Cotizacion_{_cot.Numero}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var empresa = EmpresaService.ObtenerConfiguracion();
                    if (empresa == null)
                    {
                        empresa = new Modelos.EmpresaConfig
                        {
                            NombreEmpresa = "MI EMPRESA",
                            Moneda = "S/",
                            PorcentajeIGV = 18m,
                            ValidezDias = 30,
                            TiempoEntrega = "5-10 días hábiles"
                        };
                    }

                    PdfService.GenerarPdf(sfd.FileName, empresa, _cot.Numero,
                        _cot.ClienteNombre ?? "CLIENTE",
                        _cot.ClienteDocumento ?? "",
                        "", "", "",
                        "", "Contado",
                        _cot.ConIGV, _cot.Subtotal, _cot.Impuesto, _cot.Total,
                        _cot.Detalles, NumeroALetras(_cot.Total, empresa.Moneda));

                    if (MessageBox.Show("PDF generado. ¿Abrirlo?", "Éxito",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error PDF:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            if (_cot == null) return;

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xls";
                sfd.FileName = $"Cotizacion_{_cot.Numero}.xls";
                if (sfd.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var empresa = EmpresaService.ObtenerConfiguracion();
                    if (empresa == null)
                    {
                        empresa = new Modelos.EmpresaConfig
                        {
                            NombreEmpresa = "MI EMPRESA",
                            Moneda = "S/",
                            PorcentajeIGV = 18m,
                            ValidezDias = 30,
                            TiempoEntrega = "5-10 días hábiles"
                        };
                    }

                    ExcelService.Exportar(sfd.FileName, empresa, _cot.Numero,
                        _cot.ClienteNombre ?? "CLIENTE",
                        _cot.ClienteDocumento ?? "",
                        "", "", "",
                        "", _cot.ConIGV,
                        _cot.Subtotal, _cot.Impuesto, _cot.Total,
                        _cot.Detalles, NumeroALetras(_cot.Total, empresa.Moneda));

                    MessageBox.Show("Excel exportado:\n" + sfd.FileName, "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Excel:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string NumeroALetras(decimal n, string moneda)
        {
            long entero = (long)n;
            int cent = (int)((n - entero) * 100);
            return $"{entero} CON {cent:D2}/100 {(moneda == "S/" ? "SOLES" : "DÓLARES")}";
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
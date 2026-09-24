using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmConfigEmpresa : Form
    {
        private EmpresaConfig _config;
        private byte[] _nuevoLogoBytes;
        private string _nuevoLogoNombre;

        public FrmConfigEmpresa()
        {
            InitializeComponent();
            CargarConfiguracion();

            // Aplicar tema guardado
            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void CargarConfiguracion()
        {
            try
            {
                _config = EmpresaService.ObtenerConfiguracion();

                txtNombre.Text = _config.NombreEmpresa ?? "";
                txtRuc.Text = _config.Ruc ?? "";
                txtDireccion.Text = _config.Direccion ?? "";
                txtTel1.Text = _config.Telefono1 ?? "";
                txtTel2.Text = _config.Telefono2 ?? "";
                txtEmail.Text = _config.Email ?? "";
                txtInstagram.Text = _config.Instagram ?? "";
                txtFacebook.Text = _config.Facebook ?? "";
                txtWeb.Text = _config.SitioWeb ?? "";
                txtNotas.Text = _config.NotasCotizacion ?? "";
                numValidez.Value = _config.ValidezDias > 0 ? _config.ValidezDias : 30;
                txtTiempoEntrega.Text = _config.TiempoEntrega ?? "";
                numIGV.Value = _config.PorcentajeIGV > 0 ? _config.PorcentajeIGV : 18m;
                txtMoneda.Text = _config.Moneda ?? "S/";

                dgvBancos.Rows.Clear();
                foreach (var b in _config.DatosBancarios)
                    dgvBancos.Rows.Add(b.Banco, b.Cuenta, b.CCI);

                MostrarLogoActual();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar configuración:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarLogoActual()
        {
            var img = EmpresaService.ObtenerLogoComoImagen(_config);
            if (img != null)
            {
                picLogo.Image = new Bitmap(img);
                lblLogoInfo.Text = "Logo actual: " + (_config.LogoNombreArchivo ?? "(guardado en BD)");
            }
            else
            {
                picLogo.Image = null;
                lblLogoInfo.Text = "Sin logo. Suba una imagen PNG/JPG.";
            }
        }

        private void btnSubirLogo_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Title = "Seleccionar logo";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var bytes = File.ReadAllBytes(ofd.FileName);
                        if (bytes.Length > 5 * 1024 * 1024)
                        {
                            MessageBox.Show("La imagen es muy grande (máximo 5 MB).",
                                "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        _nuevoLogoBytes = bytes;
                        _nuevoLogoNombre = Path.GetFileName(ofd.FileName);

                        using (var ms = new MemoryStream(bytes))
                            picLogo.Image = new Bitmap(Image.FromStream(ms));

                        lblLogoInfo.Text = "Nuevo logo: " + _nuevoLogoNombre +
                                          " (se guardará al presionar GUARDAR)";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la empresa es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _config.NombreEmpresa = txtNombre.Text.Trim();
            _config.Ruc = txtRuc.Text.Trim();
            _config.Direccion = txtDireccion.Text.Trim();
            _config.Telefono1 = txtTel1.Text.Trim();
            _config.Telefono2 = txtTel2.Text.Trim();
            _config.Email = txtEmail.Text.Trim();
            _config.Instagram = txtInstagram.Text.Trim();
            _config.Facebook = txtFacebook.Text.Trim();
            _config.SitioWeb = txtWeb.Text.Trim();
            _config.NotasCotizacion = txtNotas.Text.Trim();
            _config.ValidezDias = (int)numValidez.Value;
            _config.TiempoEntrega = txtTiempoEntrega.Text.Trim();
            _config.PorcentajeIGV = numIGV.Value;
            _config.Moneda = txtMoneda.Text.Trim();

            if (_nuevoLogoBytes != null)
            {
                _config.LogoImage = _nuevoLogoBytes;
                _config.LogoNombreArchivo = _nuevoLogoNombre;
            }

            _config.DatosBancarios.Clear();
            foreach (DataGridViewRow row in dgvBancos.Rows)
            {
                if (row.IsNewRow) continue;
                var banco = row.Cells[0].Value?.ToString();
                if (string.IsNullOrWhiteSpace(banco)) continue;
                _config.DatosBancarios.Add(new BancoInfo
                {
                    Banco = banco,
                    Cuenta = row.Cells[1].Value?.ToString(),
                    CCI = row.Cells[2].Value?.ToString()
                });
            }

            if (EmpresaService.GuardarConfiguracion(_config))
            {
                MessageBox.Show("Configuración guardada. El logo y datos se usarán en los PDFs.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _nuevoLogoBytes = null;
                CargarConfiguracion();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmConfigEmpresa_Load(object sender, EventArgs e)
        {

        }
    }
}
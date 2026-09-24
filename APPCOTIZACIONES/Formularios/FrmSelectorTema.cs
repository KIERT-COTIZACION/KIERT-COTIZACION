using System;
using System.Drawing;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmSelectorTema : Form
    {
        private Color _primario;
        private Color _secundario;
        private Color _terciario;
        private Color _fondo;
        private Color _colorPdf;

        public bool TemaAplicado { get; private set; } = false;

        public FrmSelectorTema()
        {
            InitializeComponent();

            _primario = TemaService.ColorPrimario;
            _secundario = TemaService.ColorSecundario;
            _terciario = TemaService.ColorTerciario;
            _fondo = TemaService.ColorFondo;
            _colorPdf = TemaService.ColorPdf;

            cmbPaletas.Items.Clear();
            foreach (var p in TemaService.PaletasDisponibles)
                cmbPaletas.Items.Add(p.Nombre);
            cmbPaletas.SelectedIndex = 0;

            ActualizarVista();
        }

        private void ActualizarVista()
        {
            txtPrimario.Text = TemaService.ColorToHex(_primario);
            txtSecundario.Text = TemaService.ColorToHex(_secundario);
            txtTerciario.Text = TemaService.ColorToHex(_terciario);
            txtFondo.Text = TemaService.ColorToHex(_fondo);
            txtPdf.Text = TemaService.ColorToHex(_colorPdf);

            picPrimario.BackColor = _primario;
            picSecundario.BackColor = _secundario;
            picTerciario.BackColor = _terciario;
            picFondo.BackColor = _fondo;
            picPdf.BackColor = _colorPdf;

            pnlPreviewPrimario.BackColor = _primario;
            pnlPreviewPrimario.ForeColor = TemaService.CalcularTextoContraste(_primario);

            pnlPreviewSecundario.BackColor = _secundario;
            pnlPreviewSecundario.ForeColor = TemaService.CalcularTextoContraste(_secundario);

            pnlPreviewTerciario.BackColor = _terciario;
            pnlPreviewTerciario.ForeColor = TemaService.CalcularTextoContraste(_terciario);

            pnlPreviewFondo.BackColor = _fondo;
            pnlPreviewFondo.ForeColor = TemaService.CalcularTextoContraste(_fondo);

            pnlPreviewPdf.BackColor = _colorPdf;
            pnlPreviewPdf.ForeColor = TemaService.CalcularTextoContraste(_colorPdf);

            lblContrastePrimario.Text = $"Texto: {(TemaService.CalcularTextoContraste(_primario) == Color.White ? "BLANCO" : "NEGRO")}";
            lblContrasteSecundario.Text = $"Texto: {(TemaService.CalcularTextoContraste(_secundario) == Color.White ? "BLANCO" : "NEGRO")}";
            lblContrasteTerciario.Text = $"Texto: {(TemaService.CalcularTextoContraste(_terciario) == Color.White ? "BLANCO" : "NEGRO")}";
            lblContrasteFondo.Text = $"Texto: {(TemaService.CalcularTextoContraste(_fondo) == Color.White ? "BLANCO" : "NEGRO")}";
            lblContrastePdf.Text = $"Texto: {(TemaService.CalcularTextoContraste(_colorPdf) == Color.White ? "BLANCO" : "NEGRO")}";
        }

        private void btnPickPrimario_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = _primario;
                cd.FullOpen = true;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _primario = cd.Color;
                    _colorPdf = _primario; // El PDF sigue al primario
                    ActualizarVista();
                }
            }
        }

        private void btnPickSecundario_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = _secundario;
                cd.FullOpen = true;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _secundario = cd.Color;
                    ActualizarVista();
                }
            }
        }

        private void btnPickTerciario_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = _terciario;
                cd.FullOpen = true;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _terciario = cd.Color;
                    ActualizarVista();
                }
            }
        }

        private void btnPickFondo_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = _fondo;
                cd.FullOpen = true;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _fondo = cd.Color;
                    ActualizarVista();
                }
            }
        }

        private void btnPickPdf_Click(object sender, EventArgs e)
        {
            using (var cd = new ColorDialog())
            {
                cd.Color = _colorPdf;
                cd.FullOpen = true;
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    _colorPdf = cd.Color;
                    ActualizarVista();
                }
            }
        }

        private void cmbPaletas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idx = cmbPaletas.SelectedIndex;
            if (idx < 0) return;
            var paletas = TemaService.PaletasDisponibles;
            if (idx >= paletas.Length) return;

            var p = paletas[idx];
            _primario = p.Primario;
            _secundario = p.Secundario;
            _terciario = p.Terciario;
            _fondo = p.Fondo;
            _colorPdf = p.Primario;
            ActualizarVista();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Aplicar y guardar este tema?\n\n" +
                "• Los formularios usarán los colores de la app.\n" +
                "• El PDF usará el color seleccionado.",
                "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TemaService.AplicarPaleta(_primario, _secundario, _terciario, _fondo);
                TemaService.EstablecerColorPdf(_colorPdf);

                try
                {
                    var config = EmpresaService.ObtenerConfiguracion();
                    config.ColorPrimario = TemaService.ColorToHex(TemaService.ColorPrimario);
                    config.ColorSecundario = TemaService.ColorToHex(TemaService.ColorSecundario);
                    config.ColorTerciario = TemaService.ColorToHex(TemaService.ColorTerciario);
                    config.ColorFondo = TemaService.ColorToHex(TemaService.ColorFondo);
                    config.ColorPdf = TemaService.ColorToHex(TemaService.ColorPdf);
                    EmpresaService.GuardarConfiguracion(config);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tema aplicado, pero no se pudo guardar en BD:\n" + ex.Message,
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TemaAplicado = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            var p = TemaService.PaletasDisponibles[0];
            _primario = p.Primario;
            _secundario = p.Secundario;
            _terciario = p.Terciario;
            _fondo = p.Fondo;
            _colorPdf = p.Primario;
            cmbPaletas.SelectedIndex = 0;
            ActualizarVista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
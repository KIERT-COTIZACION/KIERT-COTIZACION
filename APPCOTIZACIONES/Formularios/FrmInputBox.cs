using System;
using System.Drawing;
using System.Windows.Forms;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmInputBox : Form
    {
        public string Valor { get; private set; } = "";

        public FrmInputBox(string titulo, string mensaje, string valorInicial = "")
        {
            InitializeComponent();
            this.Text = titulo;
            lblMensaje.Text = mensaje;
            txtValor.Text = valorInicial;
            Valor = valorInicial;

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Valor = txtValor.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancelar_Click(sender, e);
            }
        }

        private void FrmInputBox_Load(object sender, EventArgs e)
        {
            txtValor.Focus();
            txtValor.SelectAll();
        }
    }
}
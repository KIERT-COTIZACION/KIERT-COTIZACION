using System;
using System.Windows.Forms;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmLogin : Form
    {
        public Usuario UsuarioLogueado { get; private set; }

        public FrmLogin()
        {
            InitializeComponent();

            // Aplicar tema guardado
            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Ingrese usuario y contraseña.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }

            try
            {
                var user = UsuarioService.ValidarLogin(usuario, password);
                if (user != null)
                {
                    UsuarioLogueado = user;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión:\n\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            using (var registro = new FrmRegistro())
            {
                if (registro.ShowDialog() == DialogResult.OK)
                {
                    // Prellenar el usuario recién creado
                    txtUsuario.Text = registro.UsuarioCreado;
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        // Permitir Enter para hacer login
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
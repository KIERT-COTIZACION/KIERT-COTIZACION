using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmRegistro : Form
    {
        public string UsuarioCreado { get; private set; }

        public FrmRegistro()
        {
            InitializeComponent();

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string password = txtPassword.Text;
            string confirmar = txtConfirmar.Text;
            string nombre = txtNombre.Text.Trim();
            string email = txtEmail.Text.Trim();

            // ============ VALIDACIONES ============
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("El nombre de usuario es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (usuario.Length < 3)
            {
                MessageBox.Show("El usuario debe tener al menos 3 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (!Regex.IsMatch(usuario, @"^[a-zA-Z0-9_.-]+$"))
            {
                MessageBox.Show("El usuario solo puede contener letras, números, puntos, guiones y guiones bajos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre completo es obligatorio.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("La contraseña es obligatoria.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            if (password != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmar.Clear();
                txtConfirmar.Focus();
                return;
            }
            if (!string.IsNullOrWhiteSpace(email) && !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // ============ CREAR USUARIO ============
            try
            {
                // Por defecto los nuevos usuarios son "vendedor"
                bool ok = UsuarioService.CrearUsuario(usuario, password, nombre, email, "vendedor");

                if (ok)
                {
                    MessageBox.Show(
                        $"¡Usuario '{usuario}' creado correctamente!\n\n" +
                        "Ya puedes iniciar sesión con tus credenciales.",
                        "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UsuarioCreado = usuario;
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("No se pudo crear el usuario.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al registrar",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            char ch = chkMostrar.Checked ? '\0' : '●';
            txtPassword.PasswordChar = ch;
            txtConfirmar.PasswordChar = ch;
        }
    }
}
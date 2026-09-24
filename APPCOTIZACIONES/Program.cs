using System;
using System.Windows.Forms;
using COTIZACIONES.Formularios;

namespace COTIZACIONES
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // Mostrar el formulario de Login primero
                using (var login = new FrmLogin())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        // Si el login fue exitoso, abrir el menú principal
                        Application.Run(new FrmMenuPrincipal(login.UsuarioLogueado));
                    }
                    // Si el usuario cierra el login, la aplicación termina
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error fatal al iniciar la aplicación:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
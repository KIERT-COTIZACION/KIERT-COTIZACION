using System;
using System.Drawing;
using System.Windows.Forms;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmMenuPrincipal : Form
    {
        private Usuario _usuario;

        public FrmMenuPrincipal(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            // Información del usuario en el header
            lblBienvenida.Text = $"👤 {usuario.NombreCompleto}";
            lblRol.Text = $"Rol: {usuario.Rol.ToUpper()}";

            // ✅ Registrar el evento Paint AQUÍ (fuera del diseñador)
            panelBotones.Paint += PanelBotones_Paint;

            // Aplicar el tema guardado al cargar
            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { /* Si falla, no rompe el form */ }
        }

        // ✅ Evento Paint para dibujar el borde sutil del panel de botones
        private void PanelBotones_Paint(object sender, PaintEventArgs e)
        {
            var rect = panelBotones.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using (var pen = new Pen(Color.FromArgb(220, 220, 220)))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            new FrmProductos().ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            new FrmInventario().ShowDialog();
        }

        private void btnNuevaCotizacion_Click(object sender, EventArgs e)
        {
            new FrmCotizacion(_usuario).ShowDialog();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            new FrmHistorial().ShowDialog();
        }

        private void btnConfigEmpresa_Click(object sender, EventArgs e)
        {
            if (_usuario.Rol != "admin")
            {
                MessageBox.Show("Solo el administrador puede configurar la empresa.",
                    "Permiso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            new FrmConfigEmpresa().ShowDialog();
        }

        private void btnTema_Click(object sender, EventArgs e)
        {
            using (var dlg = new FrmSelectorTema())
            {
                if (dlg.ShowDialog() == DialogResult.OK && dlg.TemaAplicado)
                {
                    try
                    {
                        // Guardar el tema en BD
                        var config = EmpresaService.ObtenerConfiguracion();
                        config.ColorPrimario = TemaService.ColorToHex(TemaService.ColorPrimario);
                        config.ColorSecundario = TemaService.ColorToHex(TemaService.ColorSecundario);
                        config.ColorTerciario = TemaService.ColorToHex(TemaService.ColorTerciario);
                        config.ColorFondo = TemaService.ColorToHex(TemaService.ColorFondo);
                        EmpresaService.GuardarConfiguracion(config);

                        // Aplicar a este formulario
                        TemaService.AplicarTemaAFormulario(this);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tema aplicado, pero no se pudo guardar:\n" + ex.Message,
                            "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir del sistema?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            // Evento Load (vacío, listo por si necesitas usarlo)
        }
    }
}
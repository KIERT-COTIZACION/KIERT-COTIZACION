using System;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;

namespace COTIZACIONES.Formularios
{
    public partial class FrmClientes : Form
    {
        private Cliente _actual;

        public FrmClientes()
        {
            InitializeComponent();
            Cargar();
            Limpiar();
        }

        private void Cargar()
        {
            try
            {
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = Repositorio.ObtenerClientes();

                if (dgvClientes.Columns.Count > 0)
                {
                    if (dgvClientes.Columns["Id"] != null) dgvClientes.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtDocumento.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtDireccion.Clear();
            _actual = null;
            txtNombre.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDocumento.Text))
            {
                MessageBox.Show("Nombre y Documento son obligatorios.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_actual == null)
                {
                    Repositorio.InsertarCliente(new Cliente
                    {
                        Nombre = txtNombre.Text.Trim(),
                        Documento = txtDocumento.Text.Trim(),
                        Telefono = txtTelefono.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim()
                    });
                    MessageBox.Show("Cliente agregado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _actual.Nombre = txtNombre.Text.Trim();
                    _actual.Documento = txtDocumento.Text.Trim();
                    _actual.Telefono = txtTelefono.Text.Trim();
                    _actual.Email = txtEmail.Text.Trim();
                    _actual.Direccion = txtDireccion.Text.Trim();
                    Repositorio.ActualizarCliente(_actual);
                    MessageBox.Show("Cliente actualizado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                Cargar();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente c)
            {
                _actual = c;
                txtNombre.Text = c.Nombre;
                txtDocumento.Text = c.Documento;
                txtTelefono.Text = c.Telefono;
                txtEmail.Text = c.Email;
                txtDireccion.Text = c.Direccion;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow?.DataBoundItem is Cliente c)
            {
                if (MessageBox.Show($"¿Eliminar al cliente '{c.Nombre}'?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Repositorio.EliminarCliente(c.Id);
                        Cargar();
                        Limpiar();
                        MessageBox.Show("Cliente eliminado.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar:\n" + ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
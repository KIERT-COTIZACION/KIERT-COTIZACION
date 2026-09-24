using System;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmProductos : Form
    {
        private Producto _actual;

        public FrmProductos()
        {
            InitializeComponent();
            Cargar();
            Limpiar();

            // Aplicar tema guardado
            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void Cargar()
        {
            try
            {
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = Repositorio.ObtenerProductos();

                if (dgvProductos.Columns.Count > 0)
                {
                    if (dgvProductos.Columns["Id"] != null)
                        dgvProductos.Columns["Id"].Visible = false;
                    if (dgvProductos.Columns["Precio"] != null)
                        dgvProductos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            _actual = null;
            txtCodigo.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                !decimal.TryParse(txtPrecio.Text, out decimal precio) ||
                !int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Complete todos los campos. Precio y Stock deben ser numéricos.",
                    "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_actual == null)
                {
                    Repositorio.InsertarProducto(new Producto
                    {
                        Codigo = txtCodigo.Text.Trim(),
                        Descripcion = txtDescripcion.Text.Trim(),
                        Precio = precio,
                        Stock = stock
                    });
                    MessageBox.Show("Producto agregado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _actual.Codigo = txtCodigo.Text.Trim();
                    _actual.Descripcion = txtDescripcion.Text.Trim();
                    _actual.Precio = precio;
                    _actual.Stock = stock;
                    Repositorio.ActualizarProducto(_actual);
                    MessageBox.Show("Producto actualizado correctamente.",
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
            if (dgvProductos.CurrentRow?.DataBoundItem is Producto p)
            {
                _actual = p;
                txtCodigo.Text = p.Codigo;
                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString("0.00");
                txtStock.Text = p.Stock.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow?.DataBoundItem is Producto p)
            {
                if (MessageBox.Show($"¿Eliminar el producto '{p.Descripcion}'?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        Repositorio.EliminarProducto(p.Id);
                        Cargar();
                        Limpiar();
                        MessageBox.Show("Producto eliminado.",
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
                MessageBox.Show("Seleccione un producto de la lista.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
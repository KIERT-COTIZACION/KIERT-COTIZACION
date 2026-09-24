using System;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmSelectorTallaColor : Form
    {
        private int _productoId;

        public InventarioItem ItemSeleccionado { get; private set; }

        public FrmSelectorTallaColor(int productoId, string productoNombre)
        {
            InitializeComponent();
            _productoId = productoId;
            lblProducto.Text = "📦 Producto: " + productoNombre;

            dgvItems.AutoGenerateColumns = false;
            dgvItems.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(250, 248, 245);

            CargarItems();

            try
            {
                TemaService.AplicarTemaAFormulario(this);
            }
            catch { }
        }

        private void CargarItems()
        {
            try
            {
                var items = Repositorio.ObtenerInventarioPorProducto(_productoId);
                dgvItems.Rows.Clear();
                foreach (var it in items)
                    dgvItems.Rows.Add(it.Id, it.Talla, it.Color);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) Seleccionar();
        }

        private void Seleccionar()
        {
            if (dgvItems.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un registro.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(dgvItems.CurrentRow.Cells[0].Value);
            string talla = dgvItems.CurrentRow.Cells[1].Value?.ToString();
            string color = dgvItems.CurrentRow.Cells[2].Value?.ToString();

            ItemSeleccionado = new InventarioItem
            {
                Id = id,
                ProductoId = _productoId,
                Talla = talla,
                Color = color
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
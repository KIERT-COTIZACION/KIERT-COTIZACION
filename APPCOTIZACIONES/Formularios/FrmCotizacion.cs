using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using COTIZACIONES.Datos;
using COTIZACIONES.Modelos;
using COTIZACIONES.Servicios;

namespace COTIZACIONES.Formularios
{
    public partial class FrmCotizacion : Form
    {
        private Usuario _usuario;
        private EmpresaConfig _empresa;
        private List<DetalleCotizacion> _items = new List<DetalleCotizacion>();
        private List<Cliente> _clientes;
        private List<Producto> _productos;
        private string _numero;

        // ✅ NUEVO: producto "libre" cuando el usuario escribe uno que no está en el catálogo
        private Producto _productoLibre = null;

        public FrmCotizacion(Usuario usuario)
        {
            InitializeComponent();
            _usuario = usuario;

            _empresa = EmpresaService.ObtenerConfiguracion();
            if (_empresa == null)
            {
                _empresa = new EmpresaConfig
                {
                    NombreEmpresa = "MI EMPRESA",
                    Moneda = "S/",
                    PorcentajeIGV = 18m,
                    ValidezDias = 30,
                    TiempoEntrega = "5-10 días hábiles"
                };
            }

            _numero = CotizacionService.GenerarNumero();

            lblEmpresa.Text = _empresa.NombreEmpresa ?? "MI EMPRESA";
            lblNumero.Text = "N°: " + _numero;
            numIGV.Value = _empresa.PorcentajeIGV > 0 ? _empresa.PorcentajeIGV : 18m;
            numIGV.Enabled = true;
            chkIGV.Checked = true;

            CargarCombos();
            ActualizarTotales();
            CargarTallasColores();

            try { TemaService.AplicarTemaAFormulario(this); } catch { }
        }

        private void FrmCotizacion_Load(object sender, EventArgs e) { }

        // ==========================================================
        // CARGAR COMBOS
        // ==========================================================
        private void CargarCombos()
        {
            _clientes = Repositorio.ObtenerClientes();
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = _clientes;
            cmbCliente.DisplayMember = "ToString";

            _productos = Repositorio.ObtenerProductos();
            cmbProducto.DataSource = null;
            cmbProducto.DataSource = _productos;
            cmbProducto.DisplayMember = "ToString";

            // ✅ Permitir escribir productos que no están en el catálogo
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDown;
            cmbProducto.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbProducto.AutoCompleteSource = AutoCompleteSource.ListItems;

            cmbProducto.SelectedIndexChanged += (s, e) =>
            {
                if (cmbProducto.SelectedItem is Producto p)
                {
                    _productoLibre = null;
                    txtPrecio.Text = p.Precio.ToString("0.00");
                    CargarTallasColores();
                }
            };

            // ✅ Cuando el usuario escribe algo que no está en la lista
            cmbProducto.TextUpdate += (s, e) =>
            {
                string texto = cmbProducto.Text.Trim();
                if (string.IsNullOrEmpty(texto))
                {
                    _productoLibre = null;
                    return;
                }

                // Si coincide exactamente con uno del catálogo, no es libre
                var encontrado = _productos.FirstOrDefault(p =>
                    p.ToString().Equals(texto, StringComparison.OrdinalIgnoreCase));

                if (encontrado != null)
                {
                    _productoLibre = null;
                    CargarTallasColores();
                }
                else
                {
                    // Es un producto libre
                    _productoLibre = new Producto
                    {
                        Id = 0,
                        Codigo = "LIBRE",
                        Descripcion = texto,
                        Precio = 0m,
                        Stock = 0
                    };
                    CargarTallasColores();
                }
            };

            if (_productos.Count > 0)
                txtPrecio.Text = _productos[0].Precio.ToString("0.00");
        }

        // ==========================================================
        // CARGAR TALLAS Y COLORES
        // ==========================================================
        private void CargarTallasColores()
        {
            string tallaActual = cmbTalla.Text;
            string colorActual = cmbColor.Text;

            cmbTalla.Items.Clear();
            cmbColor.Items.Clear();

            // Si es producto libre → tallas y colores genéricos editables
            if (_productoLibre != null)
            {
                var tallasGen = new[] { "XS", "S", "M", "L", "XL", "XXL", "Única" };
                var coloresGen = new[] { "Negro", "Blanco", "Rojo", "Azul", "Verde", "Gris", "Beige" };

                foreach (var t in tallasGen) cmbTalla.Items.Add(t);
                foreach (var c in coloresGen) cmbColor.Items.Add(c);

                cmbTalla.Text = tallaActual;
                cmbColor.Text = colorActual;
                return;
            }

            if (!(cmbProducto.SelectedItem is Producto p))
                return;

            var items = Repositorio.ObtenerInventarioPorProducto(p.Id);

            var tallas = items
                .Where(i => !string.IsNullOrEmpty(i.Talla))
                .Select(i => i.Talla)
                .Distinct()
                .OrderBy(t => t)
                .ToList();

            var colores = items
                .Where(i => !string.IsNullOrEmpty(i.Color))
                .Select(i => i.Color)
                .Distinct()
                .OrderBy(c => c)
                .ToList();

            if (tallas.Count == 0)
                tallas.AddRange(new[] { "XS", "S", "M", "L", "XL", "XXL" });

            foreach (var t in tallas) cmbTalla.Items.Add(t);
            foreach (var c in colores) cmbColor.Items.Add(c);

            cmbTalla.Text = string.IsNullOrEmpty(tallaActual) ? "" : tallaActual;
            cmbColor.Text = string.IsNullOrEmpty(colorActual) ? "" : colorActual;
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if (numCantidad.Value > numCantidad.Minimum)
                numCantidad.Value -= 1;
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (numCantidad.Value < numCantidad.Maximum)
                numCantidad.Value += 1;
        }

        // ==========================================================
        // AGREGAR A LA LISTA
        // ==========================================================
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = null;

            // ✅ Si el usuario escribió un producto libre
            if (_productoLibre != null)
            {
                p = _productoLibre;
                p.Descripcion = cmbProducto.Text.Trim();
            }
            else if (cmbProducto.SelectedItem is Producto seleccionado)
            {
                p = seleccionado;
            }
            else
            {
                // No seleccionó ni escribió nada
                string texto = cmbProducto.Text.Trim();
                if (string.IsNullOrEmpty(texto))
                {
                    MessageBox.Show("Seleccione o escriba un producto.", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear producto libre con lo que escribió
                p = new Producto
                {
                    Id = 0,
                    Codigo = "LIBRE",
                    Descripcion = texto,
                    Precio = 0m,
                    Stock = 0
                };
                _productoLibre = p;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("Precio inválido.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int cant = (int)numCantidad.Value;
            string talla = cmbTalla.Text.Trim();
            string color = cmbColor.Text.Trim();

            if (string.IsNullOrEmpty(talla)) talla = "—";
            if (string.IsNullOrEmpty(color)) color = "—";

            bool esLibre = _productoLibre != null || p.Id == 0;

            var existente = _items.FirstOrDefault(x =>
                x.ProductoId == p.Id &&
                x.Descripcion == p.Descripcion &&
                (x.Talla ?? "—") == talla &&
                (x.Color ?? "—") == color);

            if (existente != null)
            {
                existente.Cantidad += cant;
            }
            else
            {
                _items.Add(new DetalleCotizacion
                {
                    ProductoId = p.Id,
                    Codigo = esLibre ? "LIBRE" : p.Codigo,
                    Descripcion = p.Descripcion,
                    Talla = talla,
                    Color = color,
                    Precio = precio,
                    Cantidad = cant,
                    EsLibre = esLibre
                });
            }

            Refrescar();
            numCantidad.Value = 1;
            cmbTalla.Text = "";
            cmbColor.Text = "";
        }

        // ==========================================================
        // REFRESCAR TABLA
        // ==========================================================
        private void Refrescar()
        {
            dgvDetalle.DataSource = null;
            dgvDetalle.DataSource = _items.Select(x => new
            {
                x.Codigo,
                x.Descripcion,
                Talla = x.Talla ?? "—",
                Color = x.Color ?? "—",
                Precio = x.Precio,
                x.Cantidad,
                Subtotal = x.Subtotal
            }).ToList();

            if (dgvDetalle.Columns.Count > 0)
            {
                dgvDetalle.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvDetalle.Columns["Subtotal"].DefaultCellStyle.Format = "N2";
            }
            ActualizarTotales();
        }

        private void ActualizarTotales()
        {
            decimal sub = _items.Sum(x => x.Subtotal);
            decimal igv = chkIGV.Checked ? sub * (numIGV.Value / 100m) : 0;
            decimal tot = sub + igv;

            lblSubtotal.Text = $"Subtotal: {_empresa.Moneda} {sub:F2}";
            lblIGV.Text = chkIGV.Checked
                ? $"IGV ({numIGV.Value}%): {_empresa.Moneda} {igv:F2}"
                : "IGV: NO APLICA";
            lblTotal.Text = $"TOTAL: {_empresa.Moneda} {tot:F2}";
        }

        private void chkIGV_CheckedChanged(object sender, EventArgs e) => ActualizarTotales();
        private void numIGV_ValueChanged(object sender, EventArgs e) => ActualizarTotales();

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null) return;

            string codigo = dgvDetalle.CurrentRow.Cells["Codigo"].Value?.ToString();
            string desc = dgvDetalle.CurrentRow.Cells["Descripcion"].Value?.ToString();
            string talla = dgvDetalle.CurrentRow.Cells["Talla"].Value?.ToString();
            string color = dgvDetalle.CurrentRow.Cells["Color"].Value?.ToString();

            var item = _items.FirstOrDefault(x =>
                x.Codigo == codigo &&
                x.Descripcion == desc &&
                (x.Talla ?? "—") == talla &&
                (x.Color ?? "—") == color);

            if (item != null) _items.Remove(item);
            Refrescar();
        }

        private Cotizacion ConstruirCotizacion()
        {
            var cli = cmbCliente.SelectedItem as Cliente;
            return new Cotizacion
            {
                Numero = _numero,
                ClienteId = cli?.Id,
                ClienteNombre = cli?.Nombre,
                ClienteDocumento = cli?.Documento,
                Detalles = new List<DetalleCotizacion>(_items),
                ConIGV = chkIGV.Checked,
                PorcentajeIGV = numIGV.Value,
                Observaciones = txtObservaciones.Text.Trim(),
                UsuarioId = _usuario.Id
            };
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                var cot = ConstruirCotizacion();
                CotizacionService.GuardarCotizacion(cot);
                MessageBox.Show($"Cotización {cot.Numero} guardada correctamente.",
                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reiniciar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reiniciar()
        {
            _items.Clear();
            _productoLibre = null;
            Refrescar();
            txtObservaciones.Clear();
            cmbProducto.Text = "";
            cmbTalla.Text = "";
            cmbColor.Text = "";
            numCantidad.Value = 1;
            _numero = CotizacionService.GenerarNumero();
            lblNumero.Text = "N°: " + _numero;
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Crear nueva cotización?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Reiniciar();
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF|*.pdf";
                sfd.FileName = $"Cotizacion_{_numero}.pdf";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var cot = ConstruirCotizacion();
                    var cli = cmbCliente.SelectedItem as Cliente;

                    PdfService.GenerarPdf(sfd.FileName, _empresa, cot.Numero,
                        cli?.Nombre ?? "CLIENTE", cli?.Documento ?? "",
                        cli?.Telefono ?? "", cli?.Email ?? "", cli?.Direccion ?? "",
                        _usuario.NombreCompleto, "Contado",
                        cot.ConIGV, cot.Subtotal, cot.Impuesto, cot.Total,
                        cot.Detalles, NumeroALetras(cot.Total));

                    CotizacionService.GuardarCotizacion(cot);

                    if (MessageBox.Show("PDF generado. ¿Abrirlo?", "Éxito",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        Process.Start(new ProcessStartInfo(sfd.FileName) { UseShellExecute = true });

                    Reiniciar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error PDF:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (_items.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel|*.xls";
                sfd.FileName = $"Cotizacion_{_numero}.xls";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                try
                {
                    var cot = ConstruirCotizacion();
                    var cli = cmbCliente.SelectedItem as Cliente;

                    ExcelService.Exportar(sfd.FileName, _empresa, cot.Numero,
                        cli?.Nombre ?? "CLIENTE", cli?.Documento ?? "",
                        cli?.Telefono ?? "", cli?.Email ?? "", cli?.Direccion ?? "",
                        _usuario.NombreCompleto, cot.ConIGV,
                        cot.Subtotal, cot.Impuesto, cot.Total, cot.Detalles,
                        NumeroALetras(cot.Total));

                    MessageBox.Show("Excel exportado:\n" + sfd.FileName, "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Excel:\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string NumeroALetras(decimal n)
        {
            long entero = (long)n;
            int cent = (int)((n - entero) * 100);
            return $"{entero} CON {cent:D2}/100 {(_empresa.Moneda == "S/" ? "SOLES" : "DÓLARES")}";
        }

        private void btnCerrar_Click(object sender, EventArgs e) => Close();
    }
}
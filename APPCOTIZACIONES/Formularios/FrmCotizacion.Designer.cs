namespace COTIZACIONES.Formularios
{
    partial class FrmCotizacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnMas = new System.Windows.Forms.Button();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.chkIGV = new System.Windows.Forms.CheckBox();
            this.numIGV = new System.Windows.Forms.NumericUpDown();
            this.lblIGVTag = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblIGV = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblObsTag = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIGV)).BeginInit();
            this.SuspendLayout();

            // lblEmpresa
            this.lblEmpresa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEmpresa.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblEmpresa.Location = new System.Drawing.Point(15, 10);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(500, 30);
            this.lblEmpresa.TabIndex = 0;

            // lblNumero
            this.lblNumero.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblNumero.Location = new System.Drawing.Point(680, 15);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(320, 25);
            this.lblNumero.TabIndex = 1;
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblCliente
            this.lblCliente.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCliente.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblCliente.Location = new System.Drawing.Point(15, 55);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";

            // cmbCliente
            this.cmbCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCliente.Location = new System.Drawing.Point(80, 52);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(400, 21);
            this.cmbCliente.TabIndex = 3;

            // lblProducto
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblProducto.Location = new System.Drawing.Point(15, 90);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 20);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Text = "Producto:";

            // cmbProducto
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.Location = new System.Drawing.Point(80, 87);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(280, 21);
            this.cmbProducto.TabIndex = 5;

            // lblTalla
            this.lblTalla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTalla.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblTalla.Location = new System.Drawing.Point(370, 90);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(45, 20);
            this.lblTalla.TabIndex = 26;
            this.lblTalla.Text = "Talla:";

            // cmbTalla (permite escribir y seleccionar)
            this.cmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTalla.Location = new System.Drawing.Point(415, 87);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(110, 21);
            this.cmbTalla.TabIndex = 27;
            this.cmbTalla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbTalla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            // lblColor
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblColor.Location = new System.Drawing.Point(535, 90);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(45, 20);
            this.lblColor.TabIndex = 28;
            this.lblColor.Text = "Color:";

            // cmbColor (permite escribir y seleccionar)
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbColor.Location = new System.Drawing.Point(580, 87);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(120, 21);
            this.cmbColor.TabIndex = 29;
            this.cmbColor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbColor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;

            // lblCantidad
            this.lblCantidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblCantidad.Location = new System.Drawing.Point(710, 90);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(45, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cant:";

            // numCantidad
            this.numCantidad.Location = new System.Drawing.Point(755, 88);
            this.numCantidad.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.Name = "numCantidad";
            this.numCantidad.Size = new System.Drawing.Size(60, 20);
            this.numCantidad.TabIndex = 7;
            this.numCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // btnMenos
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnMenos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenos.ForeColor = System.Drawing.Color.White;
            this.btnMenos.Location = new System.Drawing.Point(815, 87);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(28, 23);
            this.btnMenos.TabIndex = 30;
            this.btnMenos.Text = "−";
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);

            // btnMas
            this.btnMas.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnMas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMas.FlatAppearance.BorderSize = 0;
            this.btnMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMas.ForeColor = System.Drawing.Color.White;
            this.btnMas.Location = new System.Drawing.Point(845, 87);
            this.btnMas.Name = "btnMas";
            this.btnMas.Size = new System.Drawing.Size(28, 23);
            this.btnMas.TabIndex = 31;
            this.btnMas.Text = "+";
            this.btnMas.UseVisualStyleBackColor = false;
            this.btnMas.Click += new System.EventHandler(this.btnMas_Click);

            // lblPrecio
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblPrecio.Location = new System.Drawing.Point(15, 125);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(80, 122);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 9;

            // btnAgregar
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(200, 118);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "➕ AGREGAR A LA LISTA";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // dgvDetalle
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.dgvDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDetalle.ColumnHeadersHeight = 32;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDetalle.Location = new System.Drawing.Point(15, 160);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersVisible = false;
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(985, 220);
            this.dgvDetalle.TabIndex = 11;

            // btnQuitar
            this.btnQuitar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuitar.ForeColor = System.Drawing.Color.White;
            this.btnQuitar.Location = new System.Drawing.Point(15, 390);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(170, 30);
            this.btnQuitar.TabIndex = 12;
            this.btnQuitar.Text = "🗑️ Quitar seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);

            // chkIGV
            this.chkIGV.Checked = true;
            this.chkIGV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIGV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.chkIGV.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.chkIGV.Location = new System.Drawing.Point(200, 393);
            this.chkIGV.Name = "chkIGV";
            this.chkIGV.Size = new System.Drawing.Size(100, 25);
            this.chkIGV.TabIndex = 13;
            this.chkIGV.Text = "Incluir IGV";
            this.chkIGV.CheckedChanged += new System.EventHandler(this.chkIGV_CheckedChanged);

            // numIGV
            this.numIGV.DecimalPlaces = 2;
            this.numIGV.Location = new System.Drawing.Point(310, 393);
            this.numIGV.Name = "numIGV";
            this.numIGV.Size = new System.Drawing.Size(60, 20);
            this.numIGV.TabIndex = 14;
            this.numIGV.Value = new decimal(new int[] { 18, 0, 0, 0 });
            this.numIGV.ValueChanged += new System.EventHandler(this.numIGV_ValueChanged);

            // lblIGVTag
            this.lblIGVTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIGVTag.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblIGVTag.Location = new System.Drawing.Point(375, 396);
            this.lblIGVTag.Name = "lblIGVTag";
            this.lblIGVTag.Size = new System.Drawing.Size(30, 20);
            this.lblIGVTag.TabIndex = 15;
            this.lblIGVTag.Text = "%";

            // lblSubtotal
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtotal.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblSubtotal.Location = new System.Drawing.Point(720, 390);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(280, 20);
            this.lblSubtotal.TabIndex = 16;
            this.lblSubtotal.Text = "Subtotal: S/ 0.00";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblIGV
            this.lblIGV.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblIGV.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblIGV.Location = new System.Drawing.Point(720, 412);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(280, 20);
            this.lblIGV.TabIndex = 17;
            this.lblIGV.Text = "IGV: S/ 0.00";
            this.lblIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblTotal.Location = new System.Drawing.Point(720, 435);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(280, 25);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "TOTAL: S/ 0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblObsTag
            this.lblObsTag.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblObsTag.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblObsTag.Location = new System.Drawing.Point(15, 435);
            this.lblObsTag.Name = "lblObsTag";
            this.lblObsTag.Size = new System.Drawing.Size(120, 20);
            this.lblObsTag.TabIndex = 19;
            this.lblObsTag.Text = "Observaciones:";

            // txtObservaciones
            this.txtObservaciones.Location = new System.Drawing.Point(15, 455);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtObservaciones.Size = new System.Drawing.Size(680, 60);
            this.txtObservaciones.TabIndex = 20;

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(260, 530);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(140, 40);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "💾 GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnPdf
            this.btnPdf.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPdf.FlatAppearance.BorderSize = 0;
            this.btnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPdf.ForeColor = System.Drawing.Color.White;
            this.btnPdf.Location = new System.Drawing.Point(410, 530);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(140, 40);
            this.btnPdf.TabIndex = 22;
            this.btnPdf.Text = "📄 PDF";
            this.btnPdf.UseVisualStyleBackColor = false;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);

            // btnExcel
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnExcel.ForeColor = System.Drawing.Color.White;
            this.btnExcel.Location = new System.Drawing.Point(560, 530);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(140, 40);
            this.btnExcel.TabIndex = 23;
            this.btnExcel.Text = "📊 EXCEL";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);

            // btnNueva
            this.btnNueva.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnNueva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNueva.FlatAppearance.BorderSize = 0;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNueva.ForeColor = System.Drawing.Color.White;
            this.btnNueva.Location = new System.Drawing.Point(710, 530);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(130, 40);
            this.btnNueva.TabIndex = 24;
            this.btnNueva.Text = "✨ NUEVA";
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(850, 530);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(150, 40);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "❌ CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ============================================
            // FrmCotizacion
            // ============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.ClientSize = new System.Drawing.Size(1015, 590);

            // ✅ AGREGAR TODOS LOS CONTROLES AL FORMULARIO
            this.Controls.Add(this.lblEmpresa);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblTalla);
            this.Controls.Add(this.cmbTalla);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.cmbColor);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMas);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.chkIGV);
            this.Controls.Add(this.numIGV);
            this.Controls.Add(this.lblIGVTag);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblIGV);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblObsTag);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnNueva);
            this.Controls.Add(this.btnCerrar);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCotizacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Cotización";
            this.Load += new System.EventHandler(this.FrmCotizacion_Load);

            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ============================================
        // DECLARACIÓN DE CAMPOS
        // ============================================
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnMas;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.CheckBox chkIGV;
        private System.Windows.Forms.NumericUpDown numIGV;
        private System.Windows.Forms.Label lblIGVTag;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblObsTag;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnCerrar;
    }
}
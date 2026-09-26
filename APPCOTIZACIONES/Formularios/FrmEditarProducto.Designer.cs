namespace COTIZACIONES.Formularios
{
    partial class FrmEditarProducto
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblTalla = new System.Windows.Forms.Label();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.btnAgregarTC = new System.Windows.Forms.Button();
            this.dgvTallasColores = new System.Windows.Forms.DataGridView();
            this.colTallaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColorTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarTC = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallasColores)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.lblTitulo.Location = new System.Drawing.Point(15, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "✏️ Editando producto";

            // ============================
            // gbDatos
            // ============================
            this.gbDatos.Controls.Add(this.lblCodigo);
            this.gbDatos.Controls.Add(this.txtCodigo);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Controls.Add(this.lblPrecio);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.lblStock);
            this.gbDatos.Controls.Add(this.txtStock);
            this.gbDatos.Controls.Add(this.lblTalla);
            this.gbDatos.Controls.Add(this.cmbTalla);
            this.gbDatos.Controls.Add(this.lblColor);
            this.gbDatos.Controls.Add(this.cmbColor);
            this.gbDatos.Controls.Add(this.btnAgregarTC);
            this.gbDatos.Controls.Add(this.dgvTallasColores);
            this.gbDatos.Controls.Add(this.btnQuitarTC);
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gbDatos.Location = new System.Drawing.Point(12, 50);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(760, 380);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos del Producto";

            // lblCodigo
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblCodigo.Location = new System.Drawing.Point(15, 33);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(80, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";

            // txtCodigo
            this.txtCodigo.Location = new System.Drawing.Point(100, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(280, 23);
            this.txtCodigo.TabIndex = 1;

            // lblDescripcion
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblDescripcion.Location = new System.Drawing.Point(15, 68);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(80, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción:";

            // txtDescripcion
            this.txtDescripcion.Location = new System.Drawing.Point(100, 65);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 23);
            this.txtDescripcion.TabIndex = 3;

            // lblPrecio
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblPrecio.Location = new System.Drawing.Point(420, 33);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(60, 20);
            this.lblPrecio.TabIndex = 4;
            this.lblPrecio.Text = "Precio:";

            // txtPrecio
            this.txtPrecio.Location = new System.Drawing.Point(485, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(260, 23);
            this.txtPrecio.TabIndex = 5;

            // lblStock
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblStock.Location = new System.Drawing.Point(420, 68);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(60, 20);
            this.lblStock.TabIndex = 6;
            this.lblStock.Text = "Stock:";

            // txtStock
            this.txtStock.Location = new System.Drawing.Point(485, 65);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(260, 23);
            this.txtStock.TabIndex = 7;

            // lblTalla
            this.lblTalla.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTalla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblTalla.Location = new System.Drawing.Point(15, 110);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(80, 20);
            this.lblTalla.TabIndex = 8;
            this.lblTalla.Text = "Talla:";

            // cmbTalla
            this.cmbTalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTalla.Location = new System.Drawing.Point(100, 107);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(130, 23);
            this.cmbTalla.TabIndex = 9;
            this.cmbTalla.Items.AddRange(new object[] { "XS", "S", "M", "L", "XL", "XXL", "Única", "Estándar" });

            // lblColor
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblColor.Location = new System.Drawing.Point(245, 110);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(50, 20);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color:";

            // cmbColor
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbColor.Location = new System.Drawing.Point(300, 107);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(130, 23);
            this.cmbColor.TabIndex = 11;
            this.cmbColor.Items.AddRange(new object[] { "Negro", "Blanco", "Rojo", "Azul", "Verde", "Gris", "Beige", "Plateado" });

            // btnAgregarTC
            this.btnAgregarTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAgregarTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTC.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTC.Location = new System.Drawing.Point(450, 105);
            this.btnAgregarTC.Name = "btnAgregarTC";
            this.btnAgregarTC.Size = new System.Drawing.Size(295, 28);
            this.btnAgregarTC.TabIndex = 12;
            this.btnAgregarTC.Text = "➕ AGREGAR TALLA/COLOR";
            this.btnAgregarTC.UseVisualStyleBackColor = false;
            this.btnAgregarTC.Click += new System.EventHandler(this.btnAgregarTC_Click);

            // dgvTallasColores
            this.dgvTallasColores.AllowUserToAddRows = false;
            this.dgvTallasColores.AllowUserToDeleteRows = false;
            this.dgvTallasColores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTallasColores.BackgroundColor = System.Drawing.Color.White;
            this.dgvTallasColores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTallasColores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTallaTC,
                this.colColorTC});
            this.dgvTallasColores.Location = new System.Drawing.Point(15, 150);
            this.dgvTallasColores.Name = "dgvTallasColores";
            this.dgvTallasColores.ReadOnly = true;
            this.dgvTallasColores.RowHeadersVisible = false;
            this.dgvTallasColores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTallasColores.Size = new System.Drawing.Size(615, 210);
            this.dgvTallasColores.TabIndex = 13;

            // colTallaTC
            this.colTallaTC.HeaderText = "TALLA";
            this.colTallaTC.Name = "colTallaTC";
            this.colTallaTC.ReadOnly = true;

            // colColorTC
            this.colColorTC.HeaderText = "COLOR";
            this.colColorTC.Name = "colColorTC";
            this.colColorTC.ReadOnly = true;

            // btnQuitarTC
            this.btnQuitarTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnQuitarTC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitarTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarTC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuitarTC.ForeColor = System.Drawing.Color.White;
            this.btnQuitarTC.Location = new System.Drawing.Point(640, 150);
            this.btnQuitarTC.Name = "btnQuitarTC";
            this.btnQuitarTC.Size = new System.Drawing.Size(105, 210);
            this.btnQuitarTC.TabIndex = 14;
            this.btnQuitarTC.Text = "🗑️\r\nQUITAR";
            this.btnQuitarTC.UseVisualStyleBackColor = false;
            this.btnQuitarTC.Click += new System.EventHandler(this.btnQuitarTC_Click);

            // btnGuardar
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(400, 445);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 40);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "💾 GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // btnCancelar
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(592, 445);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(180, 40);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "❌ CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // FrmEditarProducto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(784, 500);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Producto";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallasColores)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.Button btnAgregarTC;
        private System.Windows.Forms.DataGridView dgvTallasColores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTallaTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorTC;
        private System.Windows.Forms.Button btnQuitarTC;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
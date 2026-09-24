namespace COTIZACIONES.Formularios
{
    partial class FrmDetalleProducto
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblTallasTitulo = new System.Windows.Forms.Label();
            this.dgvTallas = new System.Windows.Forms.DataGridView();
            this.colTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrar = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).BeginInit();
            this.SuspendLayout();

            // lblTitulo
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(600, 50);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🔍 DETALLE DEL PRODUCTO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblCodigo
            this.lblCodigo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblCodigo.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblCodigo.Location = new System.Drawing.Point(20, 65);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(500, 22);
            this.lblCodigo.TabIndex = 1;

            // lblNombre
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblNombre.Location = new System.Drawing.Point(20, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(500, 22);
            this.lblNombre.TabIndex = 2;

            // lblPrecio
            this.lblPrecio.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblPrecio.Location = new System.Drawing.Point(20, 115);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(300, 22);
            this.lblPrecio.TabIndex = 3;

            // lblStock
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblStock.Location = new System.Drawing.Point(20, 140);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(300, 22);
            this.lblStock.TabIndex = 4;

            // lblTallasTitulo
            this.lblTallasTitulo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTallasTitulo.ForeColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.lblTallasTitulo.Location = new System.Drawing.Point(20, 175);
            this.lblTallasTitulo.Name = "lblTallasTitulo";
            this.lblTallasTitulo.Size = new System.Drawing.Size(200, 22);
            this.lblTallasTitulo.TabIndex = 5;
            this.lblTallasTitulo.Text = "Tallas y Colores:";

            // dgvTallas
            this.dgvTallas.AllowUserToAddRows = false;
            this.dgvTallas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTallas.BackgroundColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.dgvTallas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTallas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTalla, this.colColor, this.colCantidad });
            this.dgvTallas.Location = new System.Drawing.Point(20, 200);
            this.dgvTallas.Name = "dgvTallas";
            this.dgvTallas.ReadOnly = true;
            this.dgvTallas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTallas.Size = new System.Drawing.Size(560, 250);
            this.dgvTallas.TabIndex = 6;

            this.colTalla.HeaderText = "Talla";
            this.colTalla.Name = "colTalla";
            this.colColor.HeaderText = "Color";
            this.colColor.Name = "colColor";
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";

            // btnCerrar
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.btnCerrar.Location = new System.Drawing.Point(480, 465);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(100, 35);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // FrmDetalleProducto
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            this.ClientSize = new System.Drawing.Size(600, 520);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblTallasTitulo);
            this.Controls.Add(this.dgvTallas);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalleProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Detalle del Producto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTallas)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitulo, lblCodigo, lblNombre, lblPrecio, lblStock, lblTallasTitulo;
        private System.Windows.Forms.DataGridView dgvTallas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalla, colColor, colCantidad;
        private System.Windows.Forms.Button btnCerrar;
    }
}
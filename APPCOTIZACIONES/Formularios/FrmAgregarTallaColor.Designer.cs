namespace COTIZACIONES.Formularios
{
    partial class FrmAgregarTallaColor
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlProducto = new System.Windows.Forms.Panel();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTalla = new System.Windows.Forms.Label();
            this.txtTalla = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvExistentes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTalla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistentes)).BeginInit();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();

            // ============================================
            // pnlHeader
            // ============================================
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.pnlHeader.Controls.Add(this.lblTitulo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(700, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "➕  AGREGAR TALLA Y COLOR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ============================================
            // pnlProducto
            // ============================================
            this.pnlProducto.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProducto.Location = new System.Drawing.Point(0, 60);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(700, 45);
            this.pnlProducto.TabIndex = 1;

            // 
            // lblProducto
            // 
            this.lblProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProducto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblProducto.Location = new System.Drawing.Point(0, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblProducto.Size = new System.Drawing.Size(700, 45);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ============================================
            // pnlFormulario
            // ============================================
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Controls.Add(this.lblTalla);
            this.pnlFormulario.Controls.Add(this.txtTalla);
            this.pnlFormulario.Controls.Add(this.lblColor);
            this.pnlFormulario.Controls.Add(this.txtColor);
            this.pnlFormulario.Controls.Add(this.btnAgregar);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 105);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(700, 85);
            this.pnlFormulario.TabIndex = 2;

            // 
            // lblTalla
            // 
            this.lblTalla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTalla.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblTalla.Location = new System.Drawing.Point(30, 30);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(60, 25);
            this.lblTalla.TabIndex = 0;
            this.lblTalla.Text = "Talla:";
            this.lblTalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTalla.Location = new System.Drawing.Point(90, 30);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(150, 27);
            this.txtTalla.TabIndex = 1;

            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblColor.Location = new System.Drawing.Point(270, 30);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 25);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtColor.Location = new System.Drawing.Point(330, 30);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(180, 27);
            this.txtColor.TabIndex = 3;

            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 205, 145);
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(530, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 32);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "➕ AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);

            // ============================================
            // pnlGrid
            // ============================================
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvExistentes);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 190);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlGrid.Size = new System.Drawing.Size(700, 250);
            this.pnlGrid.TabIndex = 3;

            // 
            // dgvExistentes
            // 
            this.dgvExistentes.AllowUserToAddRows = false;
            this.dgvExistentes.AllowUserToDeleteRows = false;
            this.dgvExistentes.AllowUserToResizeRows = false;
            this.dgvExistentes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExistentes.BackgroundColor = System.Drawing.Color.White;
            this.dgvExistentes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExistentes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExistentes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvExistentes.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvExistentes.ColumnHeadersHeight = 35;
            this.dgvExistentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvExistentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colTalla,
                this.colColor});
            this.dgvExistentes.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvExistentes.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvExistentes.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvExistentes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvExistentes.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvExistentes.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.dgvExistentes.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvExistentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExistentes.EnableHeadersVisualStyles = false;
            this.dgvExistentes.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvExistentes.Location = new System.Drawing.Point(20, 10);
            this.dgvExistentes.MultiSelect = false;
            this.dgvExistentes.Name = "dgvExistentes";
            this.dgvExistentes.ReadOnly = true;
            this.dgvExistentes.RowHeadersVisible = false;
            this.dgvExistentes.RowTemplate.Height = 32;
            this.dgvExistentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExistentes.Size = new System.Drawing.Size(660, 230);
            this.dgvExistentes.TabIndex = 0;

            // 
            // colId
            // 
            this.colId.FillWeight = 30F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;

            // 
            // colTalla
            // 
            this.colTalla.FillWeight = 80F;
            this.colTalla.HeaderText = "TALLA";
            this.colTalla.Name = "colTalla";
            this.colTalla.ReadOnly = true;

            // 
            // colColor
            // 
            this.colColor.HeaderText = "COLOR";
            this.colColor.Name = "colColor";
            this.colColor.ReadOnly = true;

            // ============================================
            // pnlBotones
            // ============================================
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 440);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(700, 60);
            this.pnlBotones.TabIndex = 4;

            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(570, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(110, 36);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "❌ CERRAR";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ============================================
            // FrmAgregarTallaColor
            // ============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAgregarTallaColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Talla y Color";
            // ⚠️ NO se registra Load aquí — no existe el método en el .cs.
            // Si lo necesitas, regístralo en el constructor del .cs:
            //   this.Load += FrmAgregarTallaColor_Load;
            this.pnlHeader.ResumeLayout(false);
            this.pnlProducto.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExistentes)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.TextBox txtTalla;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvExistentes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTalla;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColor;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCerrar;
    }
}
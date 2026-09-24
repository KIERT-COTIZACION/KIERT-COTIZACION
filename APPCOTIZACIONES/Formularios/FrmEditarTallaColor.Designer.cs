namespace COTIZACIONES.Formularios
{
    partial class FrmEditarTallaColor
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlProducto.SuspendLayout();
            this.pnlFormulario.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(550, 60);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(550, 60);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "✏️  EDITAR TALLA Y COLOR";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ============================================
            // pnlProducto
            // ============================================
            this.pnlProducto.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlProducto.Controls.Add(this.lblProducto);
            this.pnlProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProducto.Location = new System.Drawing.Point(0, 60);
            this.pnlProducto.Name = "pnlProducto";
            this.pnlProducto.Size = new System.Drawing.Size(550, 45);
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
            this.lblProducto.Size = new System.Drawing.Size(550, 45);
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
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFormulario.Location = new System.Drawing.Point(0, 105);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(550, 145);
            this.pnlFormulario.TabIndex = 2;

            // 
            // lblTalla
            // 
            this.lblTalla.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTalla.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblTalla.Location = new System.Drawing.Point(40, 25);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(60, 25);
            this.lblTalla.TabIndex = 0;
            this.lblTalla.Text = "Talla:";
            this.lblTalla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtTalla
            // 
            this.txtTalla.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTalla.Location = new System.Drawing.Point(100, 25);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(180, 27);
            this.txtTalla.TabIndex = 1;

            // 
            // lblColor
            // 
            this.lblColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblColor.Location = new System.Drawing.Point(40, 65);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(60, 25);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtColor.Location = new System.Drawing.Point(100, 65);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(400, 27);
            this.txtColor.TabIndex = 3;

            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 205, 145);
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(100, 105);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(180, 32);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "💾 GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);

            // ============================================
            // pnlBotones
            // ============================================
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnCancelar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 250);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(550, 60);
            this.pnlBotones.TabIndex = 3;

            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(420, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 36);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "❌ CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);

            // ============================================
            // FrmEditarTallaColor
            // ============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 310);
            this.Controls.Add(this.pnlFormulario);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlProducto);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditarTallaColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar Talla y Color";
            // ⚠️ NO pongas "this.Load += ..." aquí. Si necesitas Load, declara el método.
            this.pnlHeader.ResumeLayout(false);
            this.pnlProducto.ResumeLayout(false);
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnCancelar;
    }
}
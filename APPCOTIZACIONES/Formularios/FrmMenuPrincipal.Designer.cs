namespace COTIZACIONES.Formularios
{
    partial class FrmMenuPrincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.panelContenido = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnNuevaCotizacion = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.btnConfigEmpresa = new System.Windows.Forms.Button();
            this.btnTema = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelBotones.SuspendLayout();
            this.SuspendLayout();

            // ============================================
            // PANEL LATERAL (Barra decorativa izquierda)
            // ============================================
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(8, 620);
            this.panelLateral.TabIndex = 0;

            // ============================================
            // PANEL HEADER (Encabezado superior)
            // ============================================
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(8, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(892, 110);
            this.panelHeader.TabIndex = 1;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(30, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(500, 40);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA DE COTIZACIÓN";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblSubtitulo.Location = new System.Drawing.Point(32, 65);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(500, 25);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Gestión profesional de cotizaciones e inventario";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(560, 30);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(300, 25);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(220, 200, 200);
            this.lblRol.Location = new System.Drawing.Point(560, 60);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(300, 25);
            this.lblRol.TabIndex = 3;
            this.lblRol.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.panelHeader.Controls.Add(this.lblTitulo);
            this.panelHeader.Controls.Add(this.lblSubtitulo);
            this.panelHeader.Controls.Add(this.lblBienvenida);
            this.panelHeader.Controls.Add(this.lblRol);

            // ============================================
            // PANEL CONTENIDO
            // ============================================
            this.panelContenido.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.Location = new System.Drawing.Point(8, 110);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(892, 510);
            this.panelContenido.TabIndex = 2;

            // ============================================
            // PANEL BOTONES (Contenedor de botones)
            // ============================================
            this.panelBotones.BackColor = System.Drawing.Color.White;
            this.panelBotones.Location = new System.Drawing.Point(180, 60);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(540, 400);
            this.panelBotones.TabIndex = 0;

            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 75, 82);
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(40, 30);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(220, 70);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "👥  CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);

            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 75, 82);
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(280, 30);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(220, 70);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "📦  PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);

            // 
            // btnInventario
            // 
            this.btnInventario.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventario.FlatAppearance.BorderSize = 0;
            this.btnInventario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnInventario.ForeColor = System.Drawing.Color.White;
            this.btnInventario.Location = new System.Drawing.Point(40, 110);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(220, 70);
            this.btnInventario.TabIndex = 2;
            this.btnInventario.Text = "📊  INVENTARIO";
            this.btnInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventario.UseVisualStyleBackColor = false;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);

            // 
            // btnNuevaCotizacion
            // 
            this.btnNuevaCotizacion.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnNuevaCotizacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevaCotizacion.FlatAppearance.BorderSize = 0;
            this.btnNuevaCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 205, 145);
            this.btnNuevaCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaCotizacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNuevaCotizacion.ForeColor = System.Drawing.Color.White;
            this.btnNuevaCotizacion.Location = new System.Drawing.Point(280, 110);
            this.btnNuevaCotizacion.Name = "btnNuevaCotizacion";
            this.btnNuevaCotizacion.Size = new System.Drawing.Size(220, 70);
            this.btnNuevaCotizacion.TabIndex = 3;
            this.btnNuevaCotizacion.Text = "📄  NUEVA COTIZACIÓN";
            this.btnNuevaCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevaCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaCotizacion.UseVisualStyleBackColor = false;
            this.btnNuevaCotizacion.Click += new System.EventHandler(this.btnNuevaCotizacion_Click);

            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnHistorial.ForeColor = System.Drawing.Color.White;
            this.btnHistorial.Location = new System.Drawing.Point(40, 190);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(220, 70);
            this.btnHistorial.TabIndex = 4;
            this.btnHistorial.Text = "📋  HISTORIAL";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);

            // 
            // btnConfigEmpresa
            // 
            this.btnConfigEmpresa.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnConfigEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigEmpresa.FlatAppearance.BorderSize = 0;
            this.btnConfigEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 184, 179);
            this.btnConfigEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigEmpresa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfigEmpresa.ForeColor = System.Drawing.Color.White;
            this.btnConfigEmpresa.Location = new System.Drawing.Point(280, 190);
            this.btnConfigEmpresa.Name = "btnConfigEmpresa";
            this.btnConfigEmpresa.Size = new System.Drawing.Size(220, 70);
            this.btnConfigEmpresa.TabIndex = 5;
            this.btnConfigEmpresa.Text = "⚙️  CONFIG. EMPRESA";
            this.btnConfigEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfigEmpresa.UseVisualStyleBackColor = false;
            this.btnConfigEmpresa.Click += new System.EventHandler(this.btnConfigEmpresa_Click);

            // 
            // btnTema
            // 
            this.btnTema.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTema.FlatAppearance.BorderSize = 0;
            this.btnTema.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 184, 179);
            this.btnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTema.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTema.ForeColor = System.Drawing.Color.White;
            this.btnTema.Location = new System.Drawing.Point(40, 270);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(220, 70);
            this.btnTema.TabIndex = 6;
            this.btnTema.Text = "🎨  PERSONALIZAR";
            this.btnTema.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTema.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTema.UseVisualStyleBackColor = false;
            this.btnTema.Click += new System.EventHandler(this.btnTema_Click);

            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 55, 55);
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(280, 270);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(220, 70);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "🚪  SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);

            // Agregar botones al panel
            this.panelBotones.Controls.Add(this.btnClientes);
            this.panelBotones.Controls.Add(this.btnProductos);
            this.panelBotones.Controls.Add(this.btnInventario);
            this.panelBotones.Controls.Add(this.btnNuevaCotizacion);
            this.panelBotones.Controls.Add(this.btnHistorial);
            this.panelBotones.Controls.Add(this.btnConfigEmpresa);
            this.panelBotones.Controls.Add(this.btnTema);
            this.panelBotones.Controls.Add(this.btnSalir);

            // Agregar panelBotones al panelContenido
            this.panelContenido.Controls.Add(this.panelBotones);

            // ============================================
            // FrmMenuPrincipal
            // ============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal - Sistema de Cotización";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.panelLateral.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnNuevaCotizacion;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.Button btnConfigEmpresa;
        private System.Windows.Forms.Button btnTema;
        private System.Windows.Forms.Button btnSalir;
    }
}
namespace COTIZACIONES.Formularios
{
    partial class FrmInventario
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
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pnlStats = new System.Windows.Forms.Panel();
            this.lblTotalProductos = new System.Windows.Forms.Label();
            this.lblStockTotal = new System.Windows.Forms.Label();
            this.lblValorInventario = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTallas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colColores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizarStock = new System.Windows.Forms.Button();
            this.btnAgregarTallaColor = new System.Windows.Forms.Button();
            this.btnEditarTallaColor = new System.Windows.Forms.Button();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();

            this.pnlHeader.SuspendLayout();
            this.pnlBusqueda.SuspendLayout();
            this.pnlStats.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
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
            this.pnlHeader.Size = new System.Drawing.Size(1150, 65);
            this.pnlHeader.TabIndex = 0;

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(1150, 65);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "📦  INVENTARIO";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ============================================
            // pnlBusqueda
            // ============================================
            this.pnlBusqueda.BackColor = System.Drawing.Color.White;
            this.pnlBusqueda.Controls.Add(this.lblBuscar);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Controls.Add(this.btnActualizar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 65);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(1150, 60);
            this.pnlBusqueda.TabIndex = 1;

            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblBuscar.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblBuscar.Location = new System.Drawing.Point(20, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(87, 20);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "🔍 Buscar:";

            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtBuscar.Location = new System.Drawing.Point(110, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(450, 27);
            this.txtBuscar.TabIndex = 1;

            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 75, 82);
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(575, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "🔍 BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);

            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 184, 179);
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(705, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 30);
            this.btnActualizar.TabIndex = 3;
            this.btnActualizar.Text = "🔄 ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            // ============================================
            // pnlStats
            // ============================================
            this.pnlStats.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlStats.Controls.Add(this.lblTotalProductos);
            this.pnlStats.Controls.Add(this.lblStockTotal);
            this.pnlStats.Controls.Add(this.lblValorInventario);
            this.pnlStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStats.Location = new System.Drawing.Point(0, 125);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.Size = new System.Drawing.Size(1150, 55);
            this.pnlStats.TabIndex = 2;

            // 
            // lblTotalProductos
            // 
            this.lblTotalProductos.AutoSize = true;
            this.lblTotalProductos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotalProductos.ForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.lblTotalProductos.Location = new System.Drawing.Point(30, 18);
            this.lblTotalProductos.Name = "lblTotalProductos";
            this.lblTotalProductos.Size = new System.Drawing.Size(150, 20);
            this.lblTotalProductos.TabIndex = 0;
            this.lblTotalProductos.Text = "📦 Total Productos: 0";

            // 
            // lblStockTotal
            // 
            this.lblStockTotal.AutoSize = true;
            this.lblStockTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStockTotal.ForeColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.lblStockTotal.Location = new System.Drawing.Point(380, 18);
            this.lblStockTotal.Name = "lblStockTotal";
            this.lblStockTotal.Size = new System.Drawing.Size(190, 20);
            this.lblStockTotal.TabIndex = 1;
            this.lblStockTotal.Text = "📊 Stock Total: 0 unidades";

            // 
            // lblValorInventario
            // 
            this.lblValorInventario.AutoSize = true;
            this.lblValorInventario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblValorInventario.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblValorInventario.Location = new System.Drawing.Point(750, 18);
            this.lblValorInventario.Name = "lblValorInventario";
            this.lblValorInventario.Size = new System.Drawing.Size(200, 20);
            this.lblValorInventario.TabIndex = 2;
            this.lblValorInventario.Text = "💰 Valor Inventario: S/ 0.00";

            // ============================================
            // pnlGrid
            // ============================================
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvInventario);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 180);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.pnlGrid.Size = new System.Drawing.Size(1150, 375);
            this.pnlGrid.TabIndex = 3;

            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.White;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvInventario.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvInventario.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvInventario.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvInventario.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvInventario.ColumnHeadersDefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvInventario.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvInventario.ColumnHeadersHeight = 40;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colId,
                this.colCodigo,
                this.colProducto,
                this.colPrecio,
                this.colStock,
                this.colTallas,
                this.colColores});
            this.dgvInventario.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvInventario.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvInventario.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvInventario.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.dgvInventario.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.dgvInventario.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(255, 235, 235);
            this.dgvInventario.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.dgvInventario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.dgvInventario.Location = new System.Drawing.Point(20, 15);
            this.dgvInventario.MultiSelect = false;
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowTemplate.Height = 35;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(1110, 345);
            this.dgvInventario.TabIndex = 0;

            // 
            // colId
            // 
            this.colId.FillWeight = 35F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;

            // 
            // colCodigo
            // 
            this.colCodigo.FillWeight = 70F;
            this.colCodigo.HeaderText = "CÓDIGO";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;

            // 
            // colProducto
            // 
            this.colProducto.FillWeight = 200F;
            this.colProducto.HeaderText = "PRODUCTO";
            this.colProducto.Name = "colProducto";
            this.colProducto.ReadOnly = true;

            // 
            // colPrecio
            // 
            this.colPrecio.FillWeight = 80F;
            this.colPrecio.HeaderText = "PRECIO";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;

            // 
            // colStock
            // 
            this.colStock.FillWeight = 60F;
            this.colStock.HeaderText = "STOCK";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;

            // 
            // colTallas
            // 
            this.colTallas.FillWeight = 120F;
            this.colTallas.HeaderText = "TALLAS";
            this.colTallas.Name = "colTallas";
            this.colTallas.ReadOnly = true;

            // 
            // colColores
            // 
            this.colColores.FillWeight = 120F;
            this.colColores.HeaderText = "COLORES";
            this.colColores.Name = "colColores";
            this.colColores.ReadOnly = true;

            // ============================================
            // pnlBotones
            // ============================================
            this.pnlBotones.BackColor = System.Drawing.Color.White;
            this.pnlBotones.Controls.Add(this.btnNuevoProducto);
            this.pnlBotones.Controls.Add(this.btnEditarProducto);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnActualizarStock);
            this.pnlBotones.Controls.Add(this.btnAgregarTallaColor);
            this.pnlBotones.Controls.Add(this.btnEditarTallaColor);
            this.pnlBotones.Controls.Add(this.btnVerDetalle);
            this.pnlBotones.Controls.Add(this.btnCerrar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 555);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1150, 125);
            this.pnlBotones.TabIndex = 4;

            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 0;
            this.btnNuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 75, 82);
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btnNuevoProducto.Location = new System.Drawing.Point(20, 20);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(215, 40);
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.Text = "➕  NUEVO PRODUCTO";
            this.btnNuevoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);

            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnEditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarProducto.FlatAppearance.BorderSize = 0;
            this.btnEditarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 184, 179);
            this.btnEditarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProducto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEditarProducto.Location = new System.Drawing.Point(245, 20);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(215, 40);
            this.btnEditarProducto.TabIndex = 1;
            this.btnEditarProducto.Text = "✏️  EDITAR";
            this.btnEditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarProducto.UseVisualStyleBackColor = false;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);

            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(240, 55, 55);
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(470, 20);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(215, 40);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "🗑️  ELIMINAR";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            // 
            // btnActualizarStock
            // 
            this.btnActualizarStock.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnActualizarStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarStock.FlatAppearance.BorderSize = 0;
            this.btnActualizarStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnActualizarStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizarStock.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizarStock.ForeColor = System.Drawing.Color.White;
            this.btnActualizarStock.Location = new System.Drawing.Point(695, 20);
            this.btnActualizarStock.Name = "btnActualizarStock";
            this.btnActualizarStock.Size = new System.Drawing.Size(215, 40);
            this.btnActualizarStock.TabIndex = 3;
            this.btnActualizarStock.Text = "📊  ACTUALIZAR STOCK";
            this.btnActualizarStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarStock.UseVisualStyleBackColor = false;
            this.btnActualizarStock.Click += new System.EventHandler(this.btnActualizarStock_Click);

            // 
            // btnAgregarTallaColor
            // 
            this.btnAgregarTallaColor.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnAgregarTallaColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarTallaColor.FlatAppearance.BorderSize = 0;
            this.btnAgregarTallaColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(25, 205, 145);
            this.btnAgregarTallaColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTallaColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAgregarTallaColor.ForeColor = System.Drawing.Color.White;
            this.btnAgregarTallaColor.Location = new System.Drawing.Point(20, 70);
            this.btnAgregarTallaColor.Name = "btnAgregarTallaColor";
            this.btnAgregarTallaColor.Size = new System.Drawing.Size(250, 40);
            this.btnAgregarTallaColor.TabIndex = 4;
            this.btnAgregarTallaColor.Text = "➕  AGREGAR TALLA / COLOR";
            this.btnAgregarTallaColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarTallaColor.UseVisualStyleBackColor = false;
            this.btnAgregarTallaColor.Click += new System.EventHandler(this.btnAgregarTallaColor_Click);

            // 
            // btnEditarTallaColor
            // 
            this.btnEditarTallaColor.BackColor = System.Drawing.Color.FromArgb(105, 56, 62);
            this.btnEditarTallaColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarTallaColor.FlatAppearance.BorderSize = 0;
            this.btnEditarTallaColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(130, 75, 82);
            this.btnEditarTallaColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarTallaColor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditarTallaColor.ForeColor = System.Drawing.Color.White;
            this.btnEditarTallaColor.Location = new System.Drawing.Point(280, 70);
            this.btnEditarTallaColor.Name = "btnEditarTallaColor";
            this.btnEditarTallaColor.Size = new System.Drawing.Size(250, 40);
            this.btnEditarTallaColor.TabIndex = 5;
            this.btnEditarTallaColor.Text = "✏️  EDITAR TALLA / COLOR";
            this.btnEditarTallaColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarTallaColor.UseVisualStyleBackColor = false;
            this.btnEditarTallaColor.Click += new System.EventHandler(this.btnEditarTallaColor_Click);

            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.BackColor = System.Drawing.Color.FromArgb(166, 165, 160);
            this.btnVerDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(185, 184, 179);
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnVerDetalle.ForeColor = System.Drawing.Color.White;
            this.btnVerDetalle.Location = new System.Drawing.Point(540, 70);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(215, 40);
            this.btnVerDetalle.TabIndex = 6;
            this.btnVerDetalle.Text = "🔍  VER DETALLE";
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);

            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(93, 90, 85);
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(115, 112, 107);
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(765, 70);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(145, 40);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "❌  CERRAR";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);

            // ============================================
            // FrmInventario
            // ============================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.ClientSize = new System.Drawing.Size(1150, 680);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlBotones);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "FrmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario - Sistema de Cotización";
            // ⚠️ NO se registra Load aquí — el diseñador no lo necesita.
            // Si quieres un Load, regístralo en el constructor del .cs:
            //   this.Load += FrmInventario_Load;
            this.pnlHeader.ResumeLayout(false);
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Panel pnlStats;
        private System.Windows.Forms.Label lblTotalProductos;
        private System.Windows.Forms.Label lblStockTotal;
        private System.Windows.Forms.Label lblValorInventario;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTallas;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColores;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizarStock;
        private System.Windows.Forms.Button btnAgregarTallaColor;
        private System.Windows.Forms.Button btnEditarTallaColor;
        private System.Windows.Forms.Button btnVerDetalle;
        private System.Windows.Forms.Button btnCerrar;
    }
}
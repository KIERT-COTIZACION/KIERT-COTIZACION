namespace COTIZACIONES.Formularios
{
    partial class FrmConfigEmpresa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRuc = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.lblDir = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txtTel1 = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblInsta = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.TextBox();
            this.lblFace = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.TextBox();
            this.lblWeb = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.txtMoneda = new System.Windows.Forms.TextBox();
            this.lblIGV = new System.Windows.Forms.Label();
            this.numIGV = new System.Windows.Forms.NumericUpDown();
            this.lblValidez = new System.Windows.Forms.Label();
            this.numValidez = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtTiempoEntrega = new System.Windows.Forms.TextBox();
            this.gbLogo = new System.Windows.Forms.GroupBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnSubirLogo = new System.Windows.Forms.Button();
            this.lblLogoInfo = new System.Windows.Forms.Label();
            this.tabBancos = new System.Windows.Forms.TabPage();
            this.dgvBancos = new System.Windows.Forms.DataGridView();
            this.colBanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCCI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabNotas = new System.Windows.Forms.TabPage();
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValidez)).BeginInit();
            this.gbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabBancos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).BeginInit();
            this.tabNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabBancos);
            this.tabControl.Controls.Add(this.tabNotas);
            this.tabControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 520);
            this.tabControl.TabIndex = 0;
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tabGeneral.Controls.Add(this.lblNombre);
            this.tabGeneral.Controls.Add(this.txtNombre);
            this.tabGeneral.Controls.Add(this.lblRuc);
            this.tabGeneral.Controls.Add(this.txtRuc);
            this.tabGeneral.Controls.Add(this.lblDir);
            this.tabGeneral.Controls.Add(this.txtDireccion);
            this.tabGeneral.Controls.Add(this.lblTel1);
            this.tabGeneral.Controls.Add(this.txtTel1);
            this.tabGeneral.Controls.Add(this.lblTel2);
            this.tabGeneral.Controls.Add(this.txtTel2);
            this.tabGeneral.Controls.Add(this.lblEmail);
            this.tabGeneral.Controls.Add(this.txtEmail);
            this.tabGeneral.Controls.Add(this.lblInsta);
            this.tabGeneral.Controls.Add(this.txtInstagram);
            this.tabGeneral.Controls.Add(this.lblFace);
            this.tabGeneral.Controls.Add(this.txtFacebook);
            this.tabGeneral.Controls.Add(this.lblWeb);
            this.tabGeneral.Controls.Add(this.txtWeb);
            this.tabGeneral.Controls.Add(this.lblMoneda);
            this.tabGeneral.Controls.Add(this.txtMoneda);
            this.tabGeneral.Controls.Add(this.lblIGV);
            this.tabGeneral.Controls.Add(this.numIGV);
            this.tabGeneral.Controls.Add(this.lblValidez);
            this.tabGeneral.Controls.Add(this.numValidez);
            this.tabGeneral.Controls.Add(this.lblTiempo);
            this.tabGeneral.Controls.Add(this.txtTiempoEntrega);
            this.tabGeneral.Controls.Add(this.gbLogo);
            this.tabGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(752, 492);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "Datos Generales";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblNombre.Location = new System.Drawing.Point(20, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(130, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Empresa: *";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(155, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(320, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblRuc
            // 
            this.lblRuc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblRuc.Location = new System.Drawing.Point(20, 58);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(130, 20);
            this.lblRuc.TabIndex = 2;
            this.lblRuc.Text = "RUC:";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(155, 55);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(320, 23);
            this.txtRuc.TabIndex = 3;
            // 
            // lblDir
            // 
            this.lblDir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblDir.Location = new System.Drawing.Point(20, 93);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(130, 20);
            this.lblDir.TabIndex = 4;
            this.lblDir.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(155, 90);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(320, 23);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblTel1
            // 
            this.lblTel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblTel1.Location = new System.Drawing.Point(20, 128);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(130, 20);
            this.lblTel1.TabIndex = 6;
            this.lblTel1.Text = "Teléfono 1:";
            // 
            // txtTel1
            // 
            this.txtTel1.Location = new System.Drawing.Point(155, 125);
            this.txtTel1.Name = "txtTel1";
            this.txtTel1.Size = new System.Drawing.Size(150, 23);
            this.txtTel1.TabIndex = 7;
            // 
            // lblTel2
            // 
            this.lblTel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblTel2.Location = new System.Drawing.Point(320, 128);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(80, 20);
            this.lblTel2.TabIndex = 8;
            this.lblTel2.Text = "Teléfono 2:";
            // 
            // txtTel2
            // 
            this.txtTel2.Location = new System.Drawing.Point(400, 125);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(75, 23);
            this.txtTel2.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblEmail.Location = new System.Drawing.Point(20, 163);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(130, 20);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 23);
            this.txtEmail.TabIndex = 11;
            // 
            // lblInsta
            // 
            this.lblInsta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInsta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblInsta.Location = new System.Drawing.Point(20, 198);
            this.lblInsta.Name = "lblInsta";
            this.lblInsta.Size = new System.Drawing.Size(130, 20);
            this.lblInsta.TabIndex = 12;
            this.lblInsta.Text = "Instagram:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(155, 195);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(150, 23);
            this.txtInstagram.TabIndex = 13;
            // 
            // lblFace
            // 
            this.lblFace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblFace.Location = new System.Drawing.Point(320, 198);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(80, 20);
            this.lblFace.TabIndex = 14;
            this.lblFace.Text = "Facebook:";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(400, 195);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(75, 23);
            this.txtFacebook.TabIndex = 15;
            // 
            // lblWeb
            // 
            this.lblWeb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblWeb.Location = new System.Drawing.Point(20, 233);
            this.lblWeb.Name = "lblWeb";
            this.lblWeb.Size = new System.Drawing.Size(130, 20);
            this.lblWeb.TabIndex = 16;
            this.lblWeb.Text = "Sitio Web:";
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(155, 230);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(150, 23);
            this.txtWeb.TabIndex = 17;
            // 
            // lblMoneda
            // 
            this.lblMoneda.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMoneda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblMoneda.Location = new System.Drawing.Point(320, 233);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(80, 20);
            this.lblMoneda.TabIndex = 18;
            this.lblMoneda.Text = "Moneda:";
            // 
            // txtMoneda
            // 
            this.txtMoneda.Location = new System.Drawing.Point(400, 230);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.Size = new System.Drawing.Size(75, 23);
            this.txtMoneda.TabIndex = 19;
            // 
            // lblIGV
            // 
            this.lblIGV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblIGV.Location = new System.Drawing.Point(20, 303);
            this.lblIGV.Name = "lblIGV";
            this.lblIGV.Size = new System.Drawing.Size(130, 20);
            this.lblIGV.TabIndex = 22;
            this.lblIGV.Text = "IGV (%):";
            // 
            // numIGV
            // 
            this.numIGV.DecimalPlaces = 2;
            this.numIGV.Location = new System.Drawing.Point(155, 300);
            this.numIGV.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numIGV.Name = "numIGV";
            this.numIGV.Size = new System.Drawing.Size(80, 23);
            this.numIGV.TabIndex = 23;
            this.numIGV.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // lblValidez
            // 
            this.lblValidez.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblValidez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblValidez.Location = new System.Drawing.Point(260, 303);
            this.lblValidez.Name = "lblValidez";
            this.lblValidez.Size = new System.Drawing.Size(100, 20);
            this.lblValidez.TabIndex = 24;
            this.lblValidez.Text = "Validez (días):";
            // 
            // numValidez
            // 
            this.numValidez.Location = new System.Drawing.Point(365, 300);
            this.numValidez.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.numValidez.Name = "numValidez";
            this.numValidez.Size = new System.Drawing.Size(80, 23);
            this.numValidez.TabIndex = 25;
            this.numValidez.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // lblTiempo
            // 
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblTiempo.Location = new System.Drawing.Point(20, 268);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(130, 20);
            this.lblTiempo.TabIndex = 20;
            this.lblTiempo.Text = "Tiempo Entrega:";
            // 
            // txtTiempoEntrega
            // 
            this.txtTiempoEntrega.Location = new System.Drawing.Point(155, 265);
            this.txtTiempoEntrega.Name = "txtTiempoEntrega";
            this.txtTiempoEntrega.Size = new System.Drawing.Size(150, 23);
            this.txtTiempoEntrega.TabIndex = 21;
            // 
            // gbLogo
            // 
            this.gbLogo.Controls.Add(this.picLogo);
            this.gbLogo.Controls.Add(this.btnSubirLogo);
            this.gbLogo.Controls.Add(this.lblLogoInfo);
            this.gbLogo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.gbLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.gbLogo.Location = new System.Drawing.Point(500, 20);
            this.gbLogo.Name = "gbLogo";
            this.gbLogo.Size = new System.Drawing.Size(230, 250);
            this.gbLogo.TabIndex = 26;
            this.gbLogo.TabStop = false;
            this.gbLogo.Text = "Logo de la Empresa";
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Location = new System.Drawing.Point(15, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(200, 150);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // btnSubirLogo
            // 
            this.btnSubirLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.btnSubirLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubirLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnSubirLogo.Location = new System.Drawing.Point(15, 185);
            this.btnSubirLogo.Name = "btnSubirLogo";
            this.btnSubirLogo.Size = new System.Drawing.Size(200, 32);
            this.btnSubirLogo.TabIndex = 1;
            this.btnSubirLogo.Text = "📁 SUBIR LOGO";
            this.btnSubirLogo.UseVisualStyleBackColor = false;
            this.btnSubirLogo.Click += new System.EventHandler(this.btnSubirLogo_Click);
            // 
            // lblLogoInfo
            // 
            this.lblLogoInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblLogoInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.lblLogoInfo.Location = new System.Drawing.Point(15, 220);
            this.lblLogoInfo.Name = "lblLogoInfo";
            this.lblLogoInfo.Size = new System.Drawing.Size(200, 20);
            this.lblLogoInfo.TabIndex = 2;
            this.lblLogoInfo.Text = "Sin logo";
            // 
            // tabBancos
            // 
            this.tabBancos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tabBancos.Controls.Add(this.dgvBancos);
            this.tabBancos.Location = new System.Drawing.Point(4, 24);
            this.tabBancos.Name = "tabBancos";
            this.tabBancos.Padding = new System.Windows.Forms.Padding(3);
            this.tabBancos.Size = new System.Drawing.Size(752, 492);
            this.tabBancos.TabIndex = 1;
            this.tabBancos.Text = "Cuentas Bancarias";
            // 
            // dgvBancos
            // 
            this.dgvBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBancos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBancos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBanco,
            this.colCuenta,
            this.colCCI});
            this.dgvBancos.Location = new System.Drawing.Point(20, 20);
            this.dgvBancos.Name = "dgvBancos";
            this.dgvBancos.Size = new System.Drawing.Size(710, 400);
            this.dgvBancos.TabIndex = 0;
            // 
            // colBanco
            // 
            this.colBanco.HeaderText = "Banco";
            this.colBanco.Name = "colBanco";
            // 
            // colCuenta
            // 
            this.colCuenta.HeaderText = "N° Cuenta";
            this.colCuenta.Name = "colCuenta";
            // 
            // colCCI
            // 
            this.colCCI.HeaderText = "CCI";
            this.colCCI.Name = "colCCI";
            // 
            // tabNotas
            // 
            this.tabNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.tabNotas.Controls.Add(this.txtNotas);
            this.tabNotas.Location = new System.Drawing.Point(4, 24);
            this.tabNotas.Name = "tabNotas";
            this.tabNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotas.Size = new System.Drawing.Size(752, 492);
            this.tabNotas.TabIndex = 2;
            this.tabNotas.Text = "Notas / Condiciones";
            // 
            // txtNotas
            // 
            this.txtNotas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNotas.Location = new System.Drawing.Point(20, 20);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotas.Size = new System.Drawing.Size(710, 450);
            this.txtNotas.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(430, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(220, 40);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "💾 GUARDAR CONFIGURACIÓN";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(90)))), ((int)(((byte)(85)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btnCerrar.Location = new System.Drawing.Point(660, 545);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(112, 40);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmConfigEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(784, 600);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConfigEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración de la Empresa";
            this.Load += new System.EventHandler(this.FrmConfigEmpresa_Load);
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValidez)).EndInit();
            this.gbLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabBancos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBancos)).EndInit();
            this.tabNotas.ResumeLayout(false);
            this.tabNotas.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabBancos;
        private System.Windows.Forms.TabPage tabNotas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.TextBox txtTel1;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblInsta;
        private System.Windows.Forms.TextBox txtInstagram;
        private System.Windows.Forms.Label lblFace;
        private System.Windows.Forms.TextBox txtFacebook;
        private System.Windows.Forms.Label lblWeb;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.TextBox txtMoneda;
        private System.Windows.Forms.Label lblIGV;
        private System.Windows.Forms.NumericUpDown numIGV;
        private System.Windows.Forms.Label lblValidez;
        private System.Windows.Forms.NumericUpDown numValidez;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempoEntrega;
        private System.Windows.Forms.GroupBox gbLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnSubirLogo;
        private System.Windows.Forms.Label lblLogoInfo;
        private System.Windows.Forms.DataGridView dgvBancos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCCI;
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCerrar;
    }
}
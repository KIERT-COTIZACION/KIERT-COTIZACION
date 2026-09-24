namespace COTIZACIONES.Formularios
{
    partial class FrmSelectorTema
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblPaleta = new System.Windows.Forms.Label();
            this.cmbPaletas = new System.Windows.Forms.ComboBox();
            this.lblSep1 = new System.Windows.Forms.Label();
            this.lblPrimario = new System.Windows.Forms.Label();
            this.picPrimario = new System.Windows.Forms.PictureBox();
            this.txtPrimario = new System.Windows.Forms.TextBox();
            this.btnPickPrimario = new System.Windows.Forms.Button();
            this.lblContrastePrimario = new System.Windows.Forms.Label();
            this.pnlPreviewPrimario = new System.Windows.Forms.Panel();
            this.lblSecundario = new System.Windows.Forms.Label();
            this.picSecundario = new System.Windows.Forms.PictureBox();
            this.txtSecundario = new System.Windows.Forms.TextBox();
            this.btnPickSecundario = new System.Windows.Forms.Button();
            this.lblContrasteSecundario = new System.Windows.Forms.Label();
            this.pnlPreviewSecundario = new System.Windows.Forms.Panel();
            this.lblTerciario = new System.Windows.Forms.Label();
            this.picTerciario = new System.Windows.Forms.PictureBox();
            this.txtTerciario = new System.Windows.Forms.TextBox();
            this.btnPickTerciario = new System.Windows.Forms.Button();
            this.lblContrasteTerciario = new System.Windows.Forms.Label();
            this.pnlPreviewTerciario = new System.Windows.Forms.Panel();
            this.lblFondo = new System.Windows.Forms.Label();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.txtFondo = new System.Windows.Forms.TextBox();
            this.btnPickFondo = new System.Windows.Forms.Button();
            this.lblContrasteFondo = new System.Windows.Forms.Label();
            this.pnlPreviewFondo = new System.Windows.Forms.Panel();
            this.lblSepPdf = new System.Windows.Forms.Label();
            this.lblColorPdf = new System.Windows.Forms.Label();
            this.picPdf = new System.Windows.Forms.PictureBox();
            this.txtPdf = new System.Windows.Forms.TextBox();
            this.btnPickPdf = new System.Windows.Forms.Button();
            this.pnlPreviewPdf = new System.Windows.Forms.Panel();
            this.lblContrastePdf = new System.Windows.Forms.Label();
            this.lblPdfInfo = new System.Windows.Forms.Label();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPrimario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecundario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTerciario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(0, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(700, 55);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "🎨 PERSONALIZAR COLORES DEL SISTEMA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblSubtitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitulo.Location = new System.Drawing.Point(20, 65);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(660, 20);
            this.lblSubtitulo.TabIndex = 1;
            this.lblSubtitulo.Text = "Los colores de texto se ajustan automáticamente para mejor legibilidad.";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPaleta
            // 
            this.lblPaleta.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaleta.Location = new System.Drawing.Point(20, 95);
            this.lblPaleta.Name = "lblPaleta";
            this.lblPaleta.Size = new System.Drawing.Size(200, 25);
            this.lblPaleta.TabIndex = 2;
            this.lblPaleta.Text = "Paletas predefinidas:";
            // 
            // cmbPaletas
            // 
            this.cmbPaletas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaletas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPaletas.Location = new System.Drawing.Point(230, 93);
            this.cmbPaletas.Name = "cmbPaletas";
            this.cmbPaletas.Size = new System.Drawing.Size(450, 25);
            this.cmbPaletas.TabIndex = 3;
            this.cmbPaletas.SelectedIndexChanged += new System.EventHandler(this.cmbPaletas_SelectedIndexChanged);
            // 
            // lblSep1
            // 
            this.lblSep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSep1.Location = new System.Drawing.Point(20, 130);
            this.lblSep1.Name = "lblSep1";
            this.lblSep1.Size = new System.Drawing.Size(660, 2);
            this.lblSep1.TabIndex = 4;
            // 
            // lblPrimario
            // 
            this.lblPrimario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPrimario.Location = new System.Drawing.Point(20, 148);
            this.lblPrimario.Name = "lblPrimario";
            this.lblPrimario.Size = new System.Drawing.Size(150, 25);
            this.lblPrimario.TabIndex = 5;
            this.lblPrimario.Text = "Color Primario:";
            // 
            // picPrimario
            // 
            this.picPrimario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPrimario.Location = new System.Drawing.Point(180, 145);
            this.picPrimario.Name = "picPrimario";
            this.picPrimario.Size = new System.Drawing.Size(50, 28);
            this.picPrimario.TabIndex = 6;
            this.picPrimario.TabStop = false;
            // 
            // txtPrimario
            // 
            this.txtPrimario.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtPrimario.Location = new System.Drawing.Point(240, 148);
            this.txtPrimario.Name = "txtPrimario";
            this.txtPrimario.ReadOnly = true;
            this.txtPrimario.Size = new System.Drawing.Size(100, 23);
            this.txtPrimario.TabIndex = 7;
            // 
            // btnPickPrimario
            // 
            this.btnPickPrimario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickPrimario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickPrimario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickPrimario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickPrimario.ForeColor = System.Drawing.Color.White;
            this.btnPickPrimario.Location = new System.Drawing.Point(350, 145);
            this.btnPickPrimario.Name = "btnPickPrimario";
            this.btnPickPrimario.Size = new System.Drawing.Size(100, 30);
            this.btnPickPrimario.TabIndex = 8;
            this.btnPickPrimario.Text = "Elegir...";
            this.btnPickPrimario.UseVisualStyleBackColor = false;
            this.btnPickPrimario.Click += new System.EventHandler(this.btnPickPrimario_Click);
            // 
            // lblContrastePrimario
            // 
            this.lblContrastePrimario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblContrastePrimario.ForeColor = System.Drawing.Color.Gray;
            this.lblContrastePrimario.Location = new System.Drawing.Point(460, 174);
            this.lblContrastePrimario.Name = "lblContrastePrimario";
            this.lblContrastePrimario.Size = new System.Drawing.Size(160, 16);
            this.lblContrastePrimario.TabIndex = 10;
            this.lblContrastePrimario.Text = "Texto: BLANCO";
            // 
            // pnlPreviewPrimario
            // 
            this.pnlPreviewPrimario.Location = new System.Drawing.Point(460, 145);
            this.pnlPreviewPrimario.Name = "pnlPreviewPrimario";
            this.pnlPreviewPrimario.Size = new System.Drawing.Size(160, 28);
            this.pnlPreviewPrimario.TabIndex = 9;
            // 
            // lblSecundario
            // 
            this.lblSecundario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSecundario.Location = new System.Drawing.Point(20, 200);
            this.lblSecundario.Name = "lblSecundario";
            this.lblSecundario.Size = new System.Drawing.Size(150, 25);
            this.lblSecundario.TabIndex = 11;
            this.lblSecundario.Text = "Color Secundario:";
            // 
            // picSecundario
            // 
            this.picSecundario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSecundario.Location = new System.Drawing.Point(180, 197);
            this.picSecundario.Name = "picSecundario";
            this.picSecundario.Size = new System.Drawing.Size(50, 28);
            this.picSecundario.TabIndex = 12;
            this.picSecundario.TabStop = false;
            // 
            // txtSecundario
            // 
            this.txtSecundario.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtSecundario.Location = new System.Drawing.Point(240, 200);
            this.txtSecundario.Name = "txtSecundario";
            this.txtSecundario.ReadOnly = true;
            this.txtSecundario.Size = new System.Drawing.Size(100, 23);
            this.txtSecundario.TabIndex = 13;
            // 
            // btnPickSecundario
            // 
            this.btnPickSecundario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickSecundario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickSecundario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickSecundario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickSecundario.ForeColor = System.Drawing.Color.White;
            this.btnPickSecundario.Location = new System.Drawing.Point(350, 197);
            this.btnPickSecundario.Name = "btnPickSecundario";
            this.btnPickSecundario.Size = new System.Drawing.Size(100, 30);
            this.btnPickSecundario.TabIndex = 14;
            this.btnPickSecundario.Text = "Elegir...";
            this.btnPickSecundario.UseVisualStyleBackColor = false;
            this.btnPickSecundario.Click += new System.EventHandler(this.btnPickSecundario_Click);
            // 
            // lblContrasteSecundario
            // 
            this.lblContrasteSecundario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblContrasteSecundario.ForeColor = System.Drawing.Color.Gray;
            this.lblContrasteSecundario.Location = new System.Drawing.Point(460, 226);
            this.lblContrasteSecundario.Name = "lblContrasteSecundario";
            this.lblContrasteSecundario.Size = new System.Drawing.Size(160, 16);
            this.lblContrasteSecundario.TabIndex = 16;
            this.lblContrasteSecundario.Text = "Texto: NEGRO";
            // 
            // pnlPreviewSecundario
            // 
            this.pnlPreviewSecundario.Location = new System.Drawing.Point(460, 197);
            this.pnlPreviewSecundario.Name = "pnlPreviewSecundario";
            this.pnlPreviewSecundario.Size = new System.Drawing.Size(160, 28);
            this.pnlPreviewSecundario.TabIndex = 15;
            // 
            // lblTerciario
            // 
            this.lblTerciario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTerciario.Location = new System.Drawing.Point(20, 252);
            this.lblTerciario.Name = "lblTerciario";
            this.lblTerciario.Size = new System.Drawing.Size(150, 25);
            this.lblTerciario.TabIndex = 17;
            this.lblTerciario.Text = "Color Terciario:";
            // 
            // picTerciario
            // 
            this.picTerciario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picTerciario.Location = new System.Drawing.Point(180, 249);
            this.picTerciario.Name = "picTerciario";
            this.picTerciario.Size = new System.Drawing.Size(50, 28);
            this.picTerciario.TabIndex = 18;
            this.picTerciario.TabStop = false;
            // 
            // txtTerciario
            // 
            this.txtTerciario.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtTerciario.Location = new System.Drawing.Point(240, 252);
            this.txtTerciario.Name = "txtTerciario";
            this.txtTerciario.ReadOnly = true;
            this.txtTerciario.Size = new System.Drawing.Size(100, 23);
            this.txtTerciario.TabIndex = 19;
            // 
            // btnPickTerciario
            // 
            this.btnPickTerciario.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickTerciario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickTerciario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickTerciario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickTerciario.ForeColor = System.Drawing.Color.White;
            this.btnPickTerciario.Location = new System.Drawing.Point(350, 249);
            this.btnPickTerciario.Name = "btnPickTerciario";
            this.btnPickTerciario.Size = new System.Drawing.Size(100, 30);
            this.btnPickTerciario.TabIndex = 20;
            this.btnPickTerciario.Text = "Elegir...";
            this.btnPickTerciario.UseVisualStyleBackColor = false;
            this.btnPickTerciario.Click += new System.EventHandler(this.btnPickTerciario_Click);
            // 
            // lblContrasteTerciario
            // 
            this.lblContrasteTerciario.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblContrasteTerciario.ForeColor = System.Drawing.Color.Gray;
            this.lblContrasteTerciario.Location = new System.Drawing.Point(460, 278);
            this.lblContrasteTerciario.Name = "lblContrasteTerciario";
            this.lblContrasteTerciario.Size = new System.Drawing.Size(160, 16);
            this.lblContrasteTerciario.TabIndex = 22;
            this.lblContrasteTerciario.Text = "Texto: BLANCO";
            // 
            // pnlPreviewTerciario
            // 
            this.pnlPreviewTerciario.Location = new System.Drawing.Point(460, 249);
            this.pnlPreviewTerciario.Name = "pnlPreviewTerciario";
            this.pnlPreviewTerciario.Size = new System.Drawing.Size(160, 28);
            this.pnlPreviewTerciario.TabIndex = 21;
            // 
            // lblFondo
            // 
            this.lblFondo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFondo.Location = new System.Drawing.Point(20, 304);
            this.lblFondo.Name = "lblFondo";
            this.lblFondo.Size = new System.Drawing.Size(150, 25);
            this.lblFondo.TabIndex = 23;
            this.lblFondo.Text = "Color Fondo:";
            // 
            // picFondo
            // 
            this.picFondo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFondo.Location = new System.Drawing.Point(180, 301);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(50, 28);
            this.picFondo.TabIndex = 24;
            this.picFondo.TabStop = false;
            // 
            // txtFondo
            // 
            this.txtFondo.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtFondo.Location = new System.Drawing.Point(240, 304);
            this.txtFondo.Name = "txtFondo";
            this.txtFondo.ReadOnly = true;
            this.txtFondo.Size = new System.Drawing.Size(100, 23);
            this.txtFondo.TabIndex = 25;
            // 
            // btnPickFondo
            // 
            this.btnPickFondo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickFondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickFondo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickFondo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickFondo.ForeColor = System.Drawing.Color.White;
            this.btnPickFondo.Location = new System.Drawing.Point(350, 301);
            this.btnPickFondo.Name = "btnPickFondo";
            this.btnPickFondo.Size = new System.Drawing.Size(100, 30);
            this.btnPickFondo.TabIndex = 26;
            this.btnPickFondo.Text = "Elegir...";
            this.btnPickFondo.UseVisualStyleBackColor = false;
            this.btnPickFondo.Click += new System.EventHandler(this.btnPickFondo_Click);
            // 
            // lblContrasteFondo
            // 
            this.lblContrasteFondo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblContrasteFondo.ForeColor = System.Drawing.Color.Gray;
            this.lblContrasteFondo.Location = new System.Drawing.Point(460, 330);
            this.lblContrasteFondo.Name = "lblContrasteFondo";
            this.lblContrasteFondo.Size = new System.Drawing.Size(160, 16);
            this.lblContrasteFondo.TabIndex = 28;
            this.lblContrasteFondo.Text = "Texto: NEGRO";
            // 
            // pnlPreviewFondo
            // 
            this.pnlPreviewFondo.Location = new System.Drawing.Point(460, 301);
            this.pnlPreviewFondo.Name = "pnlPreviewFondo";
            this.pnlPreviewFondo.Size = new System.Drawing.Size(160, 28);
            this.pnlPreviewFondo.TabIndex = 27;
            // 
            // lblSepPdf
            // 
            this.lblSepPdf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSepPdf.Location = new System.Drawing.Point(20, 355);
            this.lblSepPdf.Name = "lblSepPdf";
            this.lblSepPdf.Size = new System.Drawing.Size(660, 2);
            this.lblSepPdf.TabIndex = 29;
            // 
            // lblColorPdf
            // 
            this.lblColorPdf.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblColorPdf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.lblColorPdf.Location = new System.Drawing.Point(20, 370);
            this.lblColorPdf.Name = "lblColorPdf";
            this.lblColorPdf.Size = new System.Drawing.Size(150, 25);
            this.lblColorPdf.TabIndex = 30;
            this.lblColorPdf.Text = "🎨 Color del PDF:";
            // 
            // picPdf
            // 
            this.picPdf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPdf.Location = new System.Drawing.Point(180, 367);
            this.picPdf.Name = "picPdf";
            this.picPdf.Size = new System.Drawing.Size(50, 28);
            this.picPdf.TabIndex = 31;
            this.picPdf.TabStop = false;
            // 
            // txtPdf
            // 
            this.txtPdf.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtPdf.Location = new System.Drawing.Point(240, 370);
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.ReadOnly = true;
            this.txtPdf.Size = new System.Drawing.Size(100, 23);
            this.txtPdf.TabIndex = 32;
            // 
            // btnPickPdf
            // 
            this.btnPickPdf.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPickPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPickPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickPdf.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPickPdf.ForeColor = System.Drawing.Color.White;
            this.btnPickPdf.Location = new System.Drawing.Point(350, 367);
            this.btnPickPdf.Name = "btnPickPdf";
            this.btnPickPdf.Size = new System.Drawing.Size(100, 30);
            this.btnPickPdf.TabIndex = 33;
            this.btnPickPdf.Text = "Elegir...";
            this.btnPickPdf.UseVisualStyleBackColor = false;
            this.btnPickPdf.Click += new System.EventHandler(this.btnPickPdf_Click);
            // 
            // pnlPreviewPdf
            // 
            this.pnlPreviewPdf.Location = new System.Drawing.Point(460, 367);
            this.pnlPreviewPdf.Name = "pnlPreviewPdf";
            this.pnlPreviewPdf.Size = new System.Drawing.Size(160, 28);
            this.pnlPreviewPdf.TabIndex = 34;
            // 
            // lblContrastePdf
            // 
            this.lblContrastePdf.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblContrastePdf.ForeColor = System.Drawing.Color.Gray;
            this.lblContrastePdf.Location = new System.Drawing.Point(460, 396);
            this.lblContrastePdf.Name = "lblContrastePdf";
            this.lblContrastePdf.Size = new System.Drawing.Size(160, 16);
            this.lblContrastePdf.TabIndex = 35;
            this.lblContrastePdf.Text = "Texto: BLANCO";
            // 
            // lblPdfInfo
            // 
            this.lblPdfInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblPdfInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblPdfInfo.Location = new System.Drawing.Point(20, 400);
            this.lblPdfInfo.Name = "lblPdfInfo";
            this.lblPdfInfo.Size = new System.Drawing.Size(430, 20);
            this.lblPdfInfo.TabIndex = 36;
            this.lblPdfInfo.Text = "Este color se usa en los encabezados, cuadros y totales del PDF.";
            // 
            // btnAplicar
            // 
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.ForeColor = System.Drawing.Color.White;
            this.btnAplicar.Location = new System.Drawing.Point(360, 440);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(160, 40);
            this.btnAplicar.TabIndex = 37;
            this.btnAplicar.Text = "✓ APLICAR";
            this.btnAplicar.UseVisualStyleBackColor = false;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestaurar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRestaurar.ForeColor = System.Drawing.Color.White;
            this.btnRestaurar.Location = new System.Drawing.Point(180, 440);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(160, 40);
            this.btnRestaurar.TabIndex = 38;
            this.btnRestaurar.Text = "🔄 RESTAURAR";
            this.btnRestaurar.UseVisualStyleBackColor = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(540, 440);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(140, 40);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.Text = "✖ CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmSelectorTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblPaleta);
            this.Controls.Add(this.cmbPaletas);
            this.Controls.Add(this.lblSep1);
            this.Controls.Add(this.lblPrimario);
            this.Controls.Add(this.picPrimario);
            this.Controls.Add(this.txtPrimario);
            this.Controls.Add(this.btnPickPrimario);
            this.Controls.Add(this.pnlPreviewPrimario);
            this.Controls.Add(this.lblContrastePrimario);
            this.Controls.Add(this.lblSecundario);
            this.Controls.Add(this.picSecundario);
            this.Controls.Add(this.txtSecundario);
            this.Controls.Add(this.btnPickSecundario);
            this.Controls.Add(this.pnlPreviewSecundario);
            this.Controls.Add(this.lblContrasteSecundario);
            this.Controls.Add(this.lblTerciario);
            this.Controls.Add(this.picTerciario);
            this.Controls.Add(this.txtTerciario);
            this.Controls.Add(this.btnPickTerciario);
            this.Controls.Add(this.pnlPreviewTerciario);
            this.Controls.Add(this.lblContrasteTerciario);
            this.Controls.Add(this.lblFondo);
            this.Controls.Add(this.picFondo);
            this.Controls.Add(this.txtFondo);
            this.Controls.Add(this.btnPickFondo);
            this.Controls.Add(this.pnlPreviewFondo);
            this.Controls.Add(this.lblContrasteFondo);
            this.Controls.Add(this.lblSepPdf);
            this.Controls.Add(this.lblColorPdf);
            this.Controls.Add(this.picPdf);
            this.Controls.Add(this.txtPdf);
            this.Controls.Add(this.btnPickPdf);
            this.Controls.Add(this.pnlPreviewPdf);
            this.Controls.Add(this.lblContrastePdf);
            this.Controls.Add(this.lblPdfInfo);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectorTema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personalizar Colores del Sistema";
            ((System.ComponentModel.ISupportInitialize)(this.picPrimario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecundario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTerciario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPdf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblTitulo, lblSubtitulo, lblPaleta, lblSep1;
        private System.Windows.Forms.ComboBox cmbPaletas;
        private System.Windows.Forms.Label lblPrimario, lblSecundario, lblTerciario, lblFondo;
        private System.Windows.Forms.PictureBox picPrimario, picSecundario, picTerciario, picFondo;
        private System.Windows.Forms.TextBox txtPrimario, txtSecundario, txtTerciario, txtFondo;
        private System.Windows.Forms.Button btnPickPrimario, btnPickSecundario, btnPickTerciario, btnPickFondo;
        private System.Windows.Forms.Label lblContrastePrimario, lblContrasteSecundario,
            lblContrasteTerciario, lblContrasteFondo;
        private System.Windows.Forms.Panel pnlPreviewPrimario, pnlPreviewSecundario,
            pnlPreviewTerciario, pnlPreviewFondo;
        private System.Windows.Forms.Label lblSepPdf, lblColorPdf, lblPdfInfo;
        private System.Windows.Forms.PictureBox picPdf;
        private System.Windows.Forms.TextBox txtPdf;
        private System.Windows.Forms.Button btnPickPdf;
        private System.Windows.Forms.Panel pnlPreviewPdf;
        private System.Windows.Forms.Label lblContrastePdf;
        private System.Windows.Forms.Button btnAplicar, btnRestaurar, btnCancelar;
    }
}
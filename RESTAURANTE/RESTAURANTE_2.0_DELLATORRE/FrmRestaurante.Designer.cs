namespace RESTAURANTE_2._0_DELLATORRE
{
    partial class FrmRestaurante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeClient = new System.Windows.Forms.TextBox();
            this.lblNomeClient = new System.Windows.Forms.Label();
            this.lblNascClient = new System.Windows.Forms.Label();
            this.DtpClient = new System.Windows.Forms.DateTimePicker();
            this.lblAniversario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CboAlmoco = new System.Windows.Forms.CheckBox();
            this.CboBebidas = new System.Windows.Forms.CheckBox();
            this.GpbAlmoco = new System.Windows.Forms.GroupBox();
            this.lblOnde = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GpbBebidas = new System.Windows.Forms.GroupBox();
            this.lbl67 = new System.Windows.Forms.Label();
            this.CboSuco = new System.Windows.Forms.CheckBox();
            this.CboRefrig = new System.Windows.Forms.CheckBox();
            this.CboCerveja = new System.Windows.Forms.CheckBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.NumAlmoco = new System.Windows.Forms.NumericUpDown();
            this.NumRefrigerante = new System.Windows.Forms.NumericUpDown();
            this.NumCerveja = new System.Windows.Forms.NumericUpDown();
            this.NumSuco = new System.Windows.Forms.NumericUpDown();
            this.GpbAlmoco.SuspendLayout();
            this.GpbBebidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAlmoco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefrigerante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCerveja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSuco)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGINA DO RESTAURANTE";
            // 
            // txtNomeClient
            // 
            this.txtNomeClient.Location = new System.Drawing.Point(62, 42);
            this.txtNomeClient.Name = "txtNomeClient";
            this.txtNomeClient.Size = new System.Drawing.Size(100, 20);
            this.txtNomeClient.TabIndex = 1;
            // 
            // lblNomeClient
            // 
            this.lblNomeClient.AutoSize = true;
            this.lblNomeClient.Location = new System.Drawing.Point(14, 42);
            this.lblNomeClient.Name = "lblNomeClient";
            this.lblNomeClient.Size = new System.Drawing.Size(35, 13);
            this.lblNomeClient.TabIndex = 2;
            this.lblNomeClient.Text = "Nome";
            // 
            // lblNascClient
            // 
            this.lblNascClient.AutoSize = true;
            this.lblNascClient.Location = new System.Drawing.Point(14, 75);
            this.lblNascClient.Name = "lblNascClient";
            this.lblNascClient.Size = new System.Drawing.Size(32, 13);
            this.lblNascClient.TabIndex = 3;
            this.lblNascClient.Text = "Nasc";
            // 
            // DtpClient
            // 
            this.DtpClient.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpClient.Location = new System.Drawing.Point(62, 75);
            this.DtpClient.Name = "DtpClient";
            this.DtpClient.Size = new System.Drawing.Size(112, 20);
            this.DtpClient.TabIndex = 4;
            this.DtpClient.ValueChanged += new System.EventHandler(this.DtpClient_ValueChanged);
            // 
            // lblAniversario
            // 
            this.lblAniversario.AutoSize = true;
            this.lblAniversario.Location = new System.Drawing.Point(196, 82);
            this.lblAniversario.Name = "lblAniversario";
            this.lblAniversario.Size = new System.Drawing.Size(182, 13);
            this.lblAniversario.TabIndex = 5;
            this.lblAniversario.Text = "DESCONTO DE ANIVERSARIANTE";
            this.lblAniversario.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 123);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total: R$ 0,00";
            // 
            // CboAlmoco
            // 
            this.CboAlmoco.AutoSize = true;
            this.CboAlmoco.Location = new System.Drawing.Point(15, 151);
            this.CboAlmoco.Name = "CboAlmoco";
            this.CboAlmoco.Size = new System.Drawing.Size(61, 17);
            this.CboAlmoco.TabIndex = 8;
            this.CboAlmoco.Text = "Almoço";
            this.CboAlmoco.UseVisualStyleBackColor = true;
            this.CboAlmoco.CheckedChanged += new System.EventHandler(this.CboAlmoco_CheckedChanged);
            // 
            // CboBebidas
            // 
            this.CboBebidas.AutoSize = true;
            this.CboBebidas.Location = new System.Drawing.Point(243, 151);
            this.CboBebidas.Name = "CboBebidas";
            this.CboBebidas.Size = new System.Drawing.Size(64, 17);
            this.CboBebidas.TabIndex = 9;
            this.CboBebidas.Text = "Bebidas";
            this.CboBebidas.UseVisualStyleBackColor = true;
            this.CboBebidas.CheckedChanged += new System.EventHandler(this.CboBebidas_CheckedChanged);
            // 
            // GpbAlmoco
            // 
            this.GpbAlmoco.Controls.Add(this.NumAlmoco);
            this.GpbAlmoco.Controls.Add(this.lblOnde);
            this.GpbAlmoco.Controls.Add(this.label2);
            this.GpbAlmoco.Location = new System.Drawing.Point(15, 174);
            this.GpbAlmoco.Name = "GpbAlmoco";
            this.GpbAlmoco.Size = new System.Drawing.Size(200, 110);
            this.GpbAlmoco.TabIndex = 10;
            this.GpbAlmoco.TabStop = false;
            this.GpbAlmoco.Text = "ALMOÇO";
            this.GpbAlmoco.Visible = false;
            // 
            // lblOnde
            // 
            this.lblOnde.AutoSize = true;
            this.lblOnde.Location = new System.Drawing.Point(7, 49);
            this.lblOnde.Name = "lblOnde";
            this.lblOnde.Size = new System.Drawing.Size(38, 13);
            this.lblOnde.TabIndex = 1;
            this.lblOnde.Text = "QTND";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "+  R$ 35,00";
            // 
            // GpbBebidas
            // 
            this.GpbBebidas.Controls.Add(this.NumSuco);
            this.GpbBebidas.Controls.Add(this.NumCerveja);
            this.GpbBebidas.Controls.Add(this.NumRefrigerante);
            this.GpbBebidas.Controls.Add(this.lbl67);
            this.GpbBebidas.Controls.Add(this.CboSuco);
            this.GpbBebidas.Controls.Add(this.CboRefrig);
            this.GpbBebidas.Controls.Add(this.CboCerveja);
            this.GpbBebidas.Location = new System.Drawing.Point(243, 174);
            this.GpbBebidas.Name = "GpbBebidas";
            this.GpbBebidas.Size = new System.Drawing.Size(237, 110);
            this.GpbBebidas.TabIndex = 11;
            this.GpbBebidas.TabStop = false;
            this.GpbBebidas.Text = "BEBIDAS";
            this.GpbBebidas.Visible = false;
            // 
            // lbl67
            // 
            this.lbl67.AutoSize = true;
            this.lbl67.Location = new System.Drawing.Point(182, 15);
            this.lbl67.Name = "lbl67";
            this.lbl67.Size = new System.Drawing.Size(38, 13);
            this.lbl67.TabIndex = 6;
            this.lbl67.Text = "QTND";
            // 
            // CboSuco
            // 
            this.CboSuco.AutoSize = true;
            this.CboSuco.Location = new System.Drawing.Point(6, 83);
            this.CboSuco.Name = "CboSuco";
            this.CboSuco.Size = new System.Drawing.Size(95, 17);
            this.CboSuco.TabIndex = 2;
            this.CboSuco.Text = "SUCO $ 11,50";
            this.CboSuco.UseVisualStyleBackColor = true;
            this.CboSuco.CheckedChanged += new System.EventHandler(this.CboSuco_CheckedChanged);
            // 
            // CboRefrig
            // 
            this.CboRefrig.AutoSize = true;
            this.CboRefrig.Location = new System.Drawing.Point(6, 34);
            this.CboRefrig.Name = "CboRefrig";
            this.CboRefrig.Size = new System.Drawing.Size(149, 17);
            this.CboRefrig.TabIndex = 0;
            this.CboRefrig.Text = "REFRIGERANTE $ 12,00";
            this.CboRefrig.UseVisualStyleBackColor = true;
            this.CboRefrig.CheckedChanged += new System.EventHandler(this.CboRefrig_CheckedChanged);
            // 
            // CboCerveja
            // 
            this.CboCerveja.AutoSize = true;
            this.CboCerveja.Location = new System.Drawing.Point(6, 59);
            this.CboCerveja.Name = "CboCerveja";
            this.CboCerveja.Size = new System.Drawing.Size(110, 17);
            this.CboCerveja.TabIndex = 1;
            this.CboCerveja.Text = "CERVEJA $15,00";
            this.CboCerveja.UseVisualStyleBackColor = true;
            this.CboCerveja.CheckedChanged += new System.EventHandler(this.CboCerveja_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(17, 290);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(256, 52);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar conta";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMostrar.Location = new System.Drawing.Point(170, 12);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(33, 23);
            this.btnMostrar.TabIndex = 15;
            this.btnMostrar.Text = "V";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(170, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 23);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NumAlmoco
            // 
            this.NumAlmoco.Location = new System.Drawing.Point(52, 49);
            this.NumAlmoco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAlmoco.Name = "NumAlmoco";
            this.NumAlmoco.Size = new System.Drawing.Size(120, 20);
            this.NumAlmoco.TabIndex = 2;
            this.NumAlmoco.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumAlmoco.ValueChanged += new System.EventHandler(this.NumAlmoco_ValueChanged);
            // 
            // NumRefrigerante
            // 
            this.NumRefrigerante.Location = new System.Drawing.Point(173, 31);
            this.NumRefrigerante.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRefrigerante.Name = "NumRefrigerante";
            this.NumRefrigerante.Size = new System.Drawing.Size(47, 20);
            this.NumRefrigerante.TabIndex = 3;
            this.NumRefrigerante.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumRefrigerante.Visible = false;
            this.NumRefrigerante.ValueChanged += new System.EventHandler(this.NumRefrigerante_ValueChanged);
            // 
            // NumCerveja
            // 
            this.NumCerveja.Location = new System.Drawing.Point(173, 54);
            this.NumCerveja.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCerveja.Name = "NumCerveja";
            this.NumCerveja.Size = new System.Drawing.Size(47, 20);
            this.NumCerveja.TabIndex = 7;
            this.NumCerveja.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumCerveja.Visible = false;
            this.NumCerveja.ValueChanged += new System.EventHandler(this.NumCerveja_ValueChanged);
            // 
            // NumSuco
            // 
            this.NumSuco.Location = new System.Drawing.Point(173, 80);
            this.NumSuco.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSuco.Name = "NumSuco";
            this.NumSuco.Size = new System.Drawing.Size(47, 20);
            this.NumSuco.TabIndex = 8;
            this.NumSuco.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumSuco.Visible = false;
            this.NumSuco.ValueChanged += new System.EventHandler(this.NumSuco_ValueChanged);
            // 
            // FrmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.GpbAlmoco);
            this.Controls.Add(this.CboAlmoco);
            this.Controls.Add(this.CboBebidas);
            this.Controls.Add(this.GpbBebidas);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAniversario);
            this.Controls.Add(this.DtpClient);
            this.Controls.Add(this.lblNascClient);
            this.Controls.Add(this.lblNomeClient);
            this.Controls.Add(this.txtNomeClient);
            this.Controls.Add(this.label1);
            this.Name = "FrmRestaurante";
            this.Text = "FrmRestaurante";
            this.Load += new System.EventHandler(this.FrmRestaurante_Load);
            this.GpbAlmoco.ResumeLayout(false);
            this.GpbAlmoco.PerformLayout();
            this.GpbBebidas.ResumeLayout(false);
            this.GpbBebidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumAlmoco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRefrigerante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumCerveja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumSuco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeClient;
        private System.Windows.Forms.Label lblNomeClient;
        private System.Windows.Forms.Label lblNascClient;
        private System.Windows.Forms.DateTimePicker DtpClient;
        private System.Windows.Forms.Label lblAniversario;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.CheckBox CboAlmoco;
        private System.Windows.Forms.CheckBox CboBebidas;
        private System.Windows.Forms.GroupBox GpbAlmoco;
        private System.Windows.Forms.Label lblOnde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GpbBebidas;
        private System.Windows.Forms.CheckBox CboSuco;
        private System.Windows.Forms.CheckBox CboCerveja;
        private System.Windows.Forms.CheckBox CboRefrig;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl67;
        private System.Windows.Forms.NumericUpDown NumAlmoco;
        private System.Windows.Forms.NumericUpDown NumSuco;
        private System.Windows.Forms.NumericUpDown NumCerveja;
        private System.Windows.Forms.NumericUpDown NumRefrigerante;
    }
}
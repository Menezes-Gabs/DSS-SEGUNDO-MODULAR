namespace DSS_PROJ_BD_21_09
{
    partial class FrmEstoque
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescrição = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbSaida = new System.Windows.Forms.RadioButton();
            this.rdbEntrada = new System.Windows.Forms.RadioButton();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtQtnd = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.dtbData = new System.Windows.Forms.DateTimePicker();
            this.btnLanca = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMovimento = new System.Windows.Forms.TextBox();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 21);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DESCRIÇÃO";
            // 
            // lblDescrição
            // 
            this.lblDescrição.AutoSize = true;
            this.lblDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescrição.Location = new System.Drawing.Point(15, 94);
            this.lblDescrição.Name = "lblDescrição";
            this.lblDescrição.Size = new System.Drawing.Size(19, 13);
            this.lblDescrição.TabIndex = 2;
            this.lblDescrição.Text = "...";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(92, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(86, 20);
            this.txtCodigo.TabIndex = 3;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbSaida);
            this.groupBox1.Controls.Add(this.rdbEntrada);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(12, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 56);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MOVIMENTAÇÃO";
            // 
            // rdbSaida
            // 
            this.rdbSaida.AutoSize = true;
            this.rdbSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSaida.Location = new System.Drawing.Point(139, 19);
            this.rdbSaida.Name = "rdbSaida";
            this.rdbSaida.Size = new System.Drawing.Size(81, 29);
            this.rdbSaida.TabIndex = 1;
            this.rdbSaida.TabStop = true;
            this.rdbSaida.Text = "Saida";
            this.rdbSaida.UseVisualStyleBackColor = true;
            // 
            // rdbEntrada
            // 
            this.rdbEntrada.AutoSize = true;
            this.rdbEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEntrada.Location = new System.Drawing.Point(6, 19);
            this.rdbEntrada.Name = "rdbEntrada";
            this.rdbEntrada.Size = new System.Drawing.Size(98, 29);
            this.rdbEntrada.TabIndex = 0;
            this.rdbEntrada.TabStop = true;
            this.rdbEntrada.Text = "Entrada";
            this.rdbEntrada.UseVisualStyleBackColor = true;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(14, 215);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(171, 20);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "ATUAL QUANTIDADE";
            // 
            // txtQtnd
            // 
            this.txtQtnd.Location = new System.Drawing.Point(191, 215);
            this.txtQtnd.Name = "txtQtnd";
            this.txtQtnd.Size = new System.Drawing.Size(103, 20);
            this.txtQtnd.TabIndex = 6;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(14, 291);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(52, 20);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "DATA";
            // 
            // dtbData
            // 
            this.dtbData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtbData.Location = new System.Drawing.Point(73, 290);
            this.dtbData.MinDate = new System.DateTime(2026, 1, 1, 0, 0, 0, 0);
            this.dtbData.Name = "dtbData";
            this.dtbData.Size = new System.Drawing.Size(162, 20);
            this.dtbData.TabIndex = 8;
            // 
            // btnLanca
            // 
            this.btnLanca.Location = new System.Drawing.Point(16, 337);
            this.btnLanca.Name = "btnLanca";
            this.btnLanca.Size = new System.Drawing.Size(365, 84);
            this.btnLanca.TabIndex = 9;
            this.btnLanca.Text = "LANÇAR";
            this.btnLanca.UseVisualStyleBackColor = true;
            this.btnLanca.Click += new System.EventHandler(this.btnLanca_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "QUANTIDADE A ATUALIZAR";
            // 
            // txtMovimento
            // 
            this.txtMovimento.Location = new System.Drawing.Point(242, 250);
            this.txtMovimento.Name = "txtMovimento";
            this.txtMovimento.Size = new System.Drawing.Size(103, 20);
            this.txtMovimento.TabIndex = 11;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Red;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft JhengHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnvoltar.Location = new System.Drawing.Point(319, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(62, 24);
            this.btnvoltar.TabIndex = 17;
            this.btnvoltar.Text = "MENU";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 433);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.txtMovimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLanca);
            this.Controls.Add(this.dtbData);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.txtQtnd);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblDescrição);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl1);
            this.Name = "FrmEstoque";
            this.Text = "FrmEstoque";
            this.Load += new System.EventHandler(this.FrmEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescrição;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbSaida;
        private System.Windows.Forms.RadioButton rdbEntrada;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtQtnd;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.DateTimePicker dtbData;
        private System.Windows.Forms.Button btnLanca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMovimento;
        private System.Windows.Forms.Button btnvoltar;
    }
}
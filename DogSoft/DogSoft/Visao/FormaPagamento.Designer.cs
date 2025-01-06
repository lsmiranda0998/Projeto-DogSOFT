namespace DogSoft.Visao
{
    partial class FormaPagamento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvParcelas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnADD = new System.Windows.Forms.Button();
            this.labelTOTAL = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnTUDO = new System.Windows.Forms.Button();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.txValor = new System.Windows.Forms.TextBox();
            this.txRestante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txValorManual = new System.Windows.Forms.TextBox();
            this.txDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txVezes = new System.Windows.Forms.TextBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelRestante = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.labelValorManual = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnGerar);
            this.groupBox1.Controls.Add(this.btnADD);
            this.groupBox1.Controls.Add(this.labelTOTAL);
            this.groupBox1.Controls.Add(this.dtpData);
            this.groupBox1.Controls.Add(this.btnTUDO);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.txValor);
            this.groupBox1.Controls.Add(this.txRestante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txValorManual);
            this.groupBox1.Controls.Add(this.txDia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txVezes);
            this.groupBox1.Controls.Add(this.labelDia);
            this.groupBox1.Controls.Add(this.labelRestante);
            this.groupBox1.Controls.Add(this.labelData);
            this.groupBox1.Controls.Add(this.labelValorManual);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(732, 511);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvParcelas);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 255);
            this.panel1.TabIndex = 29;
            // 
            // dgvParcelas
            // 
            this.dgvParcelas.AllowUserToAddRows = false;
            this.dgvParcelas.AllowUserToDeleteRows = false;
            this.dgvParcelas.AllowUserToOrderColumns = true;
            this.dgvParcelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParcelas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvParcelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParcelas.Location = new System.Drawing.Point(0, 0);
            this.dgvParcelas.Name = "dgvParcelas";
            this.dgvParcelas.ReadOnly = true;
            this.dgvParcelas.Size = new System.Drawing.Size(673, 255);
            this.dgvParcelas.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "parcela";
            this.Column1.HeaderText = "Parcela";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "valor";
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "data";
            this.Column3.HeaderText = "Data de vencimento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(673, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(53, 255);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Image = global::DogSoft.Properties.Resources.icons8menos16;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 255);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(5, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 82);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 12);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dinheiro";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(107, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cartão de Crédito";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 57);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(105, 17);
            this.radioButton5.TabIndex = 0;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Cartão de Débito";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // btnGerar
            // 
            this.btnGerar.Image = global::DogSoft.Properties.Resources.maisDocumento;
            this.btnGerar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGerar.Location = new System.Drawing.Point(576, 135);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(109, 42);
            this.btnGerar.TabIndex = 27;
            this.btnGerar.Text = "Gerar Parcelas";
            this.btnGerar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnADD
            // 
            this.btnADD.Image = global::DogSoft.Properties.Resources.icons8mais16;
            this.btnADD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnADD.Location = new System.Drawing.Point(576, 184);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(109, 36);
            this.btnADD.TabIndex = 4;
            this.btnADD.Text = "Adicionar";
            this.btnADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // labelTOTAL
            // 
            this.labelTOTAL.AutoSize = true;
            this.labelTOTAL.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOTAL.Location = new System.Drawing.Point(3, 492);
            this.labelTOTAL.Name = "labelTOTAL";
            this.labelTOTAL.Size = new System.Drawing.Size(51, 16);
            this.labelTOTAL.TabIndex = 26;
            this.labelTOTAL.Text = "label2";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(233, 198);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(104, 20);
            this.dtpData.TabIndex = 3;
            // 
            // btnTUDO
            // 
            this.btnTUDO.Location = new System.Drawing.Point(140, 111);
            this.btnTUDO.Name = "btnTUDO";
            this.btnTUDO.Size = new System.Drawing.Size(58, 23);
            this.btnTUDO.TabIndex = 3;
            this.btnTUDO.Text = "TUDO";
            this.btnTUDO.UseVisualStyleBackColor = true;
            this.btnTUDO.Click += new System.EventHandler(this.btnTUDO_Click);
            this.btnTUDO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnTUDO_KeyPress);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(5, 135);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(57, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "A vista";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 158);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(73, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Parcelado";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // txValor
            // 
            this.txValor.Location = new System.Drawing.Point(2, 113);
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(132, 20);
            this.txValor.TabIndex = 2;
            this.txValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValor_KeyPress);
            // 
            // txRestante
            // 
            this.txRestante.Enabled = false;
            this.txRestante.Location = new System.Drawing.Point(470, 198);
            this.txRestante.Name = "txRestante";
            this.txRestante.Size = new System.Drawing.Size(100, 20);
            this.txRestante.TabIndex = 2;
            this.txRestante.Visible = false;
            this.txRestante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txRestante_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "*Informe o valor a ser pago:";
            // 
            // txValorManual
            // 
            this.txValorManual.Location = new System.Drawing.Point(349, 198);
            this.txValorManual.Name = "txValorManual";
            this.txValorManual.Size = new System.Drawing.Size(100, 20);
            this.txValorManual.TabIndex = 2;
            this.txValorManual.Visible = false;
            this.txValorManual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txValorManual_KeyPress);
            // 
            // txDia
            // 
            this.txDia.Location = new System.Drawing.Point(124, 200);
            this.txDia.Name = "txDia";
            this.txDia.Size = new System.Drawing.Size(100, 20);
            this.txDia.TabIndex = 2;
            this.txDia.Visible = false;
            this.txDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txDia_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Qtde Parcelas";
            this.label1.Visible = false;
            // 
            // txVezes
            // 
            this.txVezes.Location = new System.Drawing.Point(5, 200);
            this.txVezes.Name = "txVezes";
            this.txVezes.Size = new System.Drawing.Size(100, 20);
            this.txVezes.TabIndex = 2;
            this.txVezes.Visible = false;
            this.txVezes.TextChanged += new System.EventHandler(this.txVezes_TextChanged);
            this.txVezes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txVezes_KeyPress);
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(121, 183);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(103, 13);
            this.labelDia.TabIndex = 1;
            this.labelDia.Text = "*Dia de vencimento:";
            this.labelDia.Visible = false;
            // 
            // labelRestante
            // 
            this.labelRestante.AutoSize = true;
            this.labelRestante.Location = new System.Drawing.Point(467, 184);
            this.labelRestante.Name = "labelRestante";
            this.labelRestante.Size = new System.Drawing.Size(72, 13);
            this.labelRestante.TabIndex = 1;
            this.labelRestante.Text = "Valor restante";
            this.labelRestante.Visible = false;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(230, 184);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(107, 13);
            this.labelData.TabIndex = 1;
            this.labelData.Text = "*Data de vencimento";
            this.labelData.Visible = false;
            // 
            // labelValorManual
            // 
            this.labelValorManual.AutoSize = true;
            this.labelValorManual.Location = new System.Drawing.Point(346, 184);
            this.labelValorManual.Name = "labelValorManual";
            this.labelValorManual.Size = new System.Drawing.Size(35, 13);
            this.labelValorManual.TabIndex = 1;
            this.labelValorManual.Text = "*Valor";
            this.labelValorManual.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.btnConfirmar);
            this.flowLayoutPanel1.Controls.Add(this.btnVoltar);
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 524);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(732, 37);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::DogSoft.Properties.Resources.save_accept;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(3, 3);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(270, 37);
            this.btnConfirmar.TabIndex = 21;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::DogSoft.Properties.Resources.gtkcancel;
            this.btnVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoltar.Location = new System.Drawing.Point(279, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(270, 37);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(0, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(556, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "**Obs.: Caso digite um valor maior do que o valor final, o acréscimo sera conside" +
    "rado como juros";
            // 
            // FormaPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormaPagamento";
            this.Text = " Escolha e forma de pagamento...";
            this.Load += new System.EventHandler(this.FormaPagamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParcelas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button btnTUDO;
        private System.Windows.Forms.TextBox txValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label labelTOTAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvParcelas;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox txRestante;
        private System.Windows.Forms.TextBox txValorManual;
        private System.Windows.Forms.TextBox txDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txVezes;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelRestante;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelValorManual;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}
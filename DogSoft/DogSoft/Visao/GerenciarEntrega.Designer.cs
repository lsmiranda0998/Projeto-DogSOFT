namespace DogSoft.Visao
{
    partial class GerenciarEntrega
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbObs = new System.Windows.Forms.RichTextBox();
            this.tbHoraRetorno = new System.Windows.Forms.MaskedTextBox();
            this.tbHoraSaida = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.tbfuncod = new System.Windows.Forms.TextBox();
            this.tbCliCod = new System.Windows.Forms.TextBox();
            this.tbTroco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbValorTot = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbFuncionario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.txRua = new System.Windows.Forms.TextBox();
            this.lbClinome = new System.Windows.Forms.Label();
            this.txNomeCLi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTot = new System.Windows.Forms.GroupBox();
            this.tbFrete = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTotRecebido = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btConfirmar = new System.Windows.Forms.Button();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbTot.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 529);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 160;
            this.label4.Text = "Observações/Reclamações";
            // 
            // tbObs
            // 
            this.tbObs.Enabled = false;
            this.tbObs.Location = new System.Drawing.Point(143, 545);
            this.tbObs.Name = "tbObs";
            this.tbObs.Size = new System.Drawing.Size(479, 96);
            this.tbObs.TabIndex = 159;
            this.tbObs.Text = "";
            // 
            // tbHoraRetorno
            // 
            this.tbHoraRetorno.Enabled = false;
            this.tbHoraRetorno.Location = new System.Drawing.Point(381, 492);
            this.tbHoraRetorno.Mask = "90:00";
            this.tbHoraRetorno.Name = "tbHoraRetorno";
            this.tbHoraRetorno.Size = new System.Drawing.Size(38, 20);
            this.tbHoraRetorno.TabIndex = 157;
            this.tbHoraRetorno.ValidatingType = typeof(System.DateTime);
            // 
            // tbHoraSaida
            // 
            this.tbHoraSaida.Enabled = false;
            this.tbHoraSaida.Location = new System.Drawing.Point(217, 492);
            this.tbHoraSaida.Mask = "90:00";
            this.tbHoraSaida.Name = "tbHoraSaida";
            this.tbHoraSaida.Size = new System.Drawing.Size(38, 20);
            this.tbHoraSaida.TabIndex = 158;
            this.tbHoraSaida.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 156;
            this.label3.Text = "Horario Saida";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.tbfuncod);
            this.gbPedido.Controls.Add(this.tbCliCod);
            this.gbPedido.Controls.Add(this.tbTroco);
            this.gbPedido.Controls.Add(this.label12);
            this.gbPedido.Controls.Add(this.label10);
            this.gbPedido.Controls.Add(this.tbValorTot);
            this.gbPedido.Controls.Add(this.dataGridView1);
            this.gbPedido.Controls.Add(this.label1);
            this.gbPedido.Controls.Add(this.button1);
            this.gbPedido.Controls.Add(this.tbFuncionario);
            this.gbPedido.Controls.Add(this.label6);
            this.gbPedido.Controls.Add(this.txNumero);
            this.gbPedido.Controls.Add(this.txBairro);
            this.gbPedido.Controls.Add(this.lbBairro);
            this.gbPedido.Controls.Add(this.lbNumero);
            this.gbPedido.Controls.Add(this.lbRua);
            this.gbPedido.Controls.Add(this.txRua);
            this.gbPedido.Controls.Add(this.lbClinome);
            this.gbPedido.Controls.Add(this.txNomeCLi);
            this.gbPedido.Controls.Add(this.groupBox1);
            this.gbPedido.Location = new System.Drawing.Point(5, 42);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(1159, 429);
            this.gbPedido.TabIndex = 154;
            this.gbPedido.TabStop = false;
            this.gbPedido.Text = "Pedido";
            // 
            // tbfuncod
            // 
            this.tbfuncod.Enabled = false;
            this.tbfuncod.Location = new System.Drawing.Point(988, 177);
            this.tbfuncod.Name = "tbfuncod";
            this.tbfuncod.Size = new System.Drawing.Size(100, 20);
            this.tbfuncod.TabIndex = 143;
            this.tbfuncod.Visible = false;
            // 
            // tbCliCod
            // 
            this.tbCliCod.Enabled = false;
            this.tbCliCod.Location = new System.Drawing.Point(983, 78);
            this.tbCliCod.Name = "tbCliCod";
            this.tbCliCod.Size = new System.Drawing.Size(100, 20);
            this.tbCliCod.TabIndex = 142;
            this.tbCliCod.Visible = false;
            // 
            // tbTroco
            // 
            this.tbTroco.Enabled = false;
            this.tbTroco.Location = new System.Drawing.Point(759, 146);
            this.tbTroco.Name = "tbTroco";
            this.tbTroco.Size = new System.Drawing.Size(103, 20);
            this.tbTroco.TabIndex = 140;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(759, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 141;
            this.label12.Text = "Troco";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1066, 379);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 139;
            this.label10.Text = "Valor Total:";
            // 
            // tbValorTot
            // 
            this.tbValorTot.Enabled = false;
            this.tbValorTot.Location = new System.Drawing.Point(1070, 402);
            this.tbValorTot.Name = "tbValorTot";
            this.tbValorTot.Size = new System.Drawing.Size(83, 20);
            this.tbValorTot.TabIndex = 138;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Status,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column4,
            this.Column8,
            this.Column9});
            this.dataGridView1.Location = new System.Drawing.Point(16, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 203);
            this.dataGridView1.TabIndex = 91;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "pro_descricao";
            this.Column1.HeaderText = "Produto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "pro_val";
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "pro_cod";
            this.Column3.HeaderText = "Cod";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "pro_status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pro_qtde";
            this.Column5.HeaderText = "Qtde";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "itp_qtde";
            this.Column6.HeaderText = "Qtde";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "itp_obs";
            this.Column7.HeaderText = "Observação";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "itp_cod";
            this.Column4.HeaderText = "RGPCOD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pro_cod1";
            this.Column8.HeaderText = "PROCOD";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "rgp_cod";
            this.Column9.HeaderText = "rgp";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 90;
            this.label1.Text = "Itens:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 66);
            this.button1.TabIndex = 89;
            this.button1.Text = "Buscar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbFuncionario
            // 
            this.tbFuncionario.Enabled = false;
            this.tbFuncionario.Location = new System.Drawing.Point(10, 86);
            this.tbFuncionario.Name = "tbFuncionario";
            this.tbFuncionario.Size = new System.Drawing.Size(577, 20);
            this.tbFuncionario.TabIndex = 87;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 86;
            this.label6.Text = "Entregador Responsavel";
            // 
            // txNumero
            // 
            this.txNumero.Enabled = false;
            this.txNumero.Location = new System.Drawing.Point(602, 146);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(91, 20);
            this.txNumero.TabIndex = 85;
            // 
            // txBairro
            // 
            this.txBairro.Enabled = false;
            this.txBairro.Location = new System.Drawing.Point(16, 146);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(269, 20);
            this.txBairro.TabIndex = 80;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.lbBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBairro.Location = new System.Drawing.Point(12, 129);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(38, 13);
            this.lbBairro.TabIndex = 81;
            this.lbBairro.Text = "*Bairro";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(599, 129);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(48, 13);
            this.lbNumero.TabIndex = 83;
            this.lbNumero.Text = "*Numero";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(287, 128);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(31, 13);
            this.lbRua.TabIndex = 84;
            this.lbRua.Text = "*Rua";
            // 
            // txRua
            // 
            this.txRua.Enabled = false;
            this.txRua.Location = new System.Drawing.Point(291, 146);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(305, 20);
            this.txRua.TabIndex = 82;
            // 
            // lbClinome
            // 
            this.lbClinome.AutoSize = true;
            this.lbClinome.Location = new System.Drawing.Point(7, 26);
            this.lbClinome.Name = "lbClinome";
            this.lbClinome.Size = new System.Drawing.Size(70, 13);
            this.lbClinome.TabIndex = 79;
            this.lbClinome.Text = "Nome Cliente";
            // 
            // txNomeCLi
            // 
            this.txNomeCLi.Enabled = false;
            this.txNomeCLi.Location = new System.Drawing.Point(10, 42);
            this.txNomeCLi.Name = "txNomeCLi";
            this.txNomeCLi.Size = new System.Drawing.Size(580, 20);
            this.txNomeCLi.TabIndex = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(720, 72);
            this.groupBox1.TabIndex = 88;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 155;
            this.label2.Text = "Horario Retorno";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(220, 29);
            this.label8.TabIndex = 153;
            this.label8.Text = "Gerenciar Entrega";
            // 
            // tbTot
            // 
            this.tbTot.Controls.Add(this.tbFrete);
            this.tbTot.Controls.Add(this.label7);
            this.tbTot.Controls.Add(this.label11);
            this.tbTot.Controls.Add(this.tbTotRecebido);
            this.tbTot.Controls.Add(this.tbTotal);
            this.tbTot.Controls.Add(this.label5);
            this.tbTot.Location = new System.Drawing.Point(5, 481);
            this.tbTot.Name = "tbTot";
            this.tbTot.Size = new System.Drawing.Size(1159, 190);
            this.tbTot.TabIndex = 161;
            this.tbTot.TabStop = false;
            this.tbTot.Text = "Entrega";
            this.tbTot.Enter += new System.EventHandler(this.tbTot_Enter);
            // 
            // tbFrete
            // 
            this.tbFrete.Enabled = false;
            this.tbFrete.Location = new System.Drawing.Point(522, 14);
            this.tbFrete.Name = "tbFrete";
            this.tbFrete.Size = new System.Drawing.Size(95, 20);
            this.tbFrete.TabIndex = 144;
            this.tbFrete.Enter += new System.EventHandler(this.tbFrete_Enter);
            this.tbFrete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFrete_KeyPress);
            this.tbFrete.Leave += new System.EventHandler(this.tbFrete_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(458, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 145;
            this.label7.Text = "Valor Frete";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(924, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 149;
            this.label11.Text = "Valor Total Entrega";
            // 
            // tbTotRecebido
            // 
            this.tbTotRecebido.Enabled = false;
            this.tbTotRecebido.Location = new System.Drawing.Point(1053, 164);
            this.tbTotRecebido.Name = "tbTotRecebido";
            this.tbTotRecebido.Size = new System.Drawing.Size(95, 20);
            this.tbTotRecebido.TabIndex = 142;
            this.tbTotRecebido.Enter += new System.EventHandler(this.tbTotRecebido_Enter);
            this.tbTotRecebido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTotRecebido_KeyPress);
            this.tbTotRecebido.Leave += new System.EventHandler(this.tbTotRecebido_Leave);
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(927, 164);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(95, 20);
            this.tbTotal.TabIndex = 148;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1050, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 143;
            this.label5.Text = "Valor Total Recebido";
            // 
            // btLimpar
            // 
            this.btLimpar.Image = global::DogSoft.Properties.Resources.editclear;
            this.btLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpar.Location = new System.Drawing.Point(370, 711);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(151, 45);
            this.btLimpar.TabIndex = 162;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Image = global::DogSoft.Properties.Resources.i_check;
            this.btConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btConfirmar.Location = new System.Drawing.Point(573, 711);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(151, 45);
            this.btConfirmar.TabIndex = 163;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // GerenciarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 794);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btConfirmar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbObs);
            this.Controls.Add(this.tbHoraRetorno);
            this.Controls.Add(this.tbHoraSaida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTot);
            this.Name = "GerenciarEntrega";
            this.Text = "GerenciarEntrega";
            this.Load += new System.EventHandler(this.GerenciarEntrega_Load);
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbTot.ResumeLayout(false);
            this.tbTot.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox tbObs;
        private System.Windows.Forms.MaskedTextBox tbHoraRetorno;
        private System.Windows.Forms.MaskedTextBox tbHoraSaida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.TextBox tbfuncod;
        private System.Windows.Forms.TextBox tbCliCod;
        private System.Windows.Forms.TextBox tbTroco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbValorTot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label lbClinome;
        private System.Windows.Forms.TextBox txNomeCLi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox tbTot;
        private System.Windows.Forms.TextBox tbFrete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTotRecebido;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label5;
    }
}
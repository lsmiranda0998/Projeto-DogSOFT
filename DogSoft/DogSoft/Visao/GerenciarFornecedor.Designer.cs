namespace DogSoft.Visao
{
    partial class GerenciarFornecedor
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
            this.label8 = new System.Windows.Forms.Label();
            this.lbPRINCIPAL = new System.Windows.Forms.Label();
            this.lbEstado = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.txTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txCEP = new System.Windows.Forms.MaskedTextBox();
            this.lbFORNECEDOR = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lbRazao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.txRazao = new System.Windows.Forms.TextBox();
            this.txNomeFantasia = new System.Windows.Forms.TextBox();
            this.txCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNumero = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.lbComplemento = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.lbCNPJ = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txRua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(331, 29);
            this.label8.TabIndex = 169;
            this.label8.Text = "Registrar Pedido Telefonico";
            // 
            // lbPRINCIPAL
            // 
            this.lbPRINCIPAL.AutoSize = true;
            this.lbPRINCIPAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPRINCIPAL.Location = new System.Drawing.Point(396, -1);
            this.lbPRINCIPAL.Name = "lbPRINCIPAL";
            this.lbPRINCIPAL.Size = new System.Drawing.Size(64, 25);
            this.lbPRINCIPAL.TabIndex = 168;
            this.lbPRINCIPAL.Text = "label2";
            // 
            // lbEstado
            // 
            this.lbEstado.AutoSize = true;
            this.lbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstado.Location = new System.Drawing.Point(291, 4);
            this.lbEstado.Name = "lbEstado";
            this.lbEstado.Size = new System.Drawing.Size(176, 31);
            this.lbEstado.TabIndex = 167;
            this.lbEstado.Text = "Estado Inicial";
            // 
            // txNome
            // 
            this.txNome.Location = new System.Drawing.Point(7, 67);
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(275, 20);
            this.txNome.TabIndex = 166;
            // 
            // txNumero
            // 
            this.txNumero.Location = new System.Drawing.Point(317, 205);
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(91, 20);
            this.txNumero.TabIndex = 164;
            this.txNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txNumero_KeyPress_1);
            // 
            // txComplemento
            // 
            this.txComplemento.Location = new System.Drawing.Point(414, 205);
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(141, 20);
            this.txComplemento.TabIndex = 165;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(139, 54);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(40, 13);
            this.lbCodigo.TabIndex = 159;
            this.lbCodigo.Text = "Codigo";
            this.lbCodigo.Visible = false;
            // 
            // txTelefone
            // 
            this.txTelefone.Location = new System.Drawing.Point(5, 252);
            this.txTelefone.Mask = "(00)00000-0000";
            this.txTelefone.Name = "txTelefone";
            this.txTelefone.Size = new System.Drawing.Size(278, 20);
            this.txTelefone.TabIndex = 158;
            // 
            // txCEP
            // 
            this.txCEP.Location = new System.Drawing.Point(267, 155);
            this.txCEP.Mask = "00000-000";
            this.txCEP.Name = "txCEP";
            this.txCEP.Size = new System.Drawing.Size(95, 20);
            this.txCEP.TabIndex = 156;
            this.txCEP.Leave += new System.EventHandler(this.txCEP_Leave_1);
            // 
            // lbFORNECEDOR
            // 
            this.lbFORNECEDOR.AutoSize = true;
            this.lbFORNECEDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFORNECEDOR.Location = new System.Drawing.Point(7, 11);
            this.lbFORNECEDOR.Name = "lbFORNECEDOR";
            this.lbFORNECEDOR.Size = new System.Drawing.Size(120, 24);
            this.lbFORNECEDOR.TabIndex = 154;
            this.lbFORNECEDOR.Text = "Fornecedor";
            // 
            // txCodigo
            // 
            this.txCodigo.Enabled = false;
            this.txCodigo.Location = new System.Drawing.Point(133, 15);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(100, 20);
            this.txCodigo.TabIndex = 157;
            this.txCodigo.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(592, 138);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 92);
            this.btnBuscar.TabIndex = 155;
            this.btnBuscar.Text = "Pesquisar...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lbRazao
            // 
            this.lbRazao.AutoSize = true;
            this.lbRazao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRazao.Location = new System.Drawing.Point(284, 99);
            this.lbRazao.Name = "lbRazao";
            this.lbRazao.Size = new System.Drawing.Size(74, 13);
            this.lbRazao.TabIndex = 137;
            this.lbRazao.Text = "*Razão Social";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNome.Location = new System.Drawing.Point(3, 50);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(104, 13);
            this.lbNome.TabIndex = 136;
            this.lbNome.Text = "*Nome Responsavel";
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNomeFantasia.Location = new System.Drawing.Point(0, 99);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(82, 13);
            this.lbNomeFantasia.TabIndex = 135;
            this.lbNomeFantasia.Text = "*Nome Fantasia";
            // 
            // txRazao
            // 
            this.txRazao.Location = new System.Drawing.Point(289, 115);
            this.txRazao.Name = "txRazao";
            this.txRazao.Size = new System.Drawing.Size(266, 20);
            this.txRazao.TabIndex = 134;
            // 
            // txNomeFantasia
            // 
            this.txNomeFantasia.Location = new System.Drawing.Point(5, 115);
            this.txNomeFantasia.Name = "txNomeFantasia";
            this.txNomeFantasia.Size = new System.Drawing.Size(278, 20);
            this.txNomeFantasia.TabIndex = 133;
            // 
            // txCNPJ
            // 
            this.txCNPJ.Location = new System.Drawing.Point(296, 67);
            this.txCNPJ.Mask = "00.000.000/0000-00";
            this.txCNPJ.Name = "txCNPJ";
            this.txCNPJ.Size = new System.Drawing.Size(100, 20);
            this.txCNPJ.TabIndex = 153;
            // 
            // txBairro
            // 
            this.txBairro.Location = new System.Drawing.Point(368, 154);
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(187, 20);
            this.txBairro.TabIndex = 138;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(6, 153);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(97, 21);
            this.cmbEstado.TabIndex = 151;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged_1);
            // 
            // cmbCidade
            // 
            this.cmbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Location = new System.Drawing.Point(109, 153);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(143, 21);
            this.cmbCidade.TabIndex = 152;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.BackColor = System.Drawing.SystemColors.Control;
            this.lbBairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbBairro.Location = new System.Drawing.Point(365, 138);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(38, 13);
            this.lbBairro.TabIndex = 141;
            this.lbBairro.Text = "*Bairro";
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(263, 140);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(32, 13);
            this.lbCep.TabIndex = 150;
            this.lbCep.Text = "*CEP";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(294, 236);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(36, 13);
            this.lbEmail.TabIndex = 149;
            this.lbEmail.Text = "*Email";
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(314, 188);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(48, 13);
            this.lbNumero.TabIndex = 147;
            this.lbNumero.Text = "*Numero";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(5, 236);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(53, 13);
            this.lbTelefone.TabIndex = 148;
            this.lbTelefone.Text = "*Telefone";
            // 
            // lbComplemento
            // 
            this.lbComplemento.AutoSize = true;
            this.lbComplemento.Location = new System.Drawing.Point(411, 188);
            this.lbComplemento.Name = "lbComplemento";
            this.lbComplemento.Size = new System.Drawing.Size(71, 13);
            this.lbComplemento.TabIndex = 146;
            this.lbComplemento.Text = "Complemento";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Location = new System.Drawing.Point(2, 187);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(31, 13);
            this.lbRua.TabIndex = 145;
            this.lbRua.Text = "*Rua";
            // 
            // lbCNPJ
            // 
            this.lbCNPJ.AutoSize = true;
            this.lbCNPJ.Location = new System.Drawing.Point(293, 50);
            this.lbCNPJ.Name = "lbCNPJ";
            this.lbCNPJ.Size = new System.Drawing.Size(38, 13);
            this.lbCNPJ.TabIndex = 140;
            this.lbCNPJ.Text = "*CNPJ";
            // 
            // txEmail
            // 
            this.txEmail.Location = new System.Drawing.Point(297, 252);
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(258, 20);
            this.txEmail.TabIndex = 144;
            // 
            // txRua
            // 
            this.txRua.Location = new System.Drawing.Point(6, 205);
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(305, 20);
            this.txRua.TabIndex = 143;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 142;
            this.label1.Text = "*Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 139;
            this.label5.Text = "*Cidade";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Image = global::DogSoft.Properties.Resources.save_accept;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(9, 13);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(182, 42);
            this.btnConfirmar.TabIndex = 163;
            this.btnConfirmar.Text = "Gravar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::DogSoft.Properties.Resources.close;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(197, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(182, 42);
            this.btnCancelar.TabIndex = 161;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = global::DogSoft.Properties.Resources.trash_16x16;
            this.btnDeletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.Location = new System.Drawing.Point(385, 13);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(182, 42);
            this.btnDeletar.TabIndex = 162;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click_1);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = global::DogSoft.Properties.Resources.icons8mais16;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(573, 13);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(182, 42);
            this.btnNovo.TabIndex = 160;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(789, 72);
            this.panel1.TabIndex = 170;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbEstado);
            this.panel2.Controls.Add(this.txNome);
            this.panel2.Controls.Add(this.txNumero);
            this.panel2.Controls.Add(this.txComplemento);
            this.panel2.Controls.Add(this.txTelefone);
            this.panel2.Controls.Add(this.txCEP);
            this.panel2.Controls.Add(this.lbFORNECEDOR);
            this.panel2.Controls.Add(this.txCodigo);
            this.panel2.Controls.Add(this.btnBuscar);
            this.panel2.Controls.Add(this.lbRazao);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Controls.Add(this.lbNomeFantasia);
            this.panel2.Controls.Add(this.txRazao);
            this.panel2.Controls.Add(this.txNomeFantasia);
            this.panel2.Controls.Add(this.txCNPJ);
            this.panel2.Controls.Add(this.txBairro);
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.cmbCidade);
            this.panel2.Controls.Add(this.lbBairro);
            this.panel2.Controls.Add(this.lbCep);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.lbNumero);
            this.panel2.Controls.Add(this.lbTelefone);
            this.panel2.Controls.Add(this.lbComplemento);
            this.panel2.Controls.Add(this.lbRua);
            this.panel2.Controls.Add(this.lbCNPJ);
            this.panel2.Controls.Add(this.txEmail);
            this.panel2.Controls.Add(this.txRua);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(789, 314);
            this.panel2.TabIndex = 171;
            // 
            // GerenciarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 415);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbPRINCIPAL);
            this.Controls.Add(this.lbCodigo);
            this.Name = "GerenciarFornecedor";
            this.Text = "GerenciarFornecedor";
            this.Load += new System.EventHandler(this.GerenciarFornecedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbPRINCIPAL;
        private System.Windows.Forms.Label lbEstado;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.TextBox txComplemento;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.MaskedTextBox txTelefone;
        private System.Windows.Forms.MaskedTextBox txCEP;
        private System.Windows.Forms.Label lbFORNECEDOR;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lbRazao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.TextBox txRazao;
        private System.Windows.Forms.TextBox txNomeFantasia;
        private System.Windows.Forms.MaskedTextBox txCNPJ;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.Label lbComplemento;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label lbCNPJ;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
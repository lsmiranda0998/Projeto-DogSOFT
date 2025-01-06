namespace DogSoft.Visao
{
    partial class ConsultaFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.cmpCampo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewButtonColumn();
            this.col_Nivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colmasd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCampo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(3, 49);
            this.txCPF.Mask = "000.000.000-00";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(88, 20);
            this.txCPF.TabIndex = 15;
            // 
            // cmpCampo
            // 
            this.cmpCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpCampo.FormattingEnabled = true;
            this.cmpCampo.Items.AddRange(new object[] {
            "Nome",
            "CPF"});
            this.cmpCampo.Location = new System.Drawing.Point(171, 48);
            this.cmpCampo.Name = "cmpCampo";
            this.cmpCampo.Size = new System.Drawing.Size(121, 21);
            this.cmpCampo.TabIndex = 14;
            this.cmpCampo.SelectedIndexChanged += new System.EventHandler(this.cmpCampo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesquisar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "info";
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Situacao,
            this.col_Nivel,
            this.cpf,
            this.Column1,
            this.Login,
            this.Column3,
            this.Column7,
            this.DataNascimento,
            this.Column4,
            this.Column2,
            this.colum5,
            this.column6,
            this.column11,
            this.Column5,
            this.Colmasd,
            this.column22,
            this.Column8,
            this.Column9});
            this.dgvUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuario.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvUsuario.Location = new System.Drawing.Point(0, 75);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvUsuario.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.NullValue = "Informação inexistente";
            this.dgvUsuario.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvUsuario.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuario.Size = new System.Drawing.Size(1024, 415);
            this.dgvUsuario.TabIndex = 10;
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick_1);
            this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "pes_nome";
            this.Nome.FillWeight = 300F;
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 10;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.Width = 350;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "fun_ativo";
            this.Situacao.HeaderText = "Conta ativa?";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            // 
            // col_Nivel
            // 
            this.col_Nivel.DataPropertyName = "fun_nivel";
            this.col_Nivel.HeaderText = "Nível da conta";
            this.col_Nivel.Name = "col_Nivel";
            this.col_Nivel.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "fun_cpf";
            this.cpf.HeaderText = "C.P.F";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "fun_salario";
            this.Column1.HeaderText = "Salário";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.DataPropertyName = "fun_login";
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pes_email";
            this.Column3.HeaderText = "Email";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "pes_telefone";
            this.Column7.HeaderText = "Telefone";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // DataNascimento
            // 
            this.DataNascimento.DataPropertyName = "fun_dataNasc";
            this.DataNascimento.HeaderText = "DataNascimento";
            this.DataNascimento.Name = "DataNascimento";
            this.DataNascimento.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "fun_sexo";
            this.Column4.HeaderText = "Sexo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "pes_cep";
            this.Column2.HeaderText = "CEP";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // colum5
            // 
            this.colum5.DataPropertyName = "pes_rua";
            this.colum5.HeaderText = "Rua";
            this.colum5.Name = "colum5";
            this.colum5.ReadOnly = true;
            this.colum5.Visible = false;
            // 
            // column6
            // 
            this.column6.DataPropertyName = "pes_bairro";
            this.column6.HeaderText = "Bairro";
            this.column6.Name = "column6";
            this.column6.ReadOnly = true;
            // 
            // column11
            // 
            this.column11.DataPropertyName = "pes_cod1";
            this.column11.HeaderText = "Codigo";
            this.column11.Name = "column11";
            this.column11.ReadOnly = true;
            this.column11.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "pes_complemento";
            this.Column5.HeaderText = "Complemento";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Colmasd
            // 
            this.Colmasd.DataPropertyName = "pes_num";
            this.Colmasd.HeaderText = "Numero de rua";
            this.Colmasd.Name = "Colmasd";
            this.Colmasd.ReadOnly = true;
            this.Colmasd.Visible = false;
            // 
            // column22
            // 
            this.column22.DataPropertyName = "cid_cod";
            this.column22.HeaderText = "CodigoCidade";
            this.column22.Name = "column22";
            this.column22.ReadOnly = true;
            this.column22.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "fun_senha";
            this.Column8.HeaderText = "Senha";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "pes_cod";
            this.Column9.HeaderText = "Column9";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // txCampo
            // 
            this.txCampo.Location = new System.Drawing.Point(3, 49);
            this.txCampo.Name = "txCampo";
            this.txCampo.Size = new System.Drawing.Size(147, 20);
            this.txCampo.TabIndex = 9;
            this.txCampo.TextChanged += new System.EventHandler(this.txCampo_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txCPF);
            this.panel1.Controls.Add(this.txCampo);
            this.panel1.Controls.Add(this.cmpCampo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 75);
            this.panel1.TabIndex = 16;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Image = global::DogSoft.Properties.Resources.i_check;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(311, 29);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(142, 43);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = global::DogSoft.Properties.Resources.editclear;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(879, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 13;
            this.button1.Text = "Limpar Dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConsultaFuncionario
            // 
            this.AcceptButton = this.btnConfirmar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 490);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultaFuncionario";
            this.Text = "ConsultaFuncionario";
            this.Load += new System.EventHandler(this.ConsultaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.ComboBox cmpCampo;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUsuario;
        private System.Windows.Forms.TextBox txCampo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewButtonColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum5;
        private System.Windows.Forms.DataGridViewTextBoxColumn column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colmasd;
        private System.Windows.Forms.DataGridViewTextBoxColumn column22;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}
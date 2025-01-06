namespace DogSoft.Visao
{
    partial class ConsultaAtendimento
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmpCampo = new System.Windows.Forms.ComboBox();
            this.txCampo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvAtendimento = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pesquisar por:";
            // 
            // cmpCampo
            // 
            this.cmpCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmpCampo.FormattingEnabled = true;
            this.cmpCampo.Items.AddRange(new object[] {
            "Cliente",
            "Data"});
            this.cmpCampo.Location = new System.Drawing.Point(174, 28);
            this.cmpCampo.Name = "cmpCampo";
            this.cmpCampo.Size = new System.Drawing.Size(121, 21);
            this.cmpCampo.TabIndex = 21;
            this.cmpCampo.SelectedIndexChanged += new System.EventHandler(this.cmpCampo_SelectedIndexChanged);
            // 
            // txCampo
            // 
            this.txCampo.Location = new System.Drawing.Point(6, 29);
            this.txCampo.Name = "txCampo";
            this.txCampo.Size = new System.Drawing.Size(147, 20);
            this.txCampo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "info";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Image = global::DogSoft.Properties.Resources.editclear;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(641, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Limpar Dados";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.AutoSize = true;
            this.btnConfirmar.Image = global::DogSoft.Properties.Resources.i_check;
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(314, 9);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(142, 43);
            this.btnConfirmar.TabIndex = 20;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvAtendimento
            // 
            this.dgvAtendimento.AllowUserToAddRows = false;
            this.dgvAtendimento.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAtendimento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAtendimento.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvAtendimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAtendimento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvAtendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAtendimento.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgvAtendimento.Location = new System.Drawing.Point(0, 69);
            this.dgvAtendimento.Name = "dgvAtendimento";
            this.dgvAtendimento.ReadOnly = true;
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.NullValue = "Informação inexistente";
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Blue;
            this.dgvAtendimento.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAtendimento.Size = new System.Drawing.Size(1078, 682);
            this.dgvAtendimento.TabIndex = 22;
            this.dgvAtendimento.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtendimento_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtpData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConfirmar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txCampo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmpCampo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 69);
            this.panel1.TabIndex = 23;
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(6, 30);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(111, 20);
            this.dtpData.TabIndex = 22;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "pes_nome";
            this.Nome.FillWeight = 300F;
            this.Nome.HeaderText = "Cliente";
            this.Nome.MinimumWidth = 10;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Nome.Width = 350;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "fun_login";
            this.Column1.HeaderText = "Funcionario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "aten_valorFinal";
            this.Column2.HeaderText = "Valor";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "aten_status";
            this.Column3.HeaderText = "Status";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "mes_cod";
            this.Column4.HeaderText = "Mesa";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "aten_data";
            this.Column5.HeaderText = "Data";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "aten_cod";
            this.Column6.HeaderText = "";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "cli_cod";
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // ConsultaAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 751);
            this.Controls.Add(this.dgvAtendimento);
            this.Controls.Add(this.panel1);
            this.Name = "ConsultaAtendimento";
            this.Text = "ConsultaAtendimento";
            this.Load += new System.EventHandler(this.ConsultaAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtendimento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmpCampo;
        private System.Windows.Forms.TextBox txCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvAtendimento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
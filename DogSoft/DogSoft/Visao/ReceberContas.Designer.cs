namespace DogSoft.Visao
{
    partial class ReceberContas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceberContas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvContas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.txCPF = new System.Windows.Forms.MaskedTextBox();
            this.gbFiltroAdd = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbVencidas = new System.Windows.Forms.RadioButton();
            this.rbHoje = new System.Windows.Forms.RadioButton();
            this.rbIntervaloVencimento = new System.Windows.Forms.RadioButton();
            this.rbIntervaloValores = new System.Windows.Forms.RadioButton();
            this.rbVencimento = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.rbBaixadas = new System.Windows.Forms.RadioButton();
            this.rbPendentes = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.btnCancelarBaixa = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.gbFiltroAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 470);
            this.panel1.TabIndex = 132;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.gbFiltros);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 441);
            this.panel2.TabIndex = 132;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvContas);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1251, 282);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parcelas referentes ao cliente";
            // 
            // dgvContas
            // 
            this.dgvContas.AllowUserToAddRows = false;
            this.dgvContas.AllowUserToDeleteRows = false;
            this.dgvContas.AllowUserToResizeColumns = false;
            this.dgvContas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            this.dgvContas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Column4,
            this.Column5,
            this.Cliente,
            this.Vencimento,
            this.Valor,
            this.Column1,
            this.CodVenda,
            this.Column2,
            this.Column3,
            this.situacao,
            this.Column6});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.NullValue = "Não informado";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvContas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvContas.Location = new System.Drawing.Point(3, 16);
            this.dgvContas.MultiSelect = false;
            this.dgvContas.Name = "dgvContas";
            this.dgvContas.ReadOnly = true;
            this.dgvContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContas.Size = new System.Drawing.Size(1245, 247);
            this.dgvContas.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "cr_cod";
            this.Codigo.FillWeight = 40F;
            this.Codigo.HeaderText = "";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Visible = false;
            this.Codigo.Width = 40;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "aten_cod";
            this.Column4.HeaderText = "";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "caixa_cod";
            this.Column5.HeaderText = "";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Cliente
            // 
            this.Cliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cliente.DataPropertyName = "pes_nome";
            this.Cliente.FillWeight = 300F;
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // Vencimento
            // 
            this.Vencimento.DataPropertyName = "cr_dataVenc";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.Vencimento.DefaultCellStyle = dataGridViewCellStyle2;
            this.Vencimento.FillWeight = 90F;
            this.Vencimento.HeaderText = "Vencimento da Parcela";
            this.Vencimento.Name = "Vencimento";
            this.Vencimento.ReadOnly = true;
            this.Vencimento.Width = 110;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "aten_valorFinal";
            dataGridViewCellStyle3.Format = "C2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor.HeaderText = "Valor Total da Conta";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 130;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cr_valor";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column1.HeaderText = "Valor da Parcela";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // CodVenda
            // 
            this.CodVenda.DataPropertyName = "aten_data";
            this.CodVenda.FillWeight = 50F;
            this.CodVenda.HeaderText = "Data gerada";
            this.CodVenda.Name = "CodVenda";
            this.CodVenda.ReadOnly = true;
            this.CodVenda.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cr_valorPago";
            this.Column2.HeaderText = "Valor Pago";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cr_dataPagamento";
            this.Column3.HeaderText = "Data Pagamento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "cr_situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cr_observacao";
            this.Column6.HeaderText = "Observação";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(3, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(523, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "*Obs.: O estorno só é possivel na parcela mais recente da conta referente.";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.txCPF);
            this.gbFiltros.Controls.Add(this.gbFiltroAdd);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.rbBaixadas);
            this.gbFiltros.Controls.Add(this.rbPendentes);
            this.gbFiltros.Controls.Add(this.label1);
            this.gbFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFiltros.Location = new System.Drawing.Point(0, 0);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1251, 159);
            this.gbFiltros.TabIndex = 0;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // txCPF
            // 
            this.txCPF.Location = new System.Drawing.Point(9, 32);
            this.txCPF.Mask = "000.000.000-00";
            this.txCPF.Name = "txCPF";
            this.txCPF.Size = new System.Drawing.Size(149, 20);
            this.txCPF.TabIndex = 129;
            // 
            // gbFiltroAdd
            // 
            this.gbFiltroAdd.Controls.Add(this.groupBox1);
            this.gbFiltroAdd.Controls.Add(this.rbIntervaloVencimento);
            this.gbFiltroAdd.Controls.Add(this.rbIntervaloValores);
            this.gbFiltroAdd.Controls.Add(this.rbVencimento);
            this.gbFiltroAdd.Controls.Add(this.label3);
            this.gbFiltroAdd.Controls.Add(this.label4);
            this.gbFiltroAdd.Controls.Add(this.dtpDataInicio);
            this.gbFiltroAdd.Controls.Add(this.label6);
            this.gbFiltroAdd.Controls.Add(this.dtpDataFim);
            this.gbFiltroAdd.Controls.Add(this.label5);
            this.gbFiltroAdd.Controls.Add(this.txtValorInicial);
            this.gbFiltroAdd.Controls.Add(this.txtValorFinal);
            this.gbFiltroAdd.Location = new System.Drawing.Point(12, 56);
            this.gbFiltroAdd.Name = "gbFiltroAdd";
            this.gbFiltroAdd.Size = new System.Drawing.Size(469, 96);
            this.gbFiltroAdd.TabIndex = 128;
            this.gbFiltroAdd.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVencidas);
            this.groupBox1.Controls.Add(this.rbHoje);
            this.groupBox1.Location = new System.Drawing.Point(363, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(80, 46);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbVencidas
            // 
            this.rbVencidas.AutoSize = true;
            this.rbVencidas.Location = new System.Drawing.Point(6, 6);
            this.rbVencidas.Name = "rbVencidas";
            this.rbVencidas.Size = new System.Drawing.Size(69, 17);
            this.rbVencidas.TabIndex = 6;
            this.rbVencidas.TabStop = true;
            this.rbVencidas.Text = "Vencidas";
            this.rbVencidas.UseVisualStyleBackColor = true;
            // 
            // rbHoje
            // 
            this.rbHoje.AutoSize = true;
            this.rbHoje.Location = new System.Drawing.Point(6, 29);
            this.rbHoje.Name = "rbHoje";
            this.rbHoje.Size = new System.Drawing.Size(47, 17);
            this.rbHoje.TabIndex = 6;
            this.rbHoje.TabStop = true;
            this.rbHoje.Text = "Hoje";
            this.rbHoje.UseVisualStyleBackColor = true;
            // 
            // rbIntervaloVencimento
            // 
            this.rbIntervaloVencimento.AutoSize = true;
            this.rbIntervaloVencimento.Location = new System.Drawing.Point(6, 16);
            this.rbIntervaloVencimento.Name = "rbIntervaloVencimento";
            this.rbIntervaloVencimento.Size = new System.Drawing.Size(140, 17);
            this.rbIntervaloVencimento.TabIndex = 0;
            this.rbIntervaloVencimento.TabStop = true;
            this.rbIntervaloVencimento.Text = "Intervalo de Vencimento";
            this.rbIntervaloVencimento.UseVisualStyleBackColor = true;
            this.rbIntervaloVencimento.CheckedChanged += new System.EventHandler(this.rbIntervaloVencimento_CheckedChanged);
            // 
            // rbIntervaloValores
            // 
            this.rbIntervaloValores.AutoSize = true;
            this.rbIntervaloValores.Location = new System.Drawing.Point(188, 16);
            this.rbIntervaloValores.Name = "rbIntervaloValores";
            this.rbIntervaloValores.Size = new System.Drawing.Size(119, 17);
            this.rbIntervaloValores.TabIndex = 3;
            this.rbIntervaloValores.TabStop = true;
            this.rbIntervaloValores.Text = "Intervalo de Valores";
            this.rbIntervaloValores.UseVisualStyleBackColor = true;
            this.rbIntervaloValores.CheckedChanged += new System.EventHandler(this.rbIntervaloValores_CheckedChanged);
            // 
            // rbVencimento
            // 
            this.rbVencimento.AutoSize = true;
            this.rbVencimento.Location = new System.Drawing.Point(370, 16);
            this.rbVencimento.Name = "rbVencimento";
            this.rbVencimento.Size = new System.Drawing.Size(81, 17);
            this.rbVencimento.TabIndex = 6;
            this.rbVencimento.TabStop = true;
            this.rbVencimento.Text = "Vencimento";
            this.rbVencimento.UseVisualStyleBackColor = true;
            this.rbVencimento.CheckedChanged += new System.EventHandler(this.rbVencimento_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Fim";
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Enabled = false;
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.Location = new System.Drawing.Point(44, 40);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(102, 20);
            this.dtpDataInicio.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Final";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Enabled = false;
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(44, 66);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(102, 20);
            this.dtpDataFim.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Inicial";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Enabled = false;
            this.txtValorInicial.Location = new System.Drawing.Point(231, 40);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(108, 20);
            this.txtValorInicial.TabIndex = 4;
            this.txtValorInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorInicial_KeyPress);
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Enabled = false;
            this.txtValorFinal.Location = new System.Drawing.Point(231, 65);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(108, 20);
            this.txtValorFinal.TabIndex = 5;
            this.txtValorFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorFinal_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::DogSoft.Properties.Resources.oldeditfind;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(497, 62);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(174, 88);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // rbBaixadas
            // 
            this.rbBaixadas.AutoSize = true;
            this.rbBaixadas.Location = new System.Drawing.Point(283, 33);
            this.rbBaixadas.Name = "rbBaixadas";
            this.rbBaixadas.Size = new System.Drawing.Size(68, 17);
            this.rbBaixadas.TabIndex = 5;
            this.rbBaixadas.TabStop = true;
            this.rbBaixadas.Text = "Baixadas";
            this.rbBaixadas.UseVisualStyleBackColor = true;
            // 
            // rbPendentes
            // 
            this.rbPendentes.AutoSize = true;
            this.rbPendentes.Location = new System.Drawing.Point(200, 32);
            this.rbPendentes.Name = "rbPendentes";
            this.rbPendentes.Size = new System.Drawing.Size(76, 17);
            this.rbPendentes.TabIndex = 4;
            this.rbPendentes.TabStop = true;
            this.rbPendentes.Text = "Pendentes";
            this.rbPendentes.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "C.P.F. do Cliente:";
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(0, 470);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1251, 0);
            this.panel5.TabIndex = 131;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(319, 29);
            this.label7.TabIndex = 130;
            this.label7.Text = "Baixa de Contas a Receber";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.btnBaixar);
            this.flowLayoutPanel1.Controls.Add(this.btnCancelarBaixa);
            this.flowLayoutPanel1.Controls.Add(this.btnLimpar);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 470);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1251, 47);
            this.flowLayoutPanel1.TabIndex = 177;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Image = global::DogSoft.Properties.Resources.download20;
            this.btnBaixar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaixar.Location = new System.Drawing.Point(3, 3);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(400, 37);
            this.btnBaixar.TabIndex = 0;
            this.btnBaixar.Text = "Baixar Parcela";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // btnCancelarBaixa
            // 
            this.btnCancelarBaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarBaixa.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarBaixa.Image")));
            this.btnCancelarBaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarBaixa.Location = new System.Drawing.Point(409, 3);
            this.btnCancelarBaixa.Name = "btnCancelarBaixa";
            this.btnCancelarBaixa.Size = new System.Drawing.Size(400, 37);
            this.btnCancelarBaixa.TabIndex = 1;
            this.btnCancelarBaixa.Text = "Estorno";
            this.btnCancelarBaixa.UseVisualStyleBackColor = true;
            this.btnCancelarBaixa.Click += new System.EventHandler(this.btnCancelarBaixa_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(815, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(400, 37);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ReceberContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ReceberContas";
            this.Text = "ReceberContas";
            this.Load += new System.EventHandler(this.ReceberContas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContas)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.gbFiltroAdd.ResumeLayout(false);
            this.gbFiltroAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvContas;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.GroupBox gbFiltroAdd;
        private System.Windows.Forms.RadioButton rbIntervaloVencimento;
        private System.Windows.Forms.RadioButton rbIntervaloValores;
        private System.Windows.Forms.RadioButton rbVencimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.RadioButton rbBaixadas;
        private System.Windows.Forms.RadioButton rbPendentes;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Button btnBaixar;
        public System.Windows.Forms.Button btnCancelarBaixa;
        public System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txCPF;
        private System.Windows.Forms.RadioButton rbVencidas;
        private System.Windows.Forms.RadioButton rbHoje;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label2;
    }
}
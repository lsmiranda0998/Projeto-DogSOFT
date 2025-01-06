namespace DogSoft
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.painelTeste = new System.Windows.Forms.Panel();
            this.labelHH = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbNivel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbDataHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.itemCadFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametrizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsPessoas = new System.Windows.Forms.ToolStripMenuItem();
            this.itemConsFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.fundamentaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemReceberContas = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAtendimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarEntregaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPedidoTelefonicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.painelTeste.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.menuCadastros,
            this.menuConsultas,
            this.fundamentaisToolStripMenuItem,
            this.telaPrincipalToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(165, 621);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // painelTeste
            // 
            this.painelTeste.AutoSize = true;
            this.painelTeste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.painelTeste.BackColor = System.Drawing.Color.WhiteSmoke;
            this.painelTeste.Controls.Add(this.statusStrip1);
            this.painelTeste.Controls.Add(this.pb1);
            this.painelTeste.Controls.Add(this.labelHH);
            this.painelTeste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelTeste.Location = new System.Drawing.Point(159, 0);
            this.painelTeste.Name = "painelTeste";
            this.painelTeste.Size = new System.Drawing.Size(1277, 621);
            this.painelTeste.TabIndex = 11;
            this.painelTeste.Paint += new System.Windows.Forms.PaintEventHandler(this.painelTeste_Paint);
            // 
            // labelHH
            // 
            this.labelHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelHH.AutoSize = true;
            this.labelHH.Font = new System.Drawing.Font("Microsoft Sans Serif", 84F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHH.Location = new System.Drawing.Point(346, 9);
            this.labelHH.Name = "labelHH";
            this.labelHH.Size = new System.Drawing.Size(437, 126);
            this.labelHH.TabIndex = 0;
            this.labelHH.Text = "HH:MM";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbNivel,
            this.lbUsuarioLogado,
            this.lbDataHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 599);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1277, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbNivel
            // 
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNivel.Size = new System.Drawing.Size(34, 17);
            this.lbNivel.Text = "Nivel";
            // 
            // lbUsuarioLogado
            // 
            this.lbUsuarioLogado.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbUsuarioLogado.Name = "lbUsuarioLogado";
            this.lbUsuarioLogado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbUsuarioLogado.Size = new System.Drawing.Size(90, 17);
            this.lbUsuarioLogado.Text = "Usuário Logado";
            // 
            // lbDataHora
            // 
            this.lbDataHora.Name = "lbDataHora";
            this.lbDataHora.Size = new System.Drawing.Size(69, 17);
            this.lbDataHora.Text = "Data e Hora";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 621);
            this.panel1.TabIndex = 8;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShowShortcutKeys = false;
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 44);
            this.toolStripMenuItem1.Text = "Esconder";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // menuCadastros
            // 
            this.menuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemCadFuncionario,
            this.fornecedoresToolStripMenuItem,
            this.parametrizaçãoToolStripMenuItem});
            this.menuCadastros.Image = global::DogSoft.Properties.Resources.documentnew;
            this.menuCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuCadastros.Name = "menuCadastros";
            this.menuCadastros.Size = new System.Drawing.Size(152, 44);
            this.menuCadastros.Text = "Básicas";
            // 
            // itemCadFuncionario
            // 
            this.itemCadFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("itemCadFuncionario.Image")));
            this.itemCadFuncionario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemCadFuncionario.Name = "itemCadFuncionario";
            this.itemCadFuncionario.Size = new System.Drawing.Size(211, 46);
            this.itemCadFuncionario.Text = "Funcionários";
            this.itemCadFuncionario.Click += new System.EventHandler(this.itemCadFuncionario_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Image = global::DogSoft.Properties.Resources.companies;
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // parametrizaçãoToolStripMenuItem
            // 
            this.parametrizaçãoToolStripMenuItem.Image = global::DogSoft.Properties.Resources.webmaster;
            this.parametrizaçãoToolStripMenuItem.Name = "parametrizaçãoToolStripMenuItem";
            this.parametrizaçãoToolStripMenuItem.Size = new System.Drawing.Size(211, 46);
            this.parametrizaçãoToolStripMenuItem.Text = "Parametrização";
            this.parametrizaçãoToolStripMenuItem.Click += new System.EventHandler(this.parametrizaçãoToolStripMenuItem_Click);
            // 
            // menuConsultas
            // 
            this.menuConsultas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemConsPessoas,
            this.itemConsFuncionarios});
            this.menuConsultas.Image = global::DogSoft.Properties.Resources.oldeditfind;
            this.menuConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.menuConsultas.Name = "menuConsultas";
            this.menuConsultas.Size = new System.Drawing.Size(152, 44);
            this.menuConsultas.Text = "Consulta";
            // 
            // itemConsPessoas
            // 
            this.itemConsPessoas.Image = ((System.Drawing.Image)(resources.GetObject("itemConsPessoas.Image")));
            this.itemConsPessoas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemConsPessoas.Name = "itemConsPessoas";
            this.itemConsPessoas.Size = new System.Drawing.Size(190, 38);
            this.itemConsPessoas.Text = "Fornecedores";
            // 
            // itemConsFuncionarios
            // 
            this.itemConsFuncionarios.Image = ((System.Drawing.Image)(resources.GetObject("itemConsFuncionarios.Image")));
            this.itemConsFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.itemConsFuncionarios.Name = "itemConsFuncionarios";
            this.itemConsFuncionarios.Size = new System.Drawing.Size(190, 38);
            this.itemConsFuncionarios.Text = "Funcionários";
            this.itemConsFuncionarios.Click += new System.EventHandler(this.itemConsFuncionarios_Click);
            // 
            // fundamentaisToolStripMenuItem
            // 
            this.fundamentaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemReceberContas,
            this.registrarAtendimentoToolStripMenuItem,
            this.gerenciarEntregaToolStripMenuItem,
            this.registrarPedidoTelefonicoToolStripMenuItem});
            this.fundamentaisToolStripMenuItem.Image = global::DogSoft.Properties.Resources.MoneyBag;
            this.fundamentaisToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fundamentaisToolStripMenuItem.Name = "fundamentaisToolStripMenuItem";
            this.fundamentaisToolStripMenuItem.Size = new System.Drawing.Size(152, 44);
            this.fundamentaisToolStripMenuItem.Text = "Fundamentais";
            // 
            // itemReceberContas
            // 
            this.itemReceberContas.Image = global::DogSoft.Properties.Resources.packing;
            this.itemReceberContas.Name = "itemReceberContas";
            this.itemReceberContas.Size = new System.Drawing.Size(293, 46);
            this.itemReceberContas.Text = "Receber Contas";
            this.itemReceberContas.Click += new System.EventHandler(this.receberContasToolStripMenuItem_Click);
            // 
            // registrarAtendimentoToolStripMenuItem
            // 
            this.registrarAtendimentoToolStripMenuItem.Image = global::DogSoft.Properties.Resources.MoneyBag;
            this.registrarAtendimentoToolStripMenuItem.Name = "registrarAtendimentoToolStripMenuItem";
            this.registrarAtendimentoToolStripMenuItem.Size = new System.Drawing.Size(293, 46);
            this.registrarAtendimentoToolStripMenuItem.Text = "Registrar Atendimento";
            this.registrarAtendimentoToolStripMenuItem.Click += new System.EventHandler(this.registrarAtendimentoToolStripMenuItem_Click);
            // 
            // gerenciarEntregaToolStripMenuItem
            // 
            this.gerenciarEntregaToolStripMenuItem.Image = global::DogSoft.Properties.Resources.creditcardpayment1;
            this.gerenciarEntregaToolStripMenuItem.Name = "gerenciarEntregaToolStripMenuItem";
            this.gerenciarEntregaToolStripMenuItem.Size = new System.Drawing.Size(293, 46);
            this.gerenciarEntregaToolStripMenuItem.Text = "Gerenciar entrega";
            this.gerenciarEntregaToolStripMenuItem.Click += new System.EventHandler(this.gerenciarEntregaToolStripMenuItem_Click);
            // 
            // registrarPedidoTelefonicoToolStripMenuItem
            // 
            this.registrarPedidoTelefonicoToolStripMenuItem.Image = global::DogSoft.Properties.Resources.Phone_number;
            this.registrarPedidoTelefonicoToolStripMenuItem.Name = "registrarPedidoTelefonicoToolStripMenuItem";
            this.registrarPedidoTelefonicoToolStripMenuItem.Size = new System.Drawing.Size(293, 46);
            this.registrarPedidoTelefonicoToolStripMenuItem.Text = "Registrar Pedido Telefonico";
            this.registrarPedidoTelefonicoToolStripMenuItem.Click += new System.EventHandler(this.registrarPedidoTelefonicoToolStripMenuItem_Click);
            // 
            // telaPrincipalToolStripMenuItem
            // 
            this.telaPrincipalToolStripMenuItem.Image = global::DogSoft.Properties.Resources.icons8páginainicial50;
            this.telaPrincipalToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.telaPrincipalToolStripMenuItem.Name = "telaPrincipalToolStripMenuItem";
            this.telaPrincipalToolStripMenuItem.Size = new System.Drawing.Size(152, 44);
            this.telaPrincipalToolStripMenuItem.Text = "Tela Principal";
            this.telaPrincipalToolStripMenuItem.Click += new System.EventHandler(this.telaPrincipalToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Image = global::DogSoft.Properties.Resources.icons8desligamentodoservidor48;
            this.sairToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 44);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click_1);
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(-156, 324);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(153, 214);
            this.pb1.TabIndex = 205;
            this.pb1.TabStop = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 621);
            this.Controls.Add(this.painelTeste);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Tela Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.painelTeste.ResumeLayout(false);
            this.painelTeste.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelTeste;
        private System.Windows.Forms.Label labelHH;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCadastros;
        private System.Windows.Forms.ToolStripMenuItem itemCadFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultas;
        private System.Windows.Forms.ToolStripMenuItem itemConsFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem telaPrincipalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemConsPessoas;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem fundamentaisToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbNivel;
        private System.Windows.Forms.ToolStripStatusLabel lbUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel lbDataHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemReceberContas;
        private System.Windows.Forms.ToolStripMenuItem registrarAtendimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarEntregaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPedidoTelefonicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametrizaçãoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pb1;
    }
}


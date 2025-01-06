using DogSoft.Controladora;
using DogSoft.Modelo;
using DogSoft.Visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DogSoft
{
    public partial class TelaPrincipal : Form
    {
        private Funcionario f;
        private DALFuncionario dalFun;
        Color cor;
        public TelaPrincipal()
        {
            
            InitializeComponent();
            dalFun = DALFuncionario.novaInstancia();
            if (dalFun.buscaFuncionarioTodosLOGIN("") == null)
            {
                MessageBox.Show("Primeiro acesso´detectado! Uma conta administrador (login: admin senha:admin) foi criada.", "Aviso",
                                                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                f = new Funcionario("admin", "admin", "admin", 0, "Admin", "1111-111", DateTime.Now, 'M', (Cidade) DALCidade.novaInstancia().buscarCid(1), "111.111.111-11", "(11)11111-1111", "admin@admin.com", '1', "admin", "admin", "x", 11);
                dalFun.insereFuncionario2(f);
                Acesso();

            }
            else
                Login();
            timer1.Start();
            carregaParametrizacao();
        }
        public void Login()
        {
            Login tela = new Login();
            tela.ShowDialog();
            if (tela.logado)
            {
                f = tela.getFuncionario();
                Acesso();
            }
            else
                Environment.Exit(0);
        }
        public void carregaParametrizacao()
        {
            DalParametrizacao dalp = DalParametrizacao.novaInstancia();
            DataTable dt = dalp.carrega();
            DataRow dr = dt.Rows[0];
            //lbContato.Text = "Contato:  "+"EMAIL:  "+dr["prm_email"].ToString()+"Telefone:  "+ dr["prm_telefone"].ToString() + "Site:  " + dr["prm_site"].ToString();
            //lbEndereco.Text= "Endereco:  Bairro: " + dr["prm_bairro"].ToString() + "Rua: " + dr["prm_rua"].ToString() + "Numero:  " + dr["prm_num"].ToString();

            this.BackColor = Color.FromName(dr["prm_corFundo"].ToString());

            cor = Color.FromName(dr["prm_corFonte"].ToString());
            /*label1.ForeColor = cor;
            label2.ForeColor = cor;
            label3.ForeColor = cor;
            label4.ForeColor = cor;
            label5.ForeColor = cor;*/
            Font font = new Font(dr["prm_fonte"].ToString(), Convert.ToInt32(dr["prm_size"])); this.Font = font;
            this.ForeColor = cor;
            pb1.ImageLocation = dr["prm_logo2"].ToString();
            //this.Font = font;
            //label8.Text = dr["prm_nomeFantasia"].ToString();


        }
        private void Acesso()
        {
            
            bool hab;
            lbDataHora.Text = "  " + DateTime.Now.ToShortDateString();
            lbUsuarioLogado.Text = f.getLogin();
            if (f.getNivel().Equals("Funcionário"))
            {
                hab = false;
                lbNivel.Text = "Funcionário Padrão";
            }
            else
            {
                hab = true;
                lbNivel.Text = "Administrador";
            }
            itemCadFuncionario.Enabled = hab;
            itemReceberContas.Enabled = hab;

            

  
        }
        void limpaFormPanel()
        {
            foreach (Control c in painelTeste.Controls)
            {
                if (c is Form)
                {
                    painelTeste.Controls.Remove(c);
                }
            }
        }
        void setVisibleTelaPrincipal(Boolean tipo)
        {
            labelHH.Visible = tipo;
            statusStrip1.Visible = tipo;
        }
        void adicionaTela(Form tela)
        {
            limpaFormPanel();
            setVisibleTelaPrincipal(false);
            tela.TopLevel = false;
            tela.Size = painelTeste.Size;
            tela.Width -= menuStrip1.Width;
            //tela.WindowState = FormWindowState.Maximized;
            tela.FormBorderStyle = FormBorderStyle.None;

            tela.MinimizeBox = false;
            tela.MaximizeBox = false;
            tela.Dock = DockStyle.Fill;
            tela.StartPosition = FormStartPosition.CenterScreen;
            painelTeste.Controls.Add(tela);
            tela.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHH.Text = DateTime.Now.ToShortTimeString();
        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void itemCadFuncionario_Click(object sender, EventArgs e)
        {
            Gerenciamentofuncionario tela = new Gerenciamentofuncionario(f);
            adicionaTela(tela);
        }

    


        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            if (panel1.Width == 52)
            {
                panel1.Width = 165;
                //panel2.Visible = true;
                painelTeste.Refresh();
            }
            else
            {
                panel1.Width = 52;
                //panel2.Visible = false;
                painelTeste.Refresh();
            }
        }

        private void sairToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void telaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpaFormPanel();
            setVisibleTelaPrincipal(true);
            
        }

        private void itemConsFuncionarios_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario tela = new ConsultaFuncionario(f);
            adicionaTela(tela);
        }

        private void receberContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReceberContas tela = new ReceberContas();
            adicionaTela(tela);
        }

        private void registrarAtendimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAtendimento tela = new RegistroAtendimento(f);
            adicionaTela(tela);
        }

        private void gerenciarEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarEntrega g = new GerenciarEntrega();
            adicionaTela(g);
        }

        private void registrarPedidoTelefonicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registar_Pedido_Telefonico rgp = new Registar_Pedido_Telefonico();
            adicionaTela(rgp);
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciarFornecedor f = new GerenciarFornecedor();
            adicionaTela(f);
        }

        private void parametrizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaParametrizacao t = new TelaParametrizacao();
            adicionaTela(t);
        }

        private void painelTeste_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

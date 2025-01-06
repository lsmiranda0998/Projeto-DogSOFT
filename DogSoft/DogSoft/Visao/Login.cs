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
    public partial class Login : Form
    {
        private DALFuncionario dalF;
        private Funcionario f;
        private DalParametrizacao dalp;
        public bool logado = false;

        internal Funcionario getFuncionario()
        {
            return f;
        }
        public Login()
        {
            InitializeComponent();
            dalF = DALFuncionario.novaInstancia();
            dalp = DalParametrizacao.novaInstancia();
            if (dalp.primeiroAcesso())
            {
                TelaParametrizacao p = new TelaParametrizacao();
                p.ShowDialog();
            }
            carregaParametrizacao();
        }

        public void btnCancelar_Click(object sender, EventArgs e)
        {
            txUsuario.Clear();
            txSenha.Clear();
            txUsuario.Focus();
        }
       public void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Informe o seu login!", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txUsuario.Focus();
            }
            else
            {
                if (txSenha.Text.Trim() == "")
                {
                    MessageBox.Show("Informe a sua senha!", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txSenha.Focus();
                }
                else
                {
                    f = dalF.buscaFuncionarioLOGIN(txUsuario.Text);
                    if (f != null && f.getAtivo() == '1')//conta existe e esta ativa
                    {
                        if (f.getSenha() == txSenha.Text)
                        {
                            MessageBox.Show("Conta encontrada! A Tela inicial está sendo carregada...", "Sucesso!",
                                      MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            logado = true;
                            Dispose();

                        }

                        else
                            MessageBox.Show("Senha incorreta!", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else//conta nao existe ou inativa
                    {
                        MessageBox.Show("Conta inexistente ou inativa.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    txUsuario.Clear();
                    txSenha.Clear();
                    txUsuario.Focus();

                }
            }
          

        }
        Color cor;
        public void carregaParametrizacao()
        {
            DalParametrizacao dalp = DalParametrizacao.novaInstancia();
            DataTable dt = dalp.carrega();
            DataRow dr = dt.Rows[0];


            this.BackColor = Color.FromName(dr["prm_corFundo"].ToString());

            cor = Color.FromName(dr["prm_corFonte"].ToString());
            /*label1.ForeColor = cor;
            label2.ForeColor = cor;
            label3.ForeColor = cor;
            label4.ForeColor = cor;
            label5.ForeColor = cor;*/
            Font font = new Font(dr["prm_fonte"].ToString(), Convert.ToInt32(dr["prm_size"]));
            this.Font = font;
            this.ForeColor = cor;
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}

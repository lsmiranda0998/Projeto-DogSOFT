using DogSoft.Controladora;
using DogSoft.Modelo;
using DogSoft.Visao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft
{
    public partial class Gerenciamentofuncionario : Form
    {
        private DALCidade dal;
        private DALEstado dalE;
        private DALFuncionario dalFun;
        private Funcionario f;
        public Gerenciamentofuncionario(Funcionario f)
        {
            InitializeComponent();
            dal = DALCidade.novaInstancia();
            dalE = DALEstado.novaInstancia();         
            dalFun = DALFuncionario.novaInstancia();
            this.f = f;
            radio1.Checked = true;
            radio3.Checked = true;
            txCodigo.Enabled = false;

            label10.Text = "Esta conta está configurada como inativa, portanto não será possível o seu acesso no sistema.";
            estadoInicial();
            cmbEstado.DisplayMember = "est_sgl";
            cmbEstado.ValueMember = "est_cod";
            cmbEstado.DataSource = dalE.buscarTodos();
            cmbFuncao.SelectedIndex = 0;
            carregaParametrizacao();
        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // In your constructor or somewhere more suitable:
       
        private void Gerenciamentofuncionario_Load(object sender, EventArgs e)
        {
            SendMessage(txEmail.Handle, 0x1501, 1, "example@example.com");
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

        private void estadoInclusao()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnDeletar.Enabled = false;
            label200.Enabled = true;
            label201.Enabled = true;
            btnDeletar.Enabled = true;
            gbSituacao.Enabled = true;
            radio3.Enabled = true;
            radio4.Enabled = true;
            cmbFuncao.Enabled = true;
        }
        private void estadoInicial()
        {
            panel1.Enabled = false;
            panel2.Enabled = false;
            btnConfirmar.Enabled = false;
            label14.Visible = false;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = true;
            btnDeletar.Enabled = false;
            label200.Enabled = false;
            label201.Enabled = true;
            label10.Visible = false;
            btnDeletar.Enabled = true;
            gbSituacao.Enabled = true;
            radio3.Enabled = true;
            radio4.Enabled = true;
            cmbFuncao.Enabled = true;
        }
        private void limpaTela()
        {
            txCodigo.Clear();
            txBairro.Clear();
            txCEP.Clear();
            txCPF.Clear();            
            txRua.Clear();
            txSenha.Clear();
            txNome.Clear();
            txLogin.Clear();
            txSalario.Clear();
            txTelefone.Clear();
            txEmail.Clear();
            cmbEstado.SelectedIndex = 0;
            cmbFuncao.SelectedIndex = 0;
            txComplemento.Clear();
            txNumero.Clear();
            //cmbNivel.SelectedIndex = 0;
            radio1.Checked = true;
            radio3.Checked = true;
            txCodigo.Enabled = false;

        }
        private bool verifica_cpf(string cpf2)
        {
            int temp = 0, digito1, digito2;
            int[] cpf = new int[12];
            for (int i = 0, j = 0; i < 11; i++, j++)
            {
                if (cpf2[j] == ',')
                {
                    j++;
                }

                if (cpf2[j] == '-')
                {
                    j++;
                }
                cpf[i] = cpf2[j] - '0';


            }
            for (int i = 0; i < 9; i++)
                temp += (cpf[i] * (10 - i));

            temp = temp % 11;

            if (temp < 2)
                digito1 = 0;
            else
                digito1 = 11 - temp;
            temp = 0;
            for (int i = 0; i < 10; i++)
                temp += (cpf[i] * (11 - i));

            temp %= 11;

            if (temp < 2)
                digito2 = 0;
            else
                digito2 = 11 - temp;

            if (digito1 == cpf[9] && digito2 == cpf[10])
                return true;
            else
                return false;

        }
        public bool validaEmail(string str)
        {
            Regex rg = new Regex
            (@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            if (rg.IsMatch(str))
                return true;
            return false;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            bool deu = false;
            if (txBairro.TextLength > 0)
            {// && txCEP.TextLength > 0 && txCPF.TextLength > 0 && txLogin.TextLength > 0 && txNome.TextLength > 0 && txRua.TextLength > 0 && txSalario.TextLength > 0 && txSenha.TextLength > 0 && txTelefone.TextLength>0 && txEmail.TextLength>0
                if (txCEP.MaskCompleted)
                {
                    if (txCPF.MaskCompleted)
                    {
                        if (txLogin.TextLength > 0)
                        {
                            if (txNome.TextLength > 0)
                            {
                                if (txRua.TextLength > 0)
                                {
                                    if (txSalario.TextLength > 0)
                                    {
                                        if (txSenha.TextLength > 0)
                                        {
                                            if (txTelefone.MaskCompleted)
                                            {
                                                if (txEmail.TextLength > 0 && validaEmail(txEmail.Text))
                                                {
                                                    if (verifica_cpf(txCPF.Text))
                                                    {
                                                        if (txNumero.TextLength > 0)
                                                        {
                                                            if (txCodigo.Text.Trim() == "") // cadastrando
                                                            {

                                                                char ativo;
                                                                //int funcao = cmbFuncao.SelectedIndex;
                                                                string Nivel = cmbFuncao.SelectedItem.ToString();
                                                                if (Nivel[0] == 'F')
                                                                    Nivel = "Funcionário";
                                                                else
                                                                    Nivel = "Admin";
                                                                //MessageBox.Show(Nivel);
                                                                string cidade = cmbCidade.Text;

                                                                Cidade cid = new Cidade();
                                                                cid = (Cidade)dal.buscarCidNOME(cidade);
                                                                if (radio3.Checked)
                                                                    ativo = '1';
                                                                else
                                                                    ativo = '0';

                                                                char sexo;
                                                                if (radio1.Checked)
                                                                    sexo = 'M';
                                                                else
                                                                    sexo = 'F';
                                                                //public bool insereUsuario(string nome, string rua, string bairro, string desc, decimal salario, String tipo, string cep, DateTime dataNasc, char sexo, Cidade c, string cpf, string fone, string mail)

                                                                if (dalFun.insereFuncionario(txNome.Text, txRua.Text, txBairro.Text, Convert.ToDecimal(txSalario.Text), Nivel, txCEP.Text, dtpDataNasc.Value, sexo, cid, txCPF.Text, txTelefone.Text, txEmail.Text, ativo, txLogin.Text, txSenha.Text, txComplemento.Text, Convert.ToInt32(txNumero.Text)))
                                                                {
                                                                    MessageBox.Show("Inserido com sucesso", "Aviso",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                                                    deu = true;
                                                                }

                                                                else
                                                                {
                                                                    MessageBox.Show("Erro ao cadastrar funcionario, certifique-se de que o CPF ou LOGIN preenchidos sejam únicos no sistema.", "Aviso",
                                                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                }
                                                            }
                                                             else // alterando
                                                             {
                                                                 string Nivel = cmbFuncao.SelectedItem.ToString();
                                                                 if (Nivel[0] == 'F')
                                                                    Nivel = "Funcionário";
                                                                 else
                                                                    Nivel = "Admin";
                                                                 char ativo;                                                         
                                                                 string cidade = cmbCidade.Text;
                                                                 Cidade cid = new Cidade();
                                                                 cid = (Cidade)dal.buscarCidNOME(cidade);
                                                                 if (radio3.Checked)
                                                                    ativo = '1';
                                                                 else
                                                                    ativo = '0';
                                                                 char sexo;
                                                                 if (radio1.Checked)
                                                                     sexo = 'M';
                                                                 else
                                                                     sexo = 'F';
                                                                if (dalFun.alteraFuncionario(txNome.Text, txRua.Text, txBairro.Text, Convert.ToDecimal(txSalario.Text), Nivel, txCEP.Text, dtpDataNasc.Value, sexo, cid, txCPF.Text, txTelefone.Text, txEmail.Text, ativo, txLogin.Text, txSenha.Text, txComplemento.Text, Convert.ToInt32(txNumero.Text),Convert.ToInt32(txCodigo.Text)))
                                                                {
                                                                    MessageBox.Show("Alterado com sucesso", "Aviso",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                    deu = true;
                                                                }
                                                                else
                                                                {
                                                                    MessageBox.Show("Ocorreu um erro ao alterar usuario! Certifique-se de que o CPF ou LOGIN preenchidos sejam únicos no sistema.", "Aviso",
                                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                                }

                                                             }
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Informe um número de residência", "Erro",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                            txNumero.Focus();
                                                        }


                                                    }

                                                    else
                                                    {
                                                        MessageBox.Show("Digite um CPF válido!", "Erro",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                        txCPF.Focus();
                                                    }

                                                } // email
                                                else
                                                {
                                                    MessageBox.Show("Informe um email válido", "Erro",
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                    txEmail.Focus();
                                                }
                                            }// telefone
                                            else
                                            {
                                                MessageBox.Show("Informe o telefone.", "Erro",
                                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                                txTelefone.Focus();
                                            }
                                        } // senha
                                        else
                                        {
                                            MessageBox.Show("Informe a senha.", "Erro",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                            txSenha.Focus();
                                        }
                                    } // salario
                                    else
                                    {
                                        MessageBox.Show("Informe o salario.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        txSalario.Focus();
                                    }
                                } // rua
                                else
                                {
                                    MessageBox.Show("Informe a rua.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    txRua.Focus();
                                }
                            } // nome
                            else
                            {
                                MessageBox.Show("Informe o seu nome.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                txNome.Focus();
                            }
                        } // login
                        else
                        {
                            MessageBox.Show("Informe o Login.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txLogin.Focus();
                        }
                    } // cpf
                    else
                    {
                        MessageBox.Show("Informe o CPF.", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txCPF.Focus();
                    }
                } // cep  
                else
                {
                    MessageBox.Show("Informe o CEP.", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txCEP.Focus();

                }
            } //bairro
            else
            {
                MessageBox.Show("Informe o bairro.", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txBairro.Focus();


            }
            if (deu)
            {
                limpaTela();
                estadoInicial();

            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            estadoInclusao();
            txNome.Focus();
        }

        private void cmbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.ValueMember = "cid_cod";
            cmbCidade.DisplayMember = "cid_nome";
            cmbCidade.DataSource = dal.buscarALL(Int32.Parse(cmbEstado.SelectedValue.ToString()));
        }

        private void txRua_TextChanged(object sender, EventArgs e)
        {

        }
        private int contaADM ()
        {
            DataTable temp = dalFun.buscaFuncionarioNOME("");
            int contContaADM = 0;
            foreach (DataRow lin in temp.Rows)
            {
                char sit = Convert.ToChar(lin["fun_ativo"]);
                string niv = lin["fun_nivel"].ToString();
                if (sit == '1' && niv.Equals("Admin"))
                    contContaADM++;
                //Console.WriteLine(lin["fun_login"].ToString());
            }
            return contContaADM;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFuncionario tela = new ConsultaFuncionario(f);
            tela.ShowDialog();
            label14.Visible = true;
            DataRow dr;
            dr = tela.getSelecionado();
            if (dr != null)
            {
                int funADM = contaADM();
                if (funADM > 1)
                {
                    btnDeletar.Enabled = true;
                    gbSituacao.Enabled = true;
                    radio3.Enabled = true;
                    radio4.Enabled = true;
                    cmbFuncao.Enabled = true;

                } 
                else
                {
                    if (!dr["fun_nivel"].ToString().Equals("Admin"))
                    {
                        btnDeletar.Enabled = true;
                        gbSituacao.Enabled = true;
                        radio3.Enabled = true;
                        radio4.Enabled = true;
                        cmbFuncao.Enabled = true;
                    }
                    else
                    {
                        btnDeletar.Enabled = false;                        
                        cmbFuncao.Enabled = false;
                        gbSituacao.Enabled = true;
                        radio3.Enabled = true;
                        radio4.Enabled = false;
                    }
                }
                if (dr["fun_login"].ToString().Equals(f.getLogin()))
                {
                    btnDeletar.Enabled = false;
                    cmbFuncao.Enabled = false;
                    
                    gbSituacao.Enabled = false;
                    radio3.Enabled = false;
                    radio4.Enabled = false;
                }
              
                    
                //MessageBox.Show(funADM.ToString());
                Cidade cid = (Cidade)dal.buscarCid(Convert.ToInt32(dr["cid_cod"]));
                Estado est = (Estado)dalE.buscar(cid.getEstado().getCodigo());
                dtpDataNasc.Value = Convert.ToDateTime(dr["fun_dataNasc"]);
                if (dr["fun_sexo"].ToString() == "M")
                    radio1.Checked = true;
                else
                    radio2.Checked = true;
               
                if (dr["fun_ativo"].ToString() == "S")
                    radio3.Checked = true;
                else
                    radio4.Checked = true;
                cmbEstado.Text = est.getSigla();
                cmbCidade.Text = cid.getNome();
                txBairro.Text = dr["pes_bairro"].ToString();
                txCEP.Text = dr["pes_cep"].ToString();
                txCodigo.Text = dr["pes_cod"].ToString();
                //MessageBox.Show(txCodigo.Text);
                txCPF.Text = dr["fun_cpf"].ToString();
                txComplemento.Text = dr["pes_complemento"].ToString();
                txNumero.Text = dr["pes_num"].ToString();
                txSalario.Text = dr["fun_salario"].ToString();
                txNome.Text = dr["pes_nome"].ToString();
                txRua.Text = dr["pes_rua"].ToString();
                txEmail.Text = dr["pes_email"].ToString();
                txTelefone.Text = dr["pes_telefone"].ToString();
                if (dr["fun_nivel"].ToString().Equals("Funcionário"))
                    cmbFuncao.SelectedIndex = 0;
                else
                    cmbFuncao.SelectedIndex = 1;
                txLogin.Text = dr["fun_login"].ToString();
                txSenha.Text = dr["fun_senha"].ToString();
      
              
                



            }
            else
            {

                limpaTela();
                estadoInicial();
            }
        }
        public void MascaratxtNumericoDOUBLE(KeyPressEventArgs e, TextBox txtCampo)
        {
            decimal dAux;
            string sCampo = txtCampo.Text + e.KeyChar;
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                try
                {
                    dAux = Convert.ToDecimal(sCampo);
                    e.Handled = false;
                }
                catch { }
            }
            else
            {
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }
        public void MascaratxtNumericoINT(KeyPressEventArgs e, TextBox txtCampo)
        {
            decimal dAux;
            string sCampo = txtCampo.Text + e.KeyChar;
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) )
            {
                try
                {
                    dAux = Convert.ToDecimal(sCampo);
                    e.Handled = false;
                }
                catch { }
            }
            else
            {
                if (e.KeyChar == (char)8)
                    e.Handled = false;
            }
        }
        private void txNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoINT(e, txNumero);
        }

        private void txSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txNumero);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a exclusão?", "Confirmação de exclusão",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                            == DialogResult.Yes)
            {
                if (dalFun.deletaFuncionarioCOD(Convert.ToInt32(txCodigo.Text)) )
                    MessageBox.Show("O funcionário foi excluído do sistema com sucesso!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Ocorreu um erro durante a exclusão, por favor leia o Manual ou contate o desenvolvedor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            limpaTela();
            estadoInicial();
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (radio3.Checked)
                label10.Visible = false;
            else
                label10.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (btnNovo.Enabled)
                Close();
            else
            {
                limpaTela();
                estadoInicial();
                
            }
        }
    }
}

using DogSoft.Controladora;
using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Visao
{
    public partial class GerenciarFornecedor : Form
    {
        bool alterando = false;
        DALEstado dale;
        DALCidade dalc;
        Color cor = Color.Black;
        int cepvalida = 0;
        public GerenciarFornecedor()
        {

            InitializeComponent();
            //carregaParametrizacao();
            mudaEstado(0);
            dale = DALEstado.novaInstancia();
            dalc = DALCidade.novaInstancia();
            cmbEstado.DisplayMember = "est_sgl";
            cmbEstado.ValueMember = "est_cod";
            cmbEstado.DataSource = dale.buscarTodos();
            carregaParametrizacao();
        }
        private bool validacampos()
        {

            lbBairro.ForeColor = cor;
            lbCep.ForeColor = cor;
            lbCNPJ.ForeColor = cor;
            lbComplemento.ForeColor = cor;
            lbEmail.ForeColor = cor;
            lbNome.ForeColor = cor;
            lbNomeFantasia.ForeColor = cor;
            lbNumero.ForeColor = cor;
            lbRazao.ForeColor = cor;
            lbRua.ForeColor = cor;
            lbTelefone.ForeColor = cor;
            carregaParametrizacao();
            bool res = true;
            if (txBairro.Text.Length == 0)
            {
                lbBairro.ForeColor = Color.Red;
                res = false;
            }
            if (txCEP.MaskCompleted == false)
            {
                lbCep.ForeColor = Color.Red;
                res = false;
            }
            if (txCNPJ.MaskCompleted == false)
            {
                lbCNPJ.ForeColor = Color.Red;
                res = false;
            }
            /*if (txComplemento.Text.Length == 0)
            {
                lbComplemento.ForeColor = Color.Red;
                res = false;
            }*/
            if (txEmail.Text.Length == 0)
            {
                lbEmail.ForeColor = Color.Red;
                res = false;
            }
            if (txNome.Text.Length == 0)
            {
                lbNome.ForeColor = Color.Red;
                res = false;
            }
            if (txNomeFantasia.Text.Length == 0)
            {
                lbNomeFantasia.ForeColor = Color.Red;
                res = false;
            }
            if (txNumero.Text.Length == 0)
            {
                lbNumero.ForeColor = Color.Red;
                res = false;
            }
            if (txRazao.Text.Length == 0)
            {
                lbRazao.ForeColor = Color.Red;
                res = false;
            }
            if (txRua.Text.Length == 0)
            {
                lbRua.ForeColor = Color.Red;
                res = false;
            }
            if (txTelefone.MaskCompleted == false)
            {
                lbTelefone.ForeColor = Color.Red;
                res = false;
            }
            if (cepvalida == 0)
            {
                MessageBox.Show("CEP INVALIDO");
                res = false;
            }

            return res;
        }
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
        public void mudaEstado(int est)
        {
            lbBairro.ForeColor = cor;
            lbCep.ForeColor = cor;
            lbCNPJ.ForeColor = cor;
            lbComplemento.ForeColor = cor;
            lbEmail.ForeColor = cor;
            lbNome.ForeColor = cor;
            lbNomeFantasia.ForeColor = cor;
            lbNumero.ForeColor = cor;
            lbRazao.ForeColor = cor;
            lbRua.ForeColor = cor;
            lbTelefone.ForeColor = cor;
            lbPRINCIPAL.ForeColor = cor;
            label1.ForeColor = cor;
            label5.ForeColor = cor;
            lbFORNECEDOR.ForeColor = cor;
            lbEstado.ForeColor = cor;

            if (est == 0)//esatdo inicial
            {
                txBairro.Enabled = false;
                txCEP.Enabled = false;
                txCNPJ.Enabled = false;
                txCodigo.Enabled = false;
                txCodigo.Visible = false;
                txComplemento.Enabled = false;
                txEmail.Enabled = false;
                txNome.Enabled = false;
                txNomeFantasia.Enabled = false;
                txNumero.Enabled = false;
                txRazao.Enabled = false;
                txRua.Enabled = false;
                txTelefone.Enabled = false;
                cmbCidade.Enabled = false;
                cmbEstado.Enabled = false;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = false;
                btnConfirmar.Enabled = false;
                btnDeletar.Enabled = false;
                btnNovo.Enabled = true;
                alterando = false;
                lbEstado.Text = "Estado Inicial";
            }
            if (est == 1)// gravando novos dados
            {
                txBairro.Enabled = true;
                txCEP.Enabled = true;
                txCNPJ.Enabled = true;
                txCodigo.Enabled = false;
                txCodigo.Visible = false;
                txComplemento.Enabled = true;
                txEmail.Enabled = true;
                txNome.Enabled = true;
                txNomeFantasia.Enabled = true;
                txNumero.Enabled = true;
                txRazao.Enabled = true;
                txRua.Enabled = true;
                txTelefone.Enabled = true;
                cmbCidade.Enabled = true;
                cmbEstado.Enabled = true;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = true;
                btnConfirmar.Enabled = true;
                btnDeletar.Enabled = false;
                btnNovo.Enabled = false;


                txBairro.Clear();
                txCEP.Clear();
                txCNPJ.Clear();
                txCodigo.Clear();
                txCodigo.Clear();
                txComplemento.Clear();
                txEmail.Clear();
                txNome.Clear();
                txNomeFantasia.Clear();
                txNumero.Clear();
                txRazao.Clear();
                txRua.Clear();
                txTelefone.Clear();

                alterando = false;
                lbEstado.Text = "Gravando";
            }
            if (est == 2)// alterando/deletando dados
            {
                txBairro.Enabled = true;
                txCEP.Enabled = true;
                txCNPJ.Enabled = true;
                txCodigo.Enabled = false;
                txCodigo.Visible = true;
                txComplemento.Enabled = true;
                txEmail.Enabled = true;
                txNome.Enabled = true;
                txNomeFantasia.Enabled = true;
                txNumero.Enabled = true;
                txRazao.Enabled = true;
                txRua.Enabled = true;
                txTelefone.Enabled = true;
                cmbCidade.Enabled = true;
                cmbEstado.Enabled = true;
                btnBuscar.Enabled = true;
                btnCancelar.Enabled = true;
                btnConfirmar.Enabled = true;
                btnDeletar.Enabled = true;
                btnNovo.Enabled = false;
                alterando = true;
                lbEstado.Text = "Alterando|Deletando";
            }
        }





        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            Cidade cid;
            BuscarFornecedor b = new BuscarFornecedor();
            b.ShowDialog();
            DataRow dr;
            dr = b.getSelecionado();
            if (dr != null)
            {
                txBairro.Text = dr["pes_bairro"].ToString();
                txCEP.Text = dr["pes_cep"].ToString();
                txCNPJ.Text = dr["for_cnpj"].ToString();
                txCodigo.Text = dr["pes_cod"].ToString();
                txComplemento.Text = dr["pes_complemento"].ToString();
                txEmail.Text = dr["pes_email"].ToString();
                txNome.Text = dr["pes_nome"].ToString();
                txNomeFantasia.Text = dr["for_nomeFantasia"].ToString();
                txNumero.Text = dr["pes_num"].ToString();
                txRazao.Text = dr["for_razaoSocial"].ToString();
                txRua.Text = dr["pes_rua"].ToString();
                txTelefone.Text = dr["pes_telefone"].ToString();
                string aux = dr["cid_cod"].ToString();

                cid = (Cidade)dalc.buscarCid(Convert.ToInt32(aux));
                //MessageBox.Show(cid.getEstado().getSigla());
                int index = cmbEstado.FindString(cid.getEstado().getSigla());
                cmbEstado.SelectedIndex = index;
                index = cmbCidade.FindString(cid.getNome());
                cmbCidade.SelectedIndex = index;
                mudaEstado(2);
            }
        }

        private void txNumero_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }


        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            DalFornecedor dalf = DalFornecedor.novaInstancia();
            var result = MessageBox.Show("Tem certeza que deseja excluir o fornecedor?", "exclusão fornecedor", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dalf.deletar(Convert.ToInt32(txCodigo.Text)))
                {
                    MessageBox.Show("Fornecedor excluido com sucesso");
                }
                else
                    MessageBox.Show("Erro ao excluir Fornecedor");
            }
           

            mudaEstado(0);
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            mudaEstado(1);
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            mudaEstado(0);
        }


        private void txCEP_Leave_1(object sender, EventArgs e)
        {
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txCEP.Text);
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
            cepvalida = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            txBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            txRua.Text = ds.Tables[0].Rows[0][6].ToString();
            int index = cmbEstado.FindString(ds.Tables[0].Rows[0][2].ToString());
            cmbEstado.SelectedIndex = index;
            index = cmbCidade.FindString(ds.Tables[0].Rows[0][3].ToString());
            cmbCidade.SelectedIndex = index;
        }

        private void cmbEstado_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCidade.ValueMember = "cid_cod";
            cmbCidade.DisplayMember = "cid_nome";
            cmbCidade.DataSource = dalc.buscarALL(Int32.Parse(cmbEstado.SelectedValue.ToString()));
        }

        public bool IsCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",", "");

            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }
        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txCEP.Text);
            DataSet ds = new DataSet();
            ds.ReadXml(xml);
            DalFornecedor dalf = DalFornecedor.novaInstancia();
            if (validacampos())
            {
                //MessageBox.Show(cmbCidade.SelectedValue.ToString());
                if (ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    if (IsCnpj(txCNPJ.Text))
                    {
                        if (!alterando)
                        {
                            if (dalf.salvar(txNomeFantasia.Text, txRazao.Text, txCNPJ.Text, txCEP.Text, txBairro.Text, txEmail.Text, txTelefone.Text, txRua.Text, txNome.Text, Convert.ToInt32(txNumero.Text), txComplemento.Text, Convert.ToInt32(cmbCidade.SelectedValue)))
                            {
                                MessageBox.Show("Cadastrado com sucesso");
                                mudaEstado(0);
                            }
                            else
                                MessageBox.Show("ERRO AO CADASTRAR NO BANCO");
                        }
                        else
                        {
                            if (dalf.alterar(txNomeFantasia.Text, txRazao.Text, txCNPJ.Text, txCEP.Text, txBairro.Text, txEmail.Text, txTelefone.Text, txRua.Text, txNome.Text, Convert.ToInt32(txNumero.Text), txComplemento.Text, Convert.ToInt32(cmbCidade.SelectedValue), Convert.ToInt32(txCodigo.Text)))
                            {
                                MessageBox.Show("Alterado com sucesso");
                                mudaEstado(0);
                            }
                            else
                                MessageBox.Show("ERRO AO ALTERAR NO BANCO");
                        }

                    }
                    else
                        MessageBox.Show("CNPJ INVALIDO");

                }
                else
                    MessageBox.Show("CEP INVALIDO");

            }
            else
                MessageBox.Show("todos os campos obrigatorios devem ser preenchidos");
        }

        private void GerenciarFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}

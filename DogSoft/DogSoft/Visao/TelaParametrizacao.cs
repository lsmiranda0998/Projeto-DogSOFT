using DogSoft.Controladora;
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
    public partial class TelaParametrizacao : Form
    {
  
        Color cor;
        Color corFundo;
        Color corFonte;
        DalParametrizacao dalp;
        DataTable dt;
        bool confirma = false;
        public TelaParametrizacao()
        {
            InitializeComponent();
            dt = new DataTable();
            cmbFonte.SelectedIndex = 0;
            dalp = DalParametrizacao.novaInstancia();

            if (!dalp.primeiroAcesso())
            {
                confirma = true;
                carrega();
                //MessageBox.Show("NOT PRIMEIRO ACESSO");
                //carregaParametrizacao();
               
            }
            else
            {
                corFundo = Color.Gray;
                corFonte = Color.Black;
                pbFundo.BackColor = corFundo;
                pbFonte.BackColor = corFonte;
            }
            //MessageBox.Show(pbFonte.BackColor.Name);

        }

        private void carrega()
        {
            DalParametrizacao dalp = DalParametrizacao.novaInstancia();
            DataTable dt = dalp.carrega();
            DataRow dr = dt.Rows[0];


            this.BackColor = Color.FromName(dr["prm_corFundo"].ToString());

            cor = Color.FromName(dr["prm_corFonte"].ToString());
            
            Font font = new Font(dr["prm_fonte"].ToString(), Convert.ToInt32(dr["prm_size"])); this.Font = font;
            this.ForeColor = cor;
            if (dr != null)
            {
                tbNome.Text = dr["prm_nomeFantasia"].ToString();
                txTelefone.Text = dr["prm_telefone"].ToString();
                tbCodigo.Text = dr["prm_cod"].ToString();
                tbSite.Text = dr["prm_site"].ToString();
                tbEmail.Text = dr["prm_email"].ToString();
                txBairro.Text = dr["prm_bairro"].ToString();
                txNumero.Text = dr["prm_num"].ToString();
                txRua.Text = dr["prm_rua"].ToString();
                tbSize.Text = dr["prm_size"].ToString();
                tbRazao.Text = dr["prm_razaoSocial"].ToString();
                cmbFonte.SelectedItem = dr["prm_fonte"].ToString();
               
                //this.Font = new Font(dr["prm_fonte"].ToString(), 8);
                corFundo = Color.FromName(dr["prm_corFundo"].ToString());
                corFonte = Color.FromName(dr["prm_corFonte"].ToString());
                pbFonte.BackColor = corFonte;
                pbFundo.BackColor = corFundo;
                pbLogo1.ImageLocation = dr["prm_logo1"].ToString();
                pbLogo2.ImageLocation = dr["prm_logo2"].ToString();
            }
        }


        private bool validacampos()
        {

            lbnome.ForeColor = cor;
            lbSite.ForeColor = cor;
            lbTelefone.ForeColor = cor;
            groupBox4.ForeColor = cor;
            groupBox5.ForeColor = cor;
            lbRazao.ForeColor = cor;
            lbRua.ForeColor = cor;
            lbBairro.ForeColor = cor;
            lbNumero.ForeColor = cor;
            lbsize.ForeColor = cor;
            lbEmail.ForeColor = cor;
            bool res = true;
            if (tbNome.Text.Length == 0)
            {
                lbnome.ForeColor = Color.Red;
                res = false;
            }
            if (tbSite.Text.Length == 0)
            {
                lbSite.ForeColor = Color.Red;
                res = false;
            }
            if (txTelefone.MaskCompleted == false)
            {
                lbTelefone.ForeColor = Color.Red;
                res = false;
            }
            if (tbRazao.Text.Length == 0)
            {
                lbRazao.ForeColor = Color.Red;
                res = false;
            }
            if (txRua.Text.Length == 0)
            {
                lbRua.ForeColor = Color.Red;
                res = false;
            }
            if (txBairro.Text.Length == 0)
            {
                lbBairro.ForeColor = Color.Red;
                res = false;
            }
            if (txNumero.Text.Length == 0)
            {
                lbNumero.ForeColor = Color.Red;
                res = false;
            }
            if (tbSize.Text.Length == 0)
            {
                lbsize.ForeColor = Color.Red;
                res = false;
            }
            if (tbEmail.Text.Length == 0)
            {
                lbEmail.ForeColor = Color.Red;
                res = false;
            }
            if(pbLogo1.Image==null)
            {
                groupBox4.ForeColor= Color.Red;
                res = false;
            }
            if(pbLogo2.Image==null)
            {
                groupBox5.ForeColor= Color.Red;
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
            //Color.
            /*label1.ForeColor = cor;
            label2.ForeColor = cor;
            label3.ForeColor = cor;
            label4.ForeColor = cor;
            label5.ForeColor = cor;*/
            Font font = new Font(dr["prm_fonte"].ToString(), Convert.ToInt32(dr["prm_size"])); this.Font = font;
            this.ForeColor = cor;
        }


        private void btConfirmar_Click_1(object sender, EventArgs e)
        {
            if (validacampos())
            {
                if (dalp.primeiroAcesso())
                {
                    
                     
                    if (dalp.salvar(Convert.ToInt32(tbSize.Text), Convert.ToInt32(txNumero.Text), cmbFonte.SelectedItem.ToString(), corFonte.Name, corFundo.Name, tbNome.Text, tbSite.Text, txTelefone.Text, tbEmail.Text, txBairro.Text, txRua.Text, tbRazao.Text, pbLogo1.ImageLocation, pbLogo2.ImageLocation))
                    {
                        MessageBox.Show("Cadastrado com sucesso");
                        confirma = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("erro ao cadastrar");
                }
                else
                {
                   
                    //MessageBox.Show(pbLogo1.ImageLocation);
                    if (dalp.alterar(Convert.ToInt32(tbSize.Text), Convert.ToInt32(txNumero.Text), cmbFonte.SelectedItem.ToString(), corFonte.Name, corFundo.Name, tbNome.Text, tbSite.Text, txTelefone.Text, tbEmail.Text, txBairro.Text, txRua.Text, tbRazao.Text, pbLogo1.ImageLocation, pbLogo2.ImageLocation, Convert.ToInt32(tbCodigo.Text)))
                    {
                        MessageBox.Show(corFonte.Name);
                        MessageBox.Show(corFundo.Name);
                        MessageBox.Show("alterado com sucesso");
                        confirma = true;
                        this.Close();
                    }
                    else
                        MessageBox.Show("erro ao alterar");
                }
            }
            else
                MessageBox.Show("Prencha todos os campos");
        }

        private void btCorFonte_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                corFonte = MyDialog.Color;
                pbFonte.BackColor = corFonte;

            }
        }

        private void btCorFundo_Click_1(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                corFundo = MyDialog.Color;
                pbFundo.BackColor = corFundo;
                //MessageBox.Show(corFundo.ToString());

            }
        }

        private void tbSize_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
        private void btLogo22_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo2.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btLogo11_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbLogo1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void TelaParametrizacao_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!confirma)
                e.Cancel = true;
        }

        private void txNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void TelaParametrizacao_Load(object sender, EventArgs e)
        {

        }
    }
}

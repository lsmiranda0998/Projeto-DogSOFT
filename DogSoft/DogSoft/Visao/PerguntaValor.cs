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
    public partial class PerguntaValor : Form
    {
        public ReceberConta conta;
        double val = -1;
        public PerguntaValor(ReceberConta conta)
        {
            
            InitializeComponent();
            this.conta = conta;
            carregaParametrizacao();
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
        private void PerguntaValor_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txValor);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txValor.Text = conta.Valor.ToString();
        }
        public double getValor()
        {
            return val;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            double dif;
            if (txValor.Text.Length > 0)
            {

                val = Convert.ToDouble(txValor.Text);
                if (val > Convert.ToDouble(conta.Valor))
                {
                    dif =  val - Convert.ToDouble(conta.Valor);
                    string str = dif.ToString();
                    if (MessageBox.Show("Será considerado um total de R$ "+str+" como juros, deseja mesmo prosseguir?", "Confirmacao de Juros",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        Close();
                    }
                    
                }
                else
                    Close();

            }
            else
            {
                MessageBox.Show("Insira um valor antes de confirmar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txValor.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

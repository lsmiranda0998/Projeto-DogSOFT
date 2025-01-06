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
    public partial class FormaPagamento2 : Form
    {
        private bool flag;
        static bool confirma = false;
        private DataTable dtParcela;
        private DALReceberConta dalConta;
        private DALAtendimento dalAten;
        private int codrgp;
        public FormaPagamento2(string v,int codrgp)
        {
            
            InitializeComponent();
            this.codrgp = codrgp;
            dalConta = DALReceberConta.novaInstancia();
            dalAten = DALAtendimento.novaInstancia();
            txValor.Text = v;
            dtParcela = new DataTable();
            dtParcela.Columns.Add("parcela", Type.GetType("System.Int32"));
            dtParcela.Columns.Add("valor", Type.GetType("System.Double"));
            dtParcela.Columns.Add("data", Type.GetType("System.DateTime"));
            dgvParcelas.DataSource = dtParcela;
            if (MessageBox.Show("Gerar parcelas automaticas?", "Parcelas",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes)
            {
                estadoAutomatico();

            }
            else
            {
                estadoManual();
            }
            carregaParametrizacao();
        }
        public void MascaratxtNumericoINT(KeyPressEventArgs e, TextBox txtCampo)
        {
            decimal dAux;
            string sCampo = txtCampo.Text + e.KeyChar;
            e.Handled = true;

            if (char.IsDigit(e.KeyChar))
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
        private void estadoAutomatico()
        {
            txVezes.Visible = true;
            label1.Visible = true;
            txDia.Visible = true;
            labelDia.Visible = true;
            txVezes.Enabled = true;
            labelDia.Enabled = true;
            label1.Enabled = true;
            labelValorManual.Enabled = false;
            labelData.Enabled = false;
            labelRestante.Enabled = false;
            txDia.Enabled = true;
            btnGerar.Enabled = true;
            dtpData.Enabled = false;
            txValorManual.Enabled = false;
            btnADD.Enabled = false;
            labelData.Visible = true;
            dtpData.Visible = true;
            labelValorManual.Visible = true;
            txValorManual.Visible = true;
            txRestante.Visible = true;
            labelRestante.Visible = true;
            btnGerar.Visible = true;
            btnADD.Visible = true;
            flag = true;
            dgvParcelas.AllowUserToDeleteRows = false;
            button1.Enabled = false;
        }
        private void estadoManual()
        {
            txVezes.Visible = true;
            label1.Visible = true;
            txDia.Visible = true;
            labelDia.Visible = true;
            flag = false;
            txVezes.Enabled = false;
            txDia.Enabled = false;
            btnGerar.Enabled = false;
            dtpData.Enabled = true;
            txValorManual.Enabled = true;
            btnADD.Enabled = true;
            labelData.Visible = true;
            dtpData.Visible = true;
            labelValorManual.Visible = true;
            txValorManual.Visible = true;
            txRestante.Visible = true;
            labelRestante.Visible = true;
            btnGerar.Visible = true;
            btnADD.Visible = true;
            labelDia.Enabled = false;
            label1.Enabled = false;
            labelValorManual.Enabled = true;
            labelData.Enabled = true;
            labelRestante.Enabled = true;
            txRestante.Text = txValor.Text;
            dgvParcelas.AllowUserToDeleteRows = true;
            button1.Enabled = true;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoINT(e, txDia);
        }

        private void txVezes_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoINT(e, txVezes);
        }

        private void txValorManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txValorManual);
        }

        private void txRestante_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private int cont = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvParcelas.CurrentRow != null)
            {
                int pos = dgvParcelas.CurrentRow.Index;
                double valor = Convert.ToDouble(dtParcela.Rows[pos]["valor"]);
                double rest = Convert.ToDouble(txRestante.Text);
                rest += valor;
                txRestante.Text = rest.ToString();
                dtParcela.Rows[pos].Delete();

            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            if (dtpData.Value >= DateTime.Today)
            {
                if (txValorManual.Text.Length > 0)
                {
                    if (Convert.ToDouble(txValorManual.Text) > 0)
                    {
                        if (Convert.ToDouble(txValorManual.Text) <= Convert.ToDouble(txRestante.Text))
                        {
                            DataRow dr = dtParcela.NewRow();
                            dr["parcela"] = cont++;
                            dr["valor"] = Convert.ToDouble(txValorManual.Text);
                            dr["data"] = dtpData.Value;
                            dtParcela.Rows.Add(dr);
                            double rest = Convert.ToDouble(txRestante.Text);
                            double valor = Convert.ToDouble(txValorManual.Text);
                            rest -= valor;
                            txRestante.Text = rest.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Parcela maior que o valor (escolhido) restante", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txValorManual.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel adicionar uma parcela zerada.", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txValorManual.Focus();
                    }

                }
                else
                {
                    MessageBox.Show("Digite um valor para esta parcela.", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txValorManual.Focus();
                }
            }
            else
            {

                MessageBox.Show("Selecione uma data de vencimento válida", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpData.Focus();

            }
        }
        public static bool getconfirma()
        {
            return confirma;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            DateTime dataVenc;
            bool res = true;
            if(txRestante.Text.Length==0)
            {
                if(dtParcela.Rows.Count==0)
                {
                    MessageBox.Show("Preencha as parcelas");

                }
                else
                {
                    for (int i = 0; i < dtParcela.Rows.Count; i++)
                    {
                        ReceberConta r;
                        dataVenc = Convert.ToDateTime(dtParcela.Rows[i]["data"]);
                        decimal valorParcela = Convert.ToDecimal(dtParcela.Rows[i]["valor"]);
                        string str2;
                        if (flag)
                            str2 = "Esta parcela foi gerado automaticamente";
                        else
                            str2 = "Esta parcela foi gerado manualmente";
                        r = new ReceberConta();
                        r.DataVenc = dataVenc;
                        res = dalConta.insereContaRGP(r, valorParcela, codrgp);
                        if (!res)
                        {
                            MessageBox.Show("Ocorreu algum erro ao gerar parcela mensal", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    confirma = true;
                    Close();
                }
            }
            else
            {
                if(txRestante.Text=="0")
                {
                    for (int i = 0; i < dtParcela.Rows.Count; i++)
                    {
                        ReceberConta r;
                        dataVenc = Convert.ToDateTime(dtParcela.Rows[i]["data"]);
                        decimal valorParcela = Convert.ToDecimal(dtParcela.Rows[i]["valor"]);
                        string str2;
                        if (flag)
                            str2 = "Esta parcela foi gerado automaticamente";
                        else
                            str2 = "Esta parcela foi gerado manualmente";
                        r = new ReceberConta();
                        r.DataVenc = dataVenc;
                        res = dalConta.insereContaRGP(r, valorParcela, codrgp);
                        if (!res)
                        {
                            MessageBox.Show("Ocorreu algum erro ao gerar parcela mensal", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    confirma = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("preencha todo o valor");
                }
            }
           
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DataRow dr;
            if (txValor.Text.Length > 0)
            {
                if (txVezes.Text.Length > 0)
                {
                    if (txDia.Text.Length > 0)
                    {
                        if (Convert.ToInt32(txDia.Text) < 28)
                        {
                            DateTime dataVenc;
                            for (int i = 0; i < Convert.ToInt32(txVezes.Text); i++)
                            {
                                int mes = DateTime.Now.AddMonths(i).Month;
                                int year = DateTime.Now.AddMonths(i).Year;
                                dataVenc = new DateTime(year, mes, Convert.ToInt32(txDia.Text));
                                decimal valorParcela = Convert.ToDecimal(txValor.Text) / Convert.ToInt32(txVezes.Text);
                                dr = dtParcela.NewRow();
                                dr["parcela"] = i + 1;
                                dr["valor"] = valorParcela;
                                dr["data"] = dataVenc;
                                dtParcela.Rows.Add(dr);

                            }

                        }
                        else
                            MessageBox.Show("Selecione um dia de vencimento entre 1 a 28.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                        MessageBox.Show("Informe o dia do mês para gerar a parcela.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Informe a quantidade de parcelas para serem geradas.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Informe o valor que gostaria desta conta.", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FormaPagamento2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void FormaPagamento2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!confirma)
                e.Cancel = true;
        }
    }
}

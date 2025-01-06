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
    public partial class GerenciarEntrega : Form
    {
        DataTable dt;
        DALEntrega dale;
        DALitp dali;
        DALrgp DRGP;
        Color cor;
        int erro = 0;
        public GerenciarEntrega()
        {
            InitializeComponent();
            limpar();
            dale = DALEntrega.novaInstancia();
            dali = DALitp.novaInstancia();
            DRGP = DALrgp.novaInstancia();
            carregaParametrizacao();
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
        private void GerenciarEntrega_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr;
            BuscarPedido b = new BuscarPedido();
            b.ShowDialog();
            if (b.getselecionado() != null)
            {
                dr = b.getselecionado();
                txBairro.Text = dr["pes_bairro"].ToString();
                txNomeCLi.Text = dr["pes_nome"].ToString();
                txNumero.Text = dr["pes_num"].ToString();
                txRua.Text = dr["pes_rua"].ToString();
                tbFuncionario.Text = dr["pes_nome1"].ToString();
                tbValorTot.Text = dr["rgp_valorTotal"].ToString();
                tbTroco.Text = dr["rgp_troco"].ToString();
                tbCliCod.Text = dr["rgp_cod"].ToString();
                tbfuncod.Text = dr["fun_cod"].ToString();
                tbHoraRetorno.Enabled = true;
                tbHoraSaida.Enabled = true;
                tbObs.Enabled = true;
                tbFrete.Enabled = true;
                tbTotRecebido.Enabled = true;
                dt = dali.buscaRgpCliente(Convert.ToInt32(tbCliCod.Text));
                dataGridView1.DataSource = dt;

                string aux = tbFrete.Text.Replace("R$", "");
                string aux2 = tbValorTot.Text.Replace("R$", "");
                string aux3 = tbTroco.Text.Replace("R$", "");
                Double valor2 = Convert.ToDouble(aux) + Convert.ToDouble(aux2) + Convert.ToDouble(aux3);
                tbTotal.Text = valor2.ToString("C");
            }


        }
        public void limpar()
        {
            txRua.Clear();
            txNumero.Clear();
            txBairro.Clear();
            tbTroco.Clear();
            tbCliCod.Clear();
            txNomeCLi.Clear();
            tbFrete.Text = "R$ 0,00";
            tbFuncionario.Clear();
            tbHoraRetorno.Clear();
            tbHoraSaida.Clear();
            tbObs.Clear();
            tbTotal.Text = "R$ 0,00";
            tbTotRecebido.Clear();
            tbTroco.Clear();
            tbValorTot.Clear();
            tbHoraRetorno.Enabled = false;
            tbHoraSaida.Enabled = false;
            tbObs.Enabled = false;
            tbFrete.Enabled = false;
            tbTotRecebido.Enabled = false;
        }
        public bool valida()
        {
            if (tbHoraRetorno.MaskCompleted == false || tbHoraSaida.MaskCompleted == false)
            {
                MessageBox.Show("Preancha os horarios de saida e retorno");
                return false;
            }
            DateTime d1, d2;
            d1 = Convert.ToDateTime(tbHoraSaida.Text);
            d2 = Convert.ToDateTime(tbHoraRetorno.Text);


            if (tbTotRecebido.Text.Length == 0)
            {
                MessageBox.Show("Preancha o valor total Recebido");
                return false;
            }
            if (d1 > d2)
            {
                MessageBox.Show("Horario de saida nao pode ser maior que horario de retorno");
                return false;
            }
            string aux, aux2;
            aux = tbTotal.Text.Replace("R$", "");
            aux2 = tbTotRecebido.Text.Replace("R$", "");
            if (Convert.ToDouble(aux) != Convert.ToDouble(aux2))
            {
                var result = MessageBox.Show("O Valor recebido não condiz com o valor total da entrega,deseja cadastrar mesmo assim?", "Valor não Condiz", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return false;
                }
                else
                    erro = 1;
            }
            return true;
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();


        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {

            if (valida())
            {
                string fre = tbFrete.Text.Replace("R$", "");
                string trec = tbTotRecebido.Text.Replace("R$", "");

                if (dale.salvar(Convert.ToInt32(tbCliCod.Text), Convert.ToInt32(tbfuncod.Text), Convert.ToDouble(trec), Convert.ToDouble(fre), Convert.ToDateTime(tbHoraSaida.Text), Convert.ToDateTime(tbHoraRetorno.Text),erro))
                    MessageBox.Show("Entrega confirmada");
                DRGP.deletar2(Convert.ToInt32(tbCliCod.Text));
                erro = 0;

            }
        }

        private void tbFrete_Leave(object sender, EventArgs e)
        {
            Double valor;
            if (tbFrete.Text.Length == 0)
                tbFrete.Text = "R$ 0,00";
            else
            {
                valor = Convert.ToDouble(tbFrete.Text);
                tbFrete.Text = valor.ToString("C");
            }
            string aux = tbFrete.Text.Replace("R$", "");
            string aux2 = tbValorTot.Text.Replace("R$", "");
            string aux3 = tbTroco.Text.Replace("R$", "");
            Double valor2 = Convert.ToDouble(aux) + Convert.ToDouble(aux2) + Convert.ToDouble(aux3);

            tbTotal.Text = valor2.ToString("C");
        }

        private void tbTotRecebido_Leave(object sender, EventArgs e)
        {
            Double valor;
            if (tbTotRecebido.Text.Length == 0)
                tbTotRecebido.Text = "R$ 0,00";
            else
            {
                valor = Convert.ToDouble(tbTotRecebido.Text);
                tbTotRecebido.Text = valor.ToString("C");
            }
        }

        private void tbTotRecebido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbFrete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbTotRecebido_Enter(object sender, EventArgs e)
        {
            tbTotRecebido.Clear();
        }

        private void tbFrete_Enter(object sender, EventArgs e)
        {
            tbFrete.Clear();
        }

        private void tbTot_Enter(object sender, EventArgs e)
        {

        }
    }
}

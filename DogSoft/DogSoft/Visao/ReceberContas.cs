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
    public partial class ReceberContas : Form
    {
        private DALReceberConta dalRec;
        private DALCliente dalCli;
        private DALFluxo dalFluxo;
        private DALCaixa dalCaixa;
        private DALAtendimento dalAten;
        private DataRow dtSelecionado;
        private DataTable dt;
   
        public ReceberContas()
        {
            InitializeComponent();
            dalRec = DALReceberConta.novaInstancia();
            dalCli = DALCliente.novaInstancia();
            dalFluxo = DALFluxo.novaInstancia();
            dalCaixa = DALCaixa.novaInstancia();
        
            rbIntervaloVencimento.Checked = true;
            rbPendentes.Checked = true;
            groupBox1.Enabled = false;
            txCPF.Focus();
            carregaParametrizacao();
        }

        private void rbIntervaloVencimento_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataInicio.Enabled = dtpDataFim.Enabled = rbIntervaloVencimento.Checked;
            dtpDataInicio.Value = dtpDataFim.Value = DateTime.Now;
        }

        private void rbIntervaloValores_CheckedChanged(object sender, EventArgs e)
        {
            txtValorInicial.Enabled = txtValorFinal.Enabled = rbIntervaloValores.Checked;
            txtValorInicial.Text = txtValorFinal.Text = "";
        }

        private void rbVencimento_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = rbVencidas.Enabled = rbHoje.Enabled = rbVencimento.Checked;
            rbVencidas.Checked = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cliente c;
            if (txCPF.Text.Equals("   ,   ,   -"))
                c = null;
            else
                c = dalCli.buscaClienteCPF(txCPF.Text);            
            bool flag;
            if (rbPendentes.Checked)                
                flag = true;                
            else
                flag = false;
            if (rbIntervaloVencimento.Checked)
            {

                dt = dalRec.buscaContaVENCIMENTO(c, dtpDataInicio.Value, dtpDataFim.Value,flag);
                dgvContas.DataSource = dt;
            }
            if (rbIntervaloValores.Checked)
            {
                dt = dalRec.buscaContaVALORES(c, Convert.ToDouble(txtValorInicial.Text),Convert.ToDouble(txtValorFinal.Text), flag);
                dgvContas.DataSource = dt;
            }
            if (rbVencimento.Checked)
            {
                if (rbVencidas.Checked)
                        dt = dalRec.buscaContaVENCIDAS(c, flag);
                        
                else
                    dt = dalRec.buscaContaHOJE(c, flag);
                dgvContas.DataSource = dt;

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
        private void ReceberContas_Load(object sender, EventArgs e)
        {

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

        private void txtValorInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txtValorInicial);
        }

        private void txtValorFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txtValorFinal);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            if (dgvContas.CurrentRow != null)
            {
                int pos = dgvContas.CurrentRow.Index;
                dtSelecionado = dt.Rows[pos];
                string sit = dtSelecionado["cr_situacao"].ToString();
                if (sit.Equals("BAIXADA"))
                {
                    MessageBox.Show("Esta parcela já foi baixada.", "Erro",
                           MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
    
                    Caixa cx = dalCaixa.buscaCaixaDATA(DateTime.Today);

                    if (cx == null || cx.Situacao.Equals("FECHADO"))
                    {
                        MessageBox.Show("ERRO AO ATUALIZAR CAIXA: Caixa não aberto ou inexistente para a data de hoje.", "Erro",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);                        
                    }
                    else
                    {
                        int cod = Convert.ToInt32(dtSelecionado["cr_cod"]);
                        ReceberConta conta = dalRec.buscaContaCODIGO(cod);
                        PerguntaValor tela = new PerguntaValor(conta);
                        tela.ShowDialog();
                        double val = tela.getValor();

                        if (val == -1)
                            return;
                        double dif = Convert.ToDouble(conta.Valor) - val;    
                        
                        conta.Situacao = "BAIXADA";
                        conta.ValorPago = Convert.ToDecimal(val);
                        conta.DataPago = DateTime.Now;                      
                        if (dalRec.atualizaConta(conta))
                        {
                            string msg="";
                            if (dif > 0)
                            {                              
                                if (!dalRec.insereConta(conta,Convert.ToDecimal(dif)))
                                {
                                    MessageBox.Show("Houve um erro ao gerar nova parcela. Contate o dev", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                msg = " Uma nova parcela com o valor de R$" + dif.ToString() + " foi gerada.";
                            }
                           
                            cx.adicionaValor(Convert.ToDecimal(val));                       
                            if (dalFluxo.adicionaMovimento(cx,conta))
                            {
                                MessageBox.Show("Esta parcela foi baixada com sucesso."+msg, "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dt.Clear();
                                
                            }
                                
                            else
                                MessageBox.Show("Houve um erro ao adicionar fluxo de caixa. Contate o dev", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                            MessageBox.Show("Houve um erro ao atualizar a parcela. Contate o dev", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    


                }
            }
            else
                MessageBox.Show("Seleciona uma parcela a ser baixa antes.", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
        private bool verificaData(ReceberConta conta)
        {
            DataTable dt = dalRec.buscaContaATENDIMENTO(conta.Aten.Codigo);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["cr_cod"]) != conta.Cod)
                {
                    if (dt.Rows[i]["cr_dataPagamento"] != DBNull.Value)
                    {
                        if (Convert.ToDateTime(dt.Rows[i]["cr_dataPagamento"]) > conta.DataPago)
                            return false;
                    }
                }
            }
           return true;
        }
        private ReceberConta buscaParcelaRECENTE(ReceberConta conta)
        {
            DataTable dt = dalRec.buscaContaATENDIMENTO2(conta.Aten.Codigo);
            if (dt.Rows.Count > 0)
            {
                DateTime min = Convert.ToDateTime(dt.Rows[0]["cr_dataVenc"]);
                int pos = 0;
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    if (Convert.ToInt32(dt.Rows[i]["cr_cod"]) != conta.Cod)
                    {
                        if (Convert.ToDateTime(dt.Rows[i]["cr_dataVenc"]) < min)
                        {
                            pos = i;
                            min = Convert.ToDateTime(dt.Rows[i]["cr_dataVenc"]);
                        }

                    }
                }
                ReceberConta c = dalRec.buscaContaCODIGO(Convert.ToInt32(dt.Rows[pos]["cr_cod"]));
                return c;
            }
            return null;
           
        }
        private void btnCancelarBaixa_Click(object sender, EventArgs e)
        {
            if (dgvContas.CurrentRow != null)
            {
                if (MessageBox.Show("Confirma o estorno da parcela?", "Confirmação de estorno",
                           MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                           == DialogResult.Yes)
                {

                    int pos = dgvContas.CurrentRow.Index;
                    dtSelecionado = dt.Rows[pos];
                    string sit = dtSelecionado["cr_situacao"].ToString();
                    if (sit.Equals("PENDENTE"))
                    {
                        MessageBox.Show("Esta parcela ainda não foi baixada, portanto nao é possível estornar.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        int cod = Convert.ToInt32(dtSelecionado["cr_cod"]);
                        
                        ReceberConta conta = dalRec.buscaContaCODIGO(cod);
                        if (!verificaData(conta))
                        {
                            MessageBox.Show("O estorno só é possivel com a parcela mais recente.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (conta.DataVenc < DateTime.Today)
                            {
                                MessageBox.Show("Não é possível estornar uma parcela vencida.", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            //deleta e nao atualiza
                           
                            ReceberConta p = buscaParcelaRECENTE(conta);
                            if (p == null)
                            {
                                conta.Situacao = "PENDENTE";
                                conta.DataPago = null;
                                conta.ValorPago = null;
                                if (!dalRec.atualizaConta(conta))
                                {
                                    MessageBox.Show("Ocorreu algum erro ao atualizar valor da nova parcela ao estornar", "Erro",
                                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                   
                            }
                            else
                            {
                                p.Valor += Convert.ToDecimal(conta.ValorPago);
                                if (!dalRec.atualizaConta(p))
                                {
                                    MessageBox.Show("Ocorreu algum erro ao atualizar valor da parcela ao estornar", "Erro",
                                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                            }
                            
                            if (dalRec.deletaConta(conta))
                            {
                               
     
                                Caixa cx = dalCaixa.buscaCaixaDATA(DateTime.Today);
                                if (cx == null || cx.Situacao.Equals("FECHADO"))
                                {
                                    MessageBox.Show("ERRO AO ATUALIZAR CAIXA: Caixa não aberto ou inexistente para a data de hoje.", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                                cx.reduzValor(conta.Valor);
                                if (cx.ValorAtual < 0)
                                {
                                    MessageBox.Show("ERRO AO CANCELAR BAIXA: Caixa não possui dinheiro suficiente", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    return;
                                }
                           
                                if (dalFluxo.adicionaMovimento(cx,conta))
                                {
                                    MessageBox.Show("Esta parcela teve sua baixa cancelada.", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    dt.Clear();
                                }
                                    
                                else
                                    MessageBox.Show("Houve um erro ao adicionar fluxo de caixa. Contate o dev", "Erro",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                                MessageBox.Show("Houve um erro ao deletar a parcela. Contate o dev", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                      
                    }

                }
            }
            else
                MessageBox.Show("Seleciona uma parcela antes.", "Erro",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dt.Clear();
            txCPF.Clear();
            txCPF.Focus();
        }
    }
}

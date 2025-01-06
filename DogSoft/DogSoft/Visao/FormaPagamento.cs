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
    public partial class FormaPagamento : Form
    {
        private Atendimento a;
        private formaPagamento forma;
        private DALFormaPagamento dalForma;
        private DALReceberConta dalConta;
        private DALAtendimento dalAten;
        private DALCaixa dalCaixa;
        private DALFluxo dalFluxo;
        private DALMesa dalMesa;
        private DataTable dtParcela;
        private bool status;
        private bool flag;
        public FormaPagamento(Atendimento a)
        {
            InitializeComponent();
            this.a = a;
            radioButton4.Checked = true;
            radioButton1.Checked = true;
            dalForma = DALFormaPagamento.novaInstancia();
            dalConta = DALReceberConta.novaInstancia();
            dalAten = DALAtendimento.novaInstancia();
            dalCaixa = DALCaixa.novaInstancia();
            dalFluxo = DALFluxo.novaInstancia();
            dalMesa = DALMesa.novaInstancia();
            status = false;
            dtParcela = new DataTable();
            dtParcela.Columns.Add("parcela", Type.GetType("System.Int32"));
            dtParcela.Columns.Add("valor", Type.GetType("System.Double"));
            dtParcela.Columns.Add("data", Type.GetType("System.DateTime"));
            dgvParcelas.DataSource = dtParcela;
            carregaParametrizacao();
        }
        public bool getStatus()
        {
            return status;
        }
        private void FormaPagamento_Load(object sender, EventArgs e)
        {
            labelTOTAL.Text = "Valor Restante: R$ " + a.ValorFinal.ToString();
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

        private void btnTUDO_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txValor);
        }

        private void btnTUDO_Click(object sender, EventArgs e)
        {
            txValor.Text = a.ValorFinal.ToString();
        }
        private void desabilita()
        {
            //tx
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
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                txVezes.Visible = false;
                label1.Visible = false;
                txDia.Visible = false;
                labelDia.Visible = false;
                labelData.Visible = false;
                dtpData.Visible = false;
                labelValorManual.Visible = false;
                txValorManual.Visible = false;
                txRestante.Visible = false;
                labelRestante.Visible = false;
                btnGerar.Visible = false;
                btnADD.Visible = false;
                txValorManual.Enabled = false;

            }


        }
        private ReceberConta buscaPENDENTE(DataTable dt)
        {
            foreach (DataRow lin in dt.Rows)
            {
                if (lin["cr_situacao"].ToString().Equals("PENDENTE"))
                {
                    return dalConta.buscaContaCODIGO(Convert.ToInt32(lin["cr_cod"]));
                }
            }
            return null;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txValorManual.Enabled)
            {
                if (Convert.ToDouble(txRestante.Text) > 0)
                {
                    MessageBox.Show("Adicione parcelas até que preencha o valor (escolhido) restante", "Erro",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            if (radioButton1.Checked)//din
            {
                forma = dalForma.buscaFormaCODIGO(1);
            }
            if (radioButton2.Checked)//cred
            {
                forma = dalForma.buscaFormaCODIGO(2);
            }
            if (radioButton5.Checked)//deb
            {
                forma = dalForma.buscaFormaCODIGO(3);
            }
            a.Forma = forma;

            if (txValor.Text.Length > 0)
            {
                decimal dif = a.ValorFinal - Convert.ToDecimal(txValor.Text);
                if (dif < 0)
                {
                    decimal aux = dif * -1;
                    string str = aux.ToString();
                    if (MessageBox.Show("Será considerado um total de R$ " + str + " como juros, deseja mesmo prosseguir?", "Confirmacao de Juros",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.No)
                    {
                        return;
                    }
                }
                if (radioButton4.Checked)//a vista
                {
                    if (a.Status.Equals("FECHADO PARCIALMENTE"))
                    {
                        DataTable dt = dalConta.buscaContaATENDIMENTO(a.Codigo);
                        ReceberConta conta = buscaPENDENTE(dt);
                        if (conta == null)
                        {
                            MessageBox.Show("Ocorreu algum erro ao buscar conta pendente", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        conta.Situacao = "BAIXADA";
                        conta.Observacao = "Esta conta foi paga a vista";
                        conta.DataPago = DateTime.Now;
                        conta.DataVenc = DateTime.Today;
                        conta.ValorPago = Convert.ToDecimal(txValor.Text);
                        if (!dalConta.atualizaConta(conta))
                        {
                            MessageBox.Show("Ocorreu algum erro ao atualizar conta pendente", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        if (dalConta.insereContaATEN(a, "Esta conta foi paga a vista", "BAIXADA", DateTime.Now, DateTime.Today, Convert.ToDecimal(txValor.Text), 0))
                        {
                            Caixa cx = dalCaixa.buscaCaixaDATA(DateTime.Today);
                            if (cx == null || cx.Situacao.Equals("FECHADO"))
                            {
                                MessageBox.Show("ERRO AO ATUALIZAR CAIXA: Caixa não aberto ou inexistente para a data de hoje.", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            cx.adicionaValor(Convert.ToDecimal(txValor.Text));
                            if (dalFluxo.adicionaMovimentoACRESCIMO(cx, Convert.ToDecimal(txValor.Text)))
                            {
                                /*MessageBox.Show("Esta parcela foi baixada com sucesso." , "Sucesso",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);*/

                            }

                            else
                                MessageBox.Show("Houve um erro ao adicionar fluxo de caixa. Contate o dev", "Erro",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                        else
                        {
                            MessageBox.Show("Ocorreu algum erro ao inserir conta com saldo devedor", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    if (dif > 0)
                    {
                        if (!dalConta.insereContaATEN(a, "Esta foi gerada automaticamente com o saldo devedor", "PENDENTE", null, DateTime.Today.AddMonths(1), dif, 0))
                        {
                            MessageBox.Show("Ocorreu algum erro ao gerar parcela com a diferença a vista", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    if (dif <= 0)
                        a.ValorFinal = 0;
                    else
                        a.ValorFinal = dif;
                    if (a.ValorFinal == 0)
                    {
                        a.Status = "FECHADO";
                        a.Mesa.setStatus("Disponivel");
                    }

                    if (a.ValorFinal > 0)
                        a.Status = "FECHADO PARCIALMENTE";
                    if (dalAten.atualizaAtendimento(a))
                    {
                        if (dalMesa.atualizaMesa(a.Mesa))
                        {
                            if (a.Status.Equals("FECHADO"))
                                MessageBox.Show("Esta mesa foi fechada com êxito", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Esta mesa foi fechada parcialmente.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            status = true;
                            Close();
                        }
                        else
                            MessageBox.Show("Ocorreu algum erro ao atualizar mesa.", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                        MessageBox.Show("Ocorreu algum erro ao atualizar atendimento a vista", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (dif > 0)
                    {
                        if (!dalConta.insereContaATEN(a, "Esta foi gerada automaticamente com o saldo devedor", "PENDENTE", null, DateTime.Today.AddMonths(1), dif, 0))
                        {
                            MessageBox.Show("Ocorreu algum erro ao gerar parcela com a diferença parcelado", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    DateTime dataVenc;
                    bool res = true;
                    for (int i = 0; i < dtParcela.Rows.Count; i++)
                    {
                        dataVenc = Convert.ToDateTime(dtParcela.Rows[i]["data"]);
                        decimal valorParcela = Convert.ToDecimal(dtParcela.Rows[i]["valor"]);
                        string str2;
                        if (flag)
                            str2 = "Esta parcela foi gerado automaticamente";
                        else
                            str2 = "Esta parcela foi gerado manualmente";
                        res &= dalConta.insereContaATEN(a, str2, "PENDENTE", null, dataVenc, 0, valorParcela);
                        if (!res)
                        {
                            MessageBox.Show("Ocorreu algum erro ao gerar parcela mensal", "Erro",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                    }
                    if (dif <= 0)
                        a.ValorFinal = 0;
                    else
                        a.ValorFinal = dif;
                    if (a.ValorFinal == 0)
                    {
                        a.Status = "FECHADO";
                        a.Mesa.setStatus("Disponivel");
                    }
                        
                    if (a.ValorFinal > 0)
                        a.Status = "FECHADO PARCIALMENTE";
                    if (dalAten.atualizaAtendimento(a))
                    {
                        if (dalMesa.atualizaMesa(a.Mesa))
                        {
                            if (a.Status.Equals("FECHADO"))
                                MessageBox.Show("Esta mesa foi fechada com êxito", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            else
                                MessageBox.Show("Esta mesa foi fechada parcialmente.", "Sucesso",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            status = true;
                            Close();
                        }
                        else
                            MessageBox.Show("Ocorreu algum erro ao atualizar mesa.", "Erro",
                                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Ocorreu algum erro ao atualizar atendimento parcelado", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cont = 1;
            }


        }
    
            
         
            

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txDia_KeyPress(object sender, KeyPressEventArgs e)
        {
           MascaratxtNumericoINT(e, txDia);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txValor);
        }

        private void txVezes_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoINT(e, txVezes);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                if (txValor.Text.Length <= 0)
                {
                    MessageBox.Show("Digite o quanto gostaria de pagar desta conta.", "Erro",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txValor.Focus();
                    radioButton4.Checked = true;
                    return;
                }
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
            }
        }
        private int cont = 1;
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
                                dr["parcela"] = i+1;
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

        private void txValorManual_KeyPress(object sender, KeyPressEventArgs e)
        {
            MascaratxtNumericoDOUBLE(e, txValorManual);
        }

        private void txRestante_KeyPress(object sender, KeyPressEventArgs e)
        {
             
        }

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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txVezes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

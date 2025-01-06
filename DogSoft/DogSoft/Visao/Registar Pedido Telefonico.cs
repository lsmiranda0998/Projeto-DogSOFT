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
    public partial class Registar_Pedido_Telefonico : Form
    {
        Funcionario f;
        DALCidade dalc;
        DALEstado dale;
        DALProduto dalp;
        DALrgp dalrgp;
        DALitp itp;
        DataTable dt;
        DALitp dali;
        Color cor;
        public Registar_Pedido_Telefonico()
        {

            InitializeComponent();
             itp = DALitp.novaInstancia();
            dale = DALEstado.novaInstancia();
            dalc = DALCidade.novaInstancia();
            dalp = DALProduto.novaInstancia();
            dalrgp = DALrgp.novaInstancia();
            cmbEstado.DisplayMember = "est_sgl";
            cmbEstado.ValueMember = "est_cod";
            cmbEstado.DataSource = dale.buscarTodos();
            cmbProduto.DisplayMember = "pro_descricao";
            cmbProduto.ValueMember = "pro_cod";
            cmbProduto.DataSource = dalp.buscaNomeFantasia("");
            tbQtde.Text = "1";
            dt = new DataTable();
            dali = DALitp.novaInstancia();
            rbDinheiro.Checked = true;
            tbTroco.Text = "R$ 0,00";
            carregaParametrizacao();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            BuscarProduto b = new BuscarProduto();
            b.ShowDialog();
            if (b.getselecionado() != 0)
            {
                cmbProduto.SelectedValue = b.getselecionado();
            }
        }
        private void btRemover_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dt.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Seleciona um produto para a exclusão ");
            }
            calculatot();

        }
        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCidade.ValueMember = "cid_cod";
            cmbCidade.DisplayMember = "cid_nome";
            cmbCidade.DataSource = dalc.buscarALL(Int32.Parse(cmbEstado.SelectedValue.ToString()));
        }

        private Boolean procuraProduto()
        {
            DataRow dr = dt.NewRow();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToInt32(dt.Rows[i]["pro_cod"]) == Convert.ToInt32(cmbProduto.SelectedValue.ToString()) && dt.Rows[i]["obs"].ToString() == tbObservacao.Text)
                {
                    /*if(Convert.ToInt32(dr["qtde"]) + Convert.ToInt32(tbQtde.Text)> Convert.ToInt32(dt.Rows[i]["pro_qtde"]))
                    {
                        MessageBox.Show("Quantidade em estoque menor do que o requisitado");
                        return true;
                    }*/
                    dr = dt.Rows[i];
                    dt.Rows[i]["qtde"] = Convert.ToInt32(dr["qtde"]) + Convert.ToInt32(tbQtde.Text);

                    return true;
                }
            }
            return false;
        }
        private void calculatot()
        {
            DataRow dr;
            double soma = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dr = dt.Rows[i];
                soma += Convert.ToDouble(dr["pro_valor"]) * Convert.ToDouble(dr["qtde"]);
            }
            tbValorTot.Text = soma.ToString();
            Double val = Convert.ToDouble(tbValorTot.Text);
            tbValorTot.Text = val.ToString("C");
        }
        private void btADD_Click(object sender, EventArgs e)
        {
            DataTable dtaux;
            DataRow dr = dt.NewRow();
            DataRow dr2;

            if (!procuraProduto())
            {
                dtaux = dalp.buscaCod(Convert.ToInt32(cmbProduto.SelectedValue.ToString()));

                dtaux.Columns.Add("qtde");
                dtaux.Columns.Add("obs");

                dr2 = dtaux.Rows[0];
                /*if(Convert.ToInt32(tbQtde.Text)> Convert.ToInt32(dr2["pro_qtde"]))
               {
                   MessageBox.Show("Quantidade em estoque menor do que o requisitado");
                   return;
               }*/


                if (dt.Rows.Count == 0)
                {

                    dr = dtaux.NewRow();
                    dtaux.Rows[0]["qtde"] = tbQtde.Text;
                    dtaux.Rows[0]["obs"] = tbObservacao.Text;
                    dt = dtaux;
                }
                else
                {
                    dr["qtde"] = tbQtde.Text;
                    dr["obs"] = tbObservacao.Text;


                    dr["pro_cod"] = dr2["pro_cod"];
                    dr["pro_descricao"] = dr2["pro_descricao"];
                    dr["pro_qtde"] = dr2["pro_qtde"];
                    dr["pro_valor"] = dr2["pro_valor"];
                    dr["pro_status"] = dr2["pro_status"];

                    dtaux.Rows.Clear();
                    dt.Rows.Add(dr);
                }


                /*if(dt==null)
                    MessageBox.Show("banana");*/

            }

            dataGridView1.DataSource = dt;
            calculatot();


            //MessageBox.Show(dr["pro_descricao"].ToString());
            /* dr["qtde"] = tbQtde.Text;
             dr["obs"] = tbObservacao.Text*/


        }
        private void txCEP_Leave(object sender, EventArgs e)
        {
            string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", txCEP.Text);
            DataSet ds = new DataSet();
            ds.ReadXml(xml);

            txBairro.Text = ds.Tables[0].Rows[0][4].ToString();
            txRua.Text = ds.Tables[0].Rows[0][6].ToString();
            int index = cmbEstado.FindString(ds.Tables[0].Rows[0][2].ToString());
            cmbEstado.SelectedIndex = index;
            index = cmbCidade.FindString(ds.Tables[0].Rows[0][3].ToString());
            cmbCidade.SelectedIndex = index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr;
            f = new Funcionario();
            ConsultaFuncionario B = new ConsultaFuncionario(f);
            B.ShowDialog();
            dr = B.getSelecionado();
            if (dr != null)
            {
                tbFunCod.Text = dr["pes_cod"].ToString();
                tbFuncionario.Text = dr["pes_nome"].ToString();
            }

        }

        private void btBuscarCli_Click(object sender, EventArgs e)
        {
            ConsultaCliente c = new ConsultaCliente();
            c.ShowDialog();

            DataRow dr;
            dr = c.getSelecionado();
            if (dr != null)
            {
                txCEP.Text = dr["pes_cep"].ToString();
                txNomeCLi.Text = dr["pes_nome"].ToString();
                txNumero.Text = dr["pes_num"].ToString();
                txBairro.Text = dr["pes_bairro"].ToString();
                txComplemento.Text = dr["pes_complemento"].ToString();
                //MessageBox.Show(dr["pes_telefone"].ToString());
                maskedTextBox1.Text = dr["pes_telefone"].ToString();
                txRua.Text = dr["pes_rua"].ToString();
                tbCliCod.Text = dr["pes_cod"].ToString();

                txCEP.Enabled = false;
                txNomeCLi.Enabled = false;
                txNumero.Enabled = false;
                txBairro.Enabled = false;
                txComplemento.Enabled = false;
                txTelefone.Enabled = false;
                txRua.Enabled = false;
                tbCliCod.Enabled = false;
            }

        }

        private void txNomeCLi_Leave(object sender, EventArgs e)
        {
            /* DALCliente dalcli=DALCliente.novaInstancia();
             Cliente c;
             if(txNomeCLi.Text.Length>0)
             {
                 c = dalcli.buscaCliente(txNomeCLi.Text);
                 if (c != null)
                 {
                     txCEP.Text = c.getCep();
                     txNomeCLi.Text = c.getNome();
                     txNumero.Text = c.getNum().ToString();
                     txBairro.Text = c.getBairro();
                     txComplemento.Text = c.getComplemento();
                     txTelefone.Text = c.getTelefone();
                     txRua.Text = c.getRua();
                     tbCliCod.Text = c.getCod().ToString();


                     txCEP.Enabled = false;
                     txNomeCLi.Enabled = false;
                     txNumero.Enabled = false;
                     txBairro.Enabled = false;
                     txComplemento.Enabled = false;
                     txTelefone.Enabled = false;
                     txRua.Enabled = false;
                     tbCliCod.Enabled = false;
                 }
             }*/

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCartao.Checked == true)
            {
                tbTroco.Enabled = false;
               // tbParcelas.Enabled = false;
                tbTroco.Clear();
                //tbParcelas.Clear();
                tbTroco.Text = "R$ 0,00";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDinheiro.Checked == true)
            {
                tbTroco.Enabled = true;
                //tbParcelas.Enabled = false;
                tbTroco.Clear();
                //tbParcelas.Clear();
                tbTroco.Text = "R$ 0,00";
            }


        }

        private void txNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbQtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void rbParcelado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbParcelado.Checked == true)
            {
                tbTroco.Enabled = false;
                //tbParcelas.Enabled = true;
                tbTroco.Clear();
                //tbParcelas.Clear();
                tbTroco.Text = "R$ 0,00";
            }
        }
        private void Registar_Pedido_Telefonico_Load(object sender, EventArgs e)
        {

        }
        private void tbParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void tbQtde_Leave(object sender, EventArgs e)
        {
            if (tbQtde.Text.Length == 0)
                tbQtde.Text = "1";
        }
        public Boolean valida()
        {
            int aux, aux2;
            lbBairro.ForeColor = cor;
            lbCep.ForeColor = cor;
            lbTelefone.ForeColor = cor;
            lbRua.ForeColor = cor;
            lbClinome.ForeColor = cor;
            lbNumero.ForeColor = cor;
            label6.ForeColor = cor;
            carregaParametrizacao();
            Boolean res = true;
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
            if (txTelefone.MaskCompleted == false)
            {
                label12.ForeColor = Color.Red;
                res = false;
            }
            if (txRua.Text.Length == 0)
            {
                label13.ForeColor = Color.Red;
                res = false;
            }
            if (txNomeCLi.Text.Length == 0)
            {
                label16.ForeColor = Color.Red;
                res = false;
            }
            if (txNumero.Text.Length == 0)
            {
                lbNumero.ForeColor = Color.Red;
                res = false;
            }
            if (tbFuncionario.Text.Length == 0)
            {
                label3.ForeColor = Color.Red;
                res = false;
            }
            if (dt.Rows.Count == 0)
            {
                res = false;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {

                if (dt.Rows[i]["pro_status"].ToString() == "venda")
                {
                    aux = Convert.ToInt32(dt.Rows[i]["qtde"]);
                    aux2 = Convert.ToInt32(dt.Rows[i]["pro_qtde"]);
                    if (aux2 < aux)
                    {
                        MessageBox.Show("Quantidade em estoque menor do que o requisitado");
                        res = false;
                    }
                }
            }

            return res;
        }
        private void btConfirmar_Click(object sender, EventArgs e)
        {
            bool res;
            int forma = 0;
            
           
            if (valida())
            {
                if (rbCartao.Checked)
                    forma = 2;
                if (rbDinheiro.Checked)
                    forma = 1;
                if (rbParcelado.Checked)
                    forma = 3;
                if (tbCliCod.Text.Length == 0)
                {

                    var result = MessageBox.Show("O cliente não esta cadastrado deseja cadastralo?", "cliente não esta cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        DALCliente dlc = DALCliente.novaInstancia();
                        res = dlc.salvar(txCEP.Text, txBairro.Text, txTelefone.Text, txRua.Text, txNomeCLi.Text, Convert.ToInt32(txNumero.Text), txComplemento.Text, Convert.ToInt32(cmbCidade.SelectedValue));
                        if (res == false)
                            MessageBox.Show("erro ao salvar o cliente");
                        else
                        {
                            res = dalrgp.salvar(dlc.getUltimo(txNomeCLi.Text), forma, Convert.ToInt32(tbFunCod.Text), Convert.ToDouble(tbTroco.Text.Replace("R$", "")), Convert.ToDouble(tbValorTot.Text.Replace("R$", "")), DateTime.Now, "");
                            if (res == false)
                                MessageBox.Show("Erro ao salvar o Pedido");
                            else
                            {
                                if (rbParcelado.Checked)
                                {
                                   
                                   
                                    FormaPagamento2 f = new FormaPagamento2(tbValorTot.Text.Replace("R$", ""), itp.buscamax());
                                    f.ShowDialog();
                                    /*if (FormaPagamento2.getconfirma())
                                        return;*/
                                }
                                MessageBox.Show("Pedido Salvo com sucesso");
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    int qtde, procod, max;
                                    String obs;

                                    qtde = Convert.ToInt32(dt.Rows[i]["qtde"]);
                                    procod = Convert.ToInt32(dt.Rows[i]["pro_cod"]);
                                    max = dali.buscamax();
                                    obs = dt.Rows[i]["obs"].ToString();
                                    Console.WriteLine(" " + qtde + " " + procod + " " + obs + " " + max);
                                    if (!dali.salvar(procod, max, obs, qtde))
                                        MessageBox.Show("erro");

                                    if (dt.Rows[i]["pro_status"].ToString() == "venda")
                                    {
                                        int tl = Convert.ToInt32(dt.Rows[i]["qtde"]);
                                        //MessageBox.Show(tl.ToString());
                                        for (int j = 0; j < tl; j++)
                                            dalp.Decrementa(Convert.ToInt32(dt.Rows[i]["pro_cod"]));
                                        cmbProduto.DataSource = dalp.buscaNomeFantasia("");
                                    }



                                }
                                limpar();
                            }

                        }

                    }


                }
                else
                {
                    res = dalrgp.salvar(Convert.ToInt32(tbCliCod.Text), forma, Convert.ToInt32(tbFunCod.Text), Convert.ToDouble(tbTroco.Text.Replace("R$", "")), Convert.ToDouble(tbValorTot.Text.Replace("R$", "")), DateTime.Now, "");
                    if (res == false)
                        MessageBox.Show("Erro ao salvar o Pedido");
                    else
                    {
                        MessageBox.Show("Pedido Salvo com sucesso");
                        if (rbParcelado.Checked)
                        {
                            FormaPagamento2 f = new FormaPagamento2(tbValorTot.Text.Replace("R$", ""), itp.buscamax());
                            f.ShowDialog();
                            /*if (FormaPagamento2.getconfirma())
                                return;**/
                        }
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            int qtde, procod, max;
                            String obs;

                            qtde = Convert.ToInt32(dt.Rows[i]["qtde"]);
                            procod = Convert.ToInt32(dt.Rows[i]["pro_cod"]);
                            max = dali.buscamax();
                            obs = dt.Rows[i]["obs"].ToString();
                            Console.WriteLine(" " + qtde + " " + procod + " " + obs + " " + max);
                            if (!dali.salvar(procod, max, obs, qtde))
                                MessageBox.Show("erro");
                            if (dt.Rows[i]["pro_status"].ToString() == "venda")
                            {
                                int tl = Convert.ToInt32(dt.Rows[i]["qtde"]);
                                //MessageBox.Show(tl.ToString());
                                for (int j = 0; j < tl; j++)
                                    dalp.Decrementa(Convert.ToInt32(dt.Rows[i]["pro_cod"]));
                                cmbProduto.DataSource = dalp.buscaNomeFantasia("");
                            }


                        }
                        limpar();

                    }

                }



            }
            else
                MessageBox.Show("Preencha os campos necessarios");


        }
        private void tbTroco_Leave(object sender, EventArgs e)
        {
            if (tbTroco.Text.Length == 0)
                tbTroco.Text = "R$ 0,00";
            else
            {
                valor = Convert.ToDouble(tbTroco.Text);
                tbTroco.Text = valor.ToString("C");
            }


        }
        public void limpar()
        {
            txBairro.Clear();
            txBairro.Enabled = true;
            txCEP.Clear();
            txCEP.Enabled = true;
            txNomeCLi.Clear();
            txNomeCLi.Enabled = true;
            dt.Clear();
            txNumero.Clear();
            txNumero.Enabled = true;
            txRua.Clear();
            txRua.Enabled = true;
            txTelefone.Clear();
            txTelefone.Enabled = true;
            txComplemento.Clear();
            txComplemento.Enabled = true;
            tbCliCod.Clear();
            tbFuncionario.Clear();
            tbFunCod.Clear();
            //tbParcelas.Clear();
            tbValorTot.Clear();
            tbTroco.Text = "R$ 0,00";
            tbObservacao.Clear();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            limpar();

        }
        Double valor;
        private void tbTroco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void tbTroco_Enter(object sender, EventArgs e)
        {
            tbTroco.Clear();
        }
        private void btCancelaP_Click(object sender, EventArgs e)
        {
            CancelaPedido c = new CancelaPedido();
            c.ShowDialog();
            cmbProduto.DataSource = dalp.buscaNomeFantasia("");
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
            lbBairro.ForeColor = cor;
            lbCep.ForeColor = cor;
            lbClinome.ForeColor = cor;
            lbComplemento.ForeColor = cor;
            lbNumero.ForeColor = cor;
            lbRua.ForeColor = cor;
            lbTelefone.ForeColor = cor;
            label1.ForeColor = cor;
            label10.ForeColor = cor;
            label11.ForeColor = cor;
            label12.ForeColor = cor;
            label13.ForeColor = cor;
            label14.ForeColor = cor;
            label15.ForeColor = cor;
            label16.ForeColor = cor;
            label2.ForeColor = cor;
            label3.ForeColor = cor;
            label4.ForeColor = cor;
            label5.ForeColor = cor;
            label6.ForeColor = cor;
            label7.ForeColor = cor;
            label8.ForeColor = cor;
            
           // this.ForeColor = cor;
        }

        private void rbDinheiro_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

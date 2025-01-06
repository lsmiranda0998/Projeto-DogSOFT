using DogSoft.Controladora;
using DogSoft.Modelo;
using DogSoft.Persistencia;
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
    public partial class RegistroAtendimento : Form
    {
        private DataTable dtMesa,dtProd,dtCombo,dtPedido;
        private DALMesa dalMesa;
        private DALProduto dalProd;
        private DALCombo dalCombo;
        private DALAtendimento dalAten;
        private DataRow dtSelecionado;
        private DALCliente dalCli;
        private Cliente cli;
        private double ValorFInal;
        private Funcionario f;
        private Atendimento a;
        public RegistroAtendimento(Funcionario f)
        {
            InitializeComponent();
            dalMesa = DALMesa.novaInstancia();
            dalProd = DALProduto.novaInstancia();
            dalCombo = DALCombo.novaInstancia();
            dalCli = DALCliente.novaInstancia();
            dalAten = DALAtendimento.novaInstancia();
            dtPedido = new DataTable();
            dtPedido.Columns.Add("Item", Type.GetType("System.String"));
            dtPedido.Columns.Add("Valor", Type.GetType("System.Double"));
            dtPedido.Columns.Add("Quantidade", Type.GetType("System.Int32"));
            dtPedido.Columns.Add("cmb_cod", Type.GetType("System.Int32"));
            dtPedido.Columns.Add("pro_cod", Type.GetType("System.Int32"));
            dgvPedido.DataSource = dtPedido;
            txValorFINAL.Text = "0";
            ValorFInal = 0;
            this.f = f;
            estadoInicial();
            carregaParametrizacao();
            
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConsultaCliente tela = new ConsultaCliente();
            tela.ShowDialog();
            DataRow dr = tela.getSelecionado();
            cli = dalCli.adicionaCliente(dr);
            if (dr != null)
            {
                txCODIGOCLI.Text = cli.getCod().ToString();
                txNome.Text = cli.getNome();
                txCPF.Text = cli.getCpf();
            }
        }
        private int buscaItem(string nome)
        {
            for (int i=0;i<dtPedido.Rows.Count;i++)
            {
                if (dtPedido.Rows[i]["Item"].ToString().Equals(nome))
                    return i;
            }
            return -1;
        }
        private int buscaItemCOD(int cod,bool flag)
        {
            for (int i = 0; i < dtPedido.Rows.Count; i++)
            {
                if (flag)
                {
                    if (Convert.ToInt32(dtPedido.Rows[i]["cmb_cod"]) == cod)
                        return i;
                }
                else
                {
                    if (Convert.ToInt32(dtPedido.Rows[i]["pro_cod"]) == cod)
                        return i;
                }                
            }
            return -1;
        }

        private void btnMaisPROD_Click(object sender, EventArgs e)
        {
            if (dgvLanche.CurrentRow != null)
            {
                int pos = dgvLanche.CurrentRow.Index;
                dtSelecionado = dtProd.Rows[pos];
                //dtLista.Rows.Add(dtSelecionado);
                string nome = dtSelecionado["pro_descricao"].ToString();
                double valor = Convert.ToDouble(dtSelecionado["pro_valor"]);
                int posItem = buscaItem(nome);
                int qtde = 1;
                if (posItem != -1)
                {
                    qtde = Convert.ToInt32(dtPedido.Rows[posItem]["Quantidade"]);
                    qtde++;
                    dtPedido.Rows[posItem]["Quantidade"] = qtde;
                }
                else
                {
                    DataRow nova = dtPedido.NewRow();
                    nova["Item"] = nome;
                    nova["Valor"] = valor;
                    nova["Quantidade"] = qtde;
                    nova["pro_cod"] = Convert.ToInt32(dtSelecionado["pro_cod"]);

                    dtPedido.Rows.Add(nova);
                }
                if (txValorFINAL.Text.Trim() == "")
                    return;
                ValorFInal = 0;
                if (txValorFINAL.Text.Length > 0)
                    ValorFInal = Convert.ToDouble(txValorFINAL.Text);               
                ValorFInal += valor;
                txValorFINAL.Text = ValorFInal.ToString();
               

            }
            else
                MessageBox.Show("Selecione um lanche antes.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private void btnMaisCMB_Click(object sender, EventArgs e)
        {
            if (dgvCombo.CurrentRow != null)
            {
                int pos = dgvCombo.CurrentRow.Index;
                dtSelecionado = dtCombo.Rows[pos];
                // dtLista.Rows.Add(dtSelecionado);
                
                
                string nome = dtSelecionado["cmb_nome"].ToString();
                int qtde = 1;
                int posItem = buscaItem(nome);
                double valor = Convert.ToDouble(dtSelecionado["cmb_valor"]);
                if (posItem != -1)
                {
                    qtde = Convert.ToInt32(dtPedido.Rows[posItem]["Quantidade"]);
                    qtde++;
                    dtPedido.Rows[posItem]["Quantidade"] = qtde;
                }
                else
                {
                    DataRow nova = dtPedido.NewRow();
                    nova["Item"] = nome;
                    nova["Valor"] = valor - Convert.ToDouble(dtSelecionado["cmb_desconto"]);
                    nova["Quantidade"] = qtde;
                    nova["cmb_cod"] = Convert.ToInt32(dtSelecionado["cmb_cod"]);
                    dtPedido.Rows.Add(nova);                     
                }
                valor -= Convert.ToDouble(dtSelecionado["cmb_desconto"]);
                ValorFInal = 0;
                if (txValorFINAL.Text.Length > 0)
                    ValorFInal = Convert.ToDouble(txValorFINAL.Text);
                ValorFInal += valor;
                txValorFINAL.Text = ValorFInal.ToString();

            }
            else
                MessageBox.Show("Selecione um combo antes.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgvMesa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCombo.CurrentRow != null)
            {
                int pos = dgvMesa.CurrentRow.Index;
                dtSelecionado = dtMesa.Rows[pos];
                txMesa.Text = dtSelecionado["mes_cod"].ToString();

            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            int cod;
           
                if (txMesa.Text.Length > 0)
                {
                    if (dtPedido.Rows.Count > 0)
                    {
                        if (txAten.Text.Trim() == "")
                        {
                            if (txNome.Text.Length > 0)
                            {
                                if (txCODIGOCLI.Text.Trim() != "")
                                {
                                    Mesa m = dalMesa.buscaMesaCODIGO(Convert.ToInt32(txMesa.Text));
                                    m.setStatus("Ocupada");
                                    if (dalMesa.atualizaMesa(m))
                                    {
                                        if (dalAten.insereAtendimento(cli, Convert.ToInt32(txMesa.Text), f, Convert.ToDecimal(txValorFINAL.Text), out cod))
                                        {
                                            if (dalAten.insereITENS(dtPedido, cod))
                                            {
                                                MessageBox.Show("A Mesa foi aberta com sucesso!", "Sucesso",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                limpaTela();
                                            }

                                            else
                                                MessageBox.Show("Ocorreu algum erro ao inserir itens do atendimento. Contate o dev", "Erro",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                        else
                                            MessageBox.Show("Ocorreu algum erro ao abrir mesa. Contate o dev", "Erro",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                        MessageBox.Show("Ocorreu algum erro ao atualizar status de mesa. Contate o dev", "Erro",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    dalCli.insereCliente(txNome.Text, txCPF.Text);
                                    Cliente cli = dalCli.buscaClienteNOME2(txNome.Text);
                                    Mesa m = dalMesa.buscaMesaCODIGO(Convert.ToInt32(txMesa.Text));
                                    m.setStatus("Ocupada");
                                    if (dalMesa.atualizaMesa(m))
                                    {
                                        if (dalAten.insereAtendimento(cli, Convert.ToInt32(txMesa.Text), f, Convert.ToDecimal(txValorFINAL.Text), out cod))
                                        {
                                            if (dalAten.insereITENS(dtPedido, cod))
                                            {
                                                MessageBox.Show("A Mesa foi aberta com sucesso!", "Sucesso",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                limpaTela();
                                            }

                                            else
                                                MessageBox.Show("Ocorreu algum erro ao inserir itens do atendimento. Contate o dev", "Erro",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }

                                        else
                                            MessageBox.Show("Ocorreu algum erro ao abrir mesa. Contate o dev", "Erro",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                        MessageBox.Show("Ocorreu algum erro ao atualizar status de mesa. Contate o dev", "Erro",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }

                            }
                            else
                            {
                                MessageBox.Show("Selecione um cliente antes.", "Erro",
                                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }    
                        }
                        else//alterando
                        {
                            if (dalAten.alteraAtendimento(cli, Convert.ToInt32(txMesa.Text), f, Convert.ToDecimal(txValorFINAL.Text), Convert.ToInt32(txAten.Text)))
                            {
                                if (dalAten.alteraITENS(dtPedido, Convert.ToInt32(txAten.Text)))
                                {
                                    MessageBox.Show("O pedido da mesa foi alterado com sucesso!", "Sucesso",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    limpaTela();
                                }
                                    
                                else
                                    MessageBox.Show("Ocorreu algum erro ao alterar itens do atendimento. Contate o dev", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }

                            else
                                MessageBox.Show("Ocorreu algum erro ao alterar mesa. Contate o dev", "Erro",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                            

                    }
                    else
                    {
                        MessageBox.Show("Seleciona algum item antes.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                   
                }
                else
                    MessageBox.Show("Selecione uma mesa antes.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
         
            
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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RegistroAtendimento_Load(object sender, EventArgs e)
        {

        }
        private void estadoInclusao()
        {
            panel1.Enabled = true;
            panel3.Enabled = true;
            btnAbrir.Enabled = true;
            btnLimpar.Enabled = true;
            btnBuscar.Enabled = true;
            btnNovo.Enabled = false;
            btnFecharMesa.Enabled = false;
            btnMenosPROD.Enabled = true;
            btnMenosCMB.Enabled = true;
            btnAbrir.Text = "Abrir Mesa";
            label9.Text = "Valor Final:";
            txValorFINAL.Text = "0";
         
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            estadoInclusao();
            dtMesa = dalMesa.buscaMesas();
            dtProd = dalProd.buscaProdutosDESC("");
            dtCombo = dalCombo.buscaComboDESC("");
            dgvMesa.DataSource = dtMesa;
            dgvLanche.DataSource = dtProd;
            dgvCombo.DataSource = dtCombo;
        }

        private void dgvMesa_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMesa.CurrentRow != null)
            {
                
                int pos = dgvMesa.CurrentRow.Index;
                dtSelecionado = dtMesa.Rows[pos];
                if (dtSelecionado["mes_status"].ToString().Equals("Ocupada"))
                {
                    MessageBox.Show("Esta mesa está ocupada.", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                    
                else
                    txMesa.Text = dtSelecionado["mes_cod"].ToString();
                label10.Visible = true;
                dgvPedido.Visible = true;
                groupBox3.Visible = true;
                groupBox5.Visible = true;
                panel6.Visible = true;
            }
        }

        private void btnMenosPROD_Click(object sender, EventArgs e)
        {
            if (dgvLanche.CurrentRow != null)
            {
                int pos = dgvLanche.CurrentRow.Index;
                dtSelecionado = dtProd.Rows[pos];
                //dtLista.Rows.Add(dtSelecionado);
                string nome = dtSelecionado["pro_descricao"].ToString();
                double valor = Convert.ToDouble(dtSelecionado["pro_valor"]);
                int posItem = buscaItem(nome);
                int qtde = 1;
                if (posItem != -1)
                {
                    qtde = Convert.ToInt32(dtPedido.Rows[posItem]["Quantidade"]);
                    qtde--;
                    if (qtde <= 0)
                    {
                        dtPedido.Rows[posItem].Delete();
                    }
                    else
                        dtPedido.Rows[posItem]["Quantidade"] = qtde;
                    ValorFInal = Convert.ToDouble(txValorFINAL.Text);
                    ValorFInal -= valor;
                    if (ValorFInal < 0)
                        ValorFInal = 0;
                    txValorFINAL.Text = ValorFInal.ToString();
                }
                else
                {
                    MessageBox.Show("Este produto não está nos pedidos.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               


            }
            else
                MessageBox.Show("Selecione um lanche antes.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnMenosCMB_Click(object sender, EventArgs e)
        {
            if (dgvCombo.CurrentRow != null)
            {
                int pos = dgvCombo.CurrentRow.Index;
                dtSelecionado = dtCombo.Rows[pos];
                // dtLista.Rows.Add(dtSelecionado);


                string nome = dtSelecionado["cmb_nome"].ToString();
                int qtde = 1;
                int posItem = buscaItem(nome);
                double valor = Convert.ToDouble(dtSelecionado["cmb_valor"]);
                if (posItem != -1)
                {
                    qtde = Convert.ToInt32(dtPedido.Rows[posItem]["Quantidade"]);
                    qtde--;
                    if (qtde <= 0)
                    {
                        dtPedido.Rows[posItem].Delete();
                    }
                    else
                        dtPedido.Rows[posItem]["Quantidade"] = qtde;
                    valor -= Convert.ToDouble(dtSelecionado["cmb_desconto"]);
                    ValorFInal = Convert.ToDouble(txValorFINAL.Text);
                    ValorFInal -= valor;
                    if (ValorFInal < 0)
                        ValorFInal = 0;
                    txValorFINAL.Text = ValorFInal.ToString();
                    
                }
                else
                {
                    MessageBox.Show("Este combo não está nos pedidos.", "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
               

            }
            else
                MessageBox.Show("Selecione um combo antes.", "Erro",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void estadoAlterar()
        {
            label9.Text = "Valor restante:";
            btnAbrir.Text = "Alterar";
            btnFecharMesa.Enabled = true;
            label10.Visible = true;
            dgvPedido.Visible = true;
            groupBox3.Visible = true;
            groupBox5.Visible = true;
            panel6.Visible = true;
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaAtendimento tela = new ConsultaAtendimento();
            tela.ShowDialog();
            DataRow dr = tela.getSelecionado();
            if (dr == null)
                return;
            estadoAlterar();
            txAten.Text = dr["aten_cod"].ToString();
            if (dr["aten_status"].ToString().Equals("FECHADO PARCIALMENTE"))
            {
                btnMenosCMB.Enabled = false;
                btnMenosPROD.Enabled = false;
            }
            else
            {
                btnMenosCMB.Enabled = true;
                btnMenosPROD.Enabled = true;
            }


            a = dalAten.buscaAtenCODIGO(Convert.ToInt32(dr["aten_cod"]));
            DataTable itens = a.buscaItens(a.Codigo);
            txMesa.Text = dr["mes_cod"].ToString();
            cli = dalCli.buscaClienteCODIGO(Convert.ToInt32(dr["cli_cod"]));
            txNome.Text = cli.getNome();
            txCPF.Text = cli.getCpf();
            Produto p;
            Combo c;
            decimal valorFinal = 0;
            foreach (DataRow lin in itens.Rows)
            {                
                DataRow nova = dtPedido.NewRow();
                if (lin["pro_cod"] != DBNull.Value)
                {
                    p = dalProd.buscaProdutosCODIGO(Convert.ToInt32(lin["pro_cod"]));
                    nova["Item"] = p.Descricao;
                    nova["pro_cod"] = Convert.ToInt32(lin["pro_cod"]);
                }
                    
                else
                {
                    nova["cmb_cod"] = Convert.ToInt32(lin["cmb_cod"]);
                    c = dalCombo.buscaComboCODIGO(Convert.ToInt32(lin["cmb_cod"]));
                    nova["Item"] = c.Nome;
                }               
                nova["Valor"] = Convert.ToDouble(lin["ita_valorUnitario"]);
                nova["Quantidade"] = Convert.ToInt32(lin["ita_qtde"]);
                
                dtPedido.Rows.Add(nova);
                valorFinal += Convert.ToDecimal(Convert.ToDecimal(lin["ita_valorUnitario"]) * Convert.ToInt32(lin["ita_qtde"]));

            }
            txValorFINAL.Text = a.ValorFinal.ToString();
             
        }

        private void dgvCombo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnFecharMesa_Click(object sender, EventArgs e)
        {
            FormaPagamento tela = new FormaPagamento(a);
            tela.ShowDialog();
            if (tela.getStatus())
                limpaTela();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpaTela();
        }

        private void estadoInicial()
        {
            label10.Visible = false;
            dgvPedido.Visible = false;
            groupBox3.Visible = false;
            groupBox5.Visible = false;
            panel6.Visible = false;
            panel1.Enabled = false;
            panel3.Enabled = false;
            btnAbrir.Enabled = false;            
            btnLimpar.Enabled = false;
            btnBuscar.Enabled = false;
            btnNovo.Enabled = true;
            btnFecharMesa.Enabled = false;
            btnAbrir.Text = "Abrir mesa";
            label9.Text = "Valor Final:";
            txValorFINAL.Text = "0";
            
        }
        private void limpaTela()
        {
            dtMesa.Clear();
            dtCombo.Clear();
            dtProd.Clear();
            estadoInicial();
            dtPedido.Clear();
            txAten.Clear();
            txCODIGOCLI.Clear();
            txCPF.Clear();
            txMesa.Clear();
            txNome.Clear();
            txValorFINAL.Clear();
        }
    }
}

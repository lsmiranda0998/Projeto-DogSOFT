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
    public partial class ConsultaCliente : Form
    {
        DataRow dtSelecionado;
        DataTable dt = new DataTable();
        DALCliente dalCli;
        int cont = 0;
        public ConsultaCliente()
        {
            InitializeComponent();
            cmpCampo.SelectedIndex = 0;
            dalCli = DALCliente.novaInstancia();
            carregaParametrizacao();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cont != 0)
                dt.Clear();
            if (cmpCampo.SelectedIndex == 0) // pesquisa por nome
                dt = dalCli.buscaClienteNOME(txCampo.Text);
            else // por cpf
                dt = dalCli.buscaClienteCPF2(txCPF.Text);
            
            dgvClientes.DataSource = dt;
           


            cont++;
        }

        private void cmpCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmpCampo.SelectedIndex == 0) // pesquisa por nome
            {
                label1.Text = "Digite o Nome:";
                txCampo.Visible = true;
                txCPF.Visible = false;
                txCampo.Focus();

            }
            else // por cpf
            {
                label1.Text = "Digite o CPF:";
                txCPF.Visible = true;
                txCampo.Visible = false;
                txCPF.Focus();


            }
        }
        public DataRow getSelecionado()
        {
            return (dtSelecionado);
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow != null)
            {
                int pos = dgvClientes.CurrentRow.Index;
                dtSelecionado = dt.Rows[pos];
                Close();
            }
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
        private void ConsultaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}

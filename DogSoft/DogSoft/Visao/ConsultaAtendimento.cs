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
    public partial class ConsultaAtendimento : Form
    {
        private DALAtendimento dalAten;
        private int cont = 0;
        private DataTable dt;
        private DataRow dr;
        public ConsultaAtendimento()
        {
            InitializeComponent();
            cmpCampo.SelectedIndex = 0;
            dalAten = DALAtendimento.novaInstancia();
            dt = new DataTable();
            carregaParametrizacao();
        }

        private void cmpCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmpCampo.SelectedIndex == 0) // pesquisa por nome
            {
                label1.Text = "Digite o nome do Cliente:";
                txCampo.Visible = true;
                dtpData.Visible = false;
                txCampo.Focus();

            }
            else // por data
            {
                label1.Text = "Digite a data do Atendimento:";
                dtpData.Visible = true;
                txCampo.Visible = false;
                dtpData.Focus();
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
        private void ConsultaAtendimento_Load(object sender, EventArgs e)
        {

        }
        public DataRow getSelecionado()
        {
            return dr;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cont != 0)
                dt.Clear();
            if (cmpCampo.SelectedIndex == 0) // pesquisa por nome
                dt = dalAten.buscaAtenCLI(txCampo.Text);
            else // por data
                dt = dalAten.buscaAtenDATA(dtpData.Value);

            dgvAtendimento.DataSource = dt;



            cont++;
        }

        private void dgvAtendimento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAtendimento.CurrentRow != null)
            {
                int pos = dgvAtendimento.CurrentRow.Index;
                dr = dt.Rows[pos];
                if (dr["aten_status"].ToString().Equals("FECHADO"))
                {
                    MessageBox.Show("Este atendimento está fechado.", "Erro",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dr = null;
                    return;
                }
                Close();
            }
        }
    }
}

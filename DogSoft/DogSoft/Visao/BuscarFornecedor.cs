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
    public partial class BuscarFornecedor : Form
    {
  
        DataTable dt = new DataTable();
        DalFornecedor dalf;
        DataRow dtSelecionado;
        public BuscarFornecedor()
        {

            InitializeComponent();
            dalf = DalFornecedor.novaInstancia();
            comboBox1.SelectedIndex = 0;
            carregaParametrizacao();
        }
        public void carregaParametrizacao()
        {
            DalParametrizacao dalp = DalParametrizacao.novaInstancia();
            DataTable dt = dalp.carrega();
            DataRow dr = dt.Rows[0];


            this.BackColor = Color.FromName(dr["prm_corFundo"].ToString());
            Color cor;
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

        public DataRow getSelecionado()
        {
            return (dtSelecionado);
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                dt = dalf.buscaNomeFantasia(txNomeFantasia.Text);
            else
                dt = dalf.buscaBairro(txNomeFantasia.Text);
            dgv.DataSource = dt;
        }

        private void BuscarFornecedor_Load_1(object sender, EventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int pos = dgv.CurrentRow.Index;
                dtSelecionado = dt.Rows[pos];
                Close();
            }
        }
    }
}

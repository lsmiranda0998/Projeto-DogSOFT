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
    public partial class BuscarProduto : Form
    {
        DataTable dt;
        DALProduto dalp;
        int selecionado = 0;
        public BuscarProduto()
        {
            InitializeComponent();
            dalp = DALProduto.novaInstancia();
            dt = dalp.buscaNomeFantasia(txCampo.Text);
            dgvUsuario.DataSource = dt;
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
        public int getselecionado()
        {
            return selecionado;
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            dt = dalp.buscaNomeFantasia(txCampo.Text);
            dgvUsuario.DataSource = dt;
        }

        private void BuscarProduto_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                int pos = dgvUsuario.CurrentRow.Index;
                selecionado = Convert.ToInt32(dt.Rows[pos]["pro_cod"]);
                Close();
            }
        }
    }
}

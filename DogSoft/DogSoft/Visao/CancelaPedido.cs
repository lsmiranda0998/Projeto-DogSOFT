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
    public partial class CancelaPedido : Form
    {
        DataTable dt;
        DALrgp dalrgp;
        public CancelaPedido()
        {
            InitializeComponent();
            dalrgp = DALrgp.novaInstancia();
            carregaParametrizacao();
        }

        private void txCampo_TextChanged(object sender, EventArgs e)
        {
            dt = dalrgp.buscaRgpCliente(txCampo.Text);
            dgvUsuario.DataSource = dt;
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            int pos = dgvUsuario.CurrentRow.Index;
            dalrgp.deletar(Convert.ToInt32(dt.Rows[pos]["rgp_cod"]));
            dt = dalrgp.buscaRgpCliente(txCampo.Text);
            dgvUsuario.DataSource = dt;
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
        private void CancelaPedido_Load_1(object sender, EventArgs e)
        {
            dt = dalrgp.buscaRgpCliente(txCampo.Text);
            dgvUsuario.DataSource = dt;
        }
    }
}

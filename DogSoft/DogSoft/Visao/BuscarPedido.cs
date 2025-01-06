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
    public partial class BuscarPedido : Form
    {
        DataTable dt;
        DALrgp dalrgp;
        DataRow dtselecionado;
        public BuscarPedido()
        {
            InitializeComponent();
            dalrgp = DALrgp.novaInstancia();
            carregaParametrizacao();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            dt = dalrgp.buscaRgpCliente(txCampo.Text);
            dgvUsuario.DataSource = dt;
        }
        public DataRow getselecionado()
        {
            return dtselecionado;
        }
        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void BuscarPedido_Load(object sender, EventArgs e)
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
        private void btConfirmar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                int pos = dgvUsuario.CurrentRow.Index;
                dtselecionado = dt.Rows[pos];
                Close();
            }
        }
    }
}

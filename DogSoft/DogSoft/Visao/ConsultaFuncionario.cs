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
    public partial class ConsultaFuncionario : Form
    {
        DALFuncionario dalFun;
        //DALUsuario dalU = new DALUsuario();

        DataTable dt = new DataTable();
        DataRow dtSelecionado;
        int cont = 0;
        Funcionario f;
        public ConsultaFuncionario(Funcionario f)
        {
            InitializeComponent();
            cmpCampo.SelectedIndex = 0;
            this.f = f;
            dalFun = DALFuncionario.novaInstancia();
            carregaParametrizacao();
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
        private void ConsultaFuncionario_Load(object sender, EventArgs e)
        {

        }
        private void ajustaData(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["fun_ativo"].ToString().Equals("1"))
                    dr["fun_ativo"] = "S";
                else
                    dr["fun_ativo"] = "N";
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cont != 0)
                dt.Clear();
            if (cmpCampo.SelectedIndex == 0) // pesquisa por nome

                dt = dalFun.buscaFuncionarioNOME(txCampo.Text);
            else // por cpf
                dt = dalFun.buscaFuncionarioCPF(txCPF.Text);
            ajustaData(dt);
            int pos = -1;
            for (int i=0;i<dt.Rows.Count;i++)
            {
                if (dt.Rows[i]["fun_login"].Equals(f.getLogin()))
                {
                    pos = i;
                    break;
                }
            }
            dgvUsuario.DataSource = dt;
            if ( pos!= -1)
            {
                CurrencyManager cm = (CurrencyManager)BindingContext[dgvUsuario.DataSource];
                //cm.EndCurrentEdit();
            
                cm.SuspendBinding();
                dgvUsuario.Rows[pos].DefaultCellStyle.ForeColor = Color.Green;
                cm.ResumeBinding();
            }
            
           
            cont++;
        }
        public DataRow getSelecionado()
        {
            return (dtSelecionado);
        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuario.CurrentRow != null)
            {
                int pos = dgvUsuario.CurrentRow.Index;
                dtSelecionado = dt.Rows[pos];
                Close();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            dt.Clear();
        }

        private void txCampo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

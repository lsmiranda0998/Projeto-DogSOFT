using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Controladora
{
    class DALEstado
    {
        private Banco banc;
        private EstadoBD bancEstado;
        private static DALEstado dal = null;
        private DALEstado()
        {

        }

        public static DALEstado novaInstancia()
        {
            if (dal == null)
                dal = new DALEstado();
            return dal;
        }
        public DataTable buscarTodos()
        {
            DataTable dtt;


            banc = Banco.conecta();

            if (banc == null)
            {
                MessageBox.Show("algo de errado");
            }
            bancEstado = new EstadoBD(banc);
            dtt = bancEstado.buscAll();
            banc.Desconecta();
            if (dtt == null)
                MessageBox.Show("algo de errado");
            return dtt;
        }

        public object buscar(int codigo)
        {
            DataTable dtt;
            Estado e = null;
            bancEstado = new EstadoBD(banc);

            banc = Banco.conecta();
            dtt = bancEstado.busc(codigo);
            if (dtt.Rows.Count > 0)
                e = new Estado(Convert.ToInt32(dtt.Rows[0]["est_cod"]), dtt.Rows[0]["est_sgl"].ToString(), dtt.Rows[0]["est_nome"].ToString());
            banc.Desconecta();
            return e;
        }
    }
}

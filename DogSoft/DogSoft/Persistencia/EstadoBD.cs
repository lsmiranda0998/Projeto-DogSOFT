using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class EstadoBD
    {
        private Banco banc = Banco.conecta();

        public EstadoBD(Banco banc)
        {
            banc = Banco.conecta();

        }

        public DataTable buscAll()
        {

            DataTable dtt;
            string sql = @"SELECT * FROM estado WHERE est_cod > @EST order by est_sgl";

            banc.ExecuteQuery(sql, out dtt, "@EST", 0);
            //MessageBox.Show(dtt.Rows[0]["est_nome"].ToString());
            return dtt;

        }

        public DataTable busc(int codigo)
        {
            DataTable dtt;
            string sql = @"SELECT * FROM estado WHERE est_cod = @EST";

            banc.ExecuteQuery(sql, out dtt, "@EST", codigo);

            return dtt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DogSoft.Modelo;
using DogSoft.Controladora;

namespace DogSoft.Persistencia
{
    class CidadeBD
    {
        private Banco banco = null;

        private DALEstado dalE;
        //private DALEstado dalE = new DALEstado();

        public CidadeBD(Banco banco)
        {
            this.banco = banco;

            dalE = DALEstado.novaInstancia();
        }
        public DataTable buscaTODOS(int estado)
        {
            string SQL;
            DataTable dt;
            SQL = @"SELECT * FROM cidade WHERE est_cod = @EST order by cid_nome";

            banco.ExecuteQuery(SQL, out dt, "@EST", estado);
            return dt;
        }
        public object buscaCidade(int cod)
        {
            string SQL;
            DataTable dt;
            Cidade cid = null;
            Estado e = null;
            SQL = @"SELECT * FROM cidade WHERE cid_cod = @CID";
            banco.ExecuteQuery(SQL, out dt, "@CID", cod);


            if (dt.Rows.Count > 0)
            {
                e = (Estado)dalE.buscar(Convert.ToInt32(dt.Rows[0]["est_cod"]));
                cid = new Cidade(Convert.ToInt32(dt.Rows[0]["cid_cod"]), dt.Rows[0]["cid_nome"].ToString(), e);
            }
            return cid;
        }
        public object buscaCidadeNOME(string nome)
        {
            string SQL;
            DataTable dt;
            Cidade cid = null;
            Estado e = null;
            SQL = @"SELECT * FROM cidade WHERE cid_nome= @CID";

            banco.ExecuteQuery(SQL, out dt, "@CID", nome);


            if (dt.Rows.Count > 0)
            {
                e = (Estado)dalE.buscar(Convert.ToInt32(dt.Rows[0]["est_cod"]));
                cid = new Cidade(Convert.ToInt32(dt.Rows[0]["cid_cod"]), dt.Rows[0]["cid_nome"].ToString(), e);
            }
            return cid;
        }

        public DataTable buscar(int codigo)
        {
            string sql;
            DataTable dtt;
            sql = @"SELECT * FROM cidade WHERE cid_cod = @CID";

            banco.ExecuteQuery(sql, out dtt, "@CID", codigo);

            return dtt;
        }

    }
}

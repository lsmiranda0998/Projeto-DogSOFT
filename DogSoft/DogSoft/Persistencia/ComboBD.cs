using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class ComboBD
    {
        private Banco banco;
        public ComboBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaComboDESC(string desc)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT cmb_cod,cmb_nome,cmb_valor,cmb_desconto FROM Combos WHERE cmb_nome LIKE @DESC";
            banco.ExecuteQuery(SQL, out dt, "@DESC", desc + "%");

            return dt;
        }
        public DataTable buscaComboCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Combos WHERE cmb_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD",cod);

            return dt;
        }
    }
}

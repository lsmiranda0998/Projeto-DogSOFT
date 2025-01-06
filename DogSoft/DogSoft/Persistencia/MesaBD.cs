using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class MesaBD
    {
        private Banco banco;
        public MesaBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaMesas()
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Mesa";
            banco.ExecuteQuery(SQL, out dt);

            return dt;
        }
        public DataTable buscaMesaCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Mesa WHERE mes_cod = @COD";
            banco.ExecuteQuery(SQL, out dt,"@COD",cod);

            return dt;
        }
        public bool atualizaMesa(Mesa m)
        {

            string SQL = @"UPDATE Mesa SET
                        mes_status = @STATUS WHERE mes_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@STATUS",m.getStatus(),"@COD", m.getCod());
        }
    }
}

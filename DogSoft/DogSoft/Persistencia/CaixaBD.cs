using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class CaixaBD
    {
        private Banco banco;
        public CaixaBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaCaixaDATA(DateTime data)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Caixa WHERE caixa_data = @DATA";
            banco.ExecuteQuery(SQL, out dt, "@DATA", data);

            return dt;
        }
        public DataTable buscaCaixaCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Caixa WHERE caixa_cod = @cod";
            banco.ExecuteQuery(SQL, out dt, "@COD",cod);

            return dt;
        }
        public bool atualizaCaixa(Caixa cx)
        {

            string SQL = @"UPDATE Caixa SET
                        caixa_valorAtual = @VALOR WHERE caixa_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@VALOR", cx.ValorAtual, "@COD", cx.Cod);
        }
    }
}

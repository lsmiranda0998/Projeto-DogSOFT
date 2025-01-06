using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class FormaPagamentoBD
    {
        private Banco banco;
        public FormaPagamentoBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaFormaCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Forma_pagamento WHERE forma_cod = @cod";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);

            return dt;
        }
    }
}

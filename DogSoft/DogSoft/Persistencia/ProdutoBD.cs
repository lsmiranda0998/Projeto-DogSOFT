using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class ProdutoBD
    {
        private Banco banco;
        public ProdutoBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaProdutosDESC(string desc)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT pro_cod,pro_descricao,pro_valor FROM Produtos WHERE pro_descricao LIKE @DESC";
            banco.ExecuteQuery(SQL, out dt,"@DESC",desc+"%");

            return dt;
        }
        public DataTable buscaProdutosCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Produtos WHERE pro_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD",cod);

            return dt;
        }
        public DataTable buscaProduto(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Produtos WHERE pro_descricao LIKE @NOME AND pro_qtde>0";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome + "%");
            return dt;
        }
        public DataTable buscaProdutoCod(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Produtos WHERE pro_cod = @NOME AND pro_qtde>0";
            banco.ExecuteQuery(SQL, out dt, "@NOME", cod);
            return dt;
        }
        public bool decrementaEstoque(int cod)
        {
            String SQL;
            SQL = "UPDATE Produtos SET pro_qtde = pro_qtde-1 WHERE pro_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod);

        }
        public bool incrementaEstoque(int cod,int inc)
        {
            String SQL;
            SQL = "UPDATE Produtos SET pro_qtde = pro_qtde+@INC WHERE pro_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod, "@INC",inc);

        }
        public string buscaprodutostatus(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT pro_status FROM Produtos WHERE pro_cod = @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", cod);
            return dt.Rows[0]["pro_status"].ToString();
        }
    }
}

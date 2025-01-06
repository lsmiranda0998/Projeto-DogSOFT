using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class itpBD
    {
        private Banco banco;
        public itpBD(Banco banco)
        {
            this.banco = banco;
        }

        public bool inserir(intens_Pedido r)
        {
            string SQL;

            SQL = @"INSERT INTO Item_Pedido (pro_cod,rgp_cod,itp_obs,itp_qtde) 
                        VALUES (@produto,@pedido,@obs,@qtde)";
            return banco.ExecuteNonQuery(SQL, "@produto", r.Pro_cod, "@pedido", r.Rgp_cod, "@obs", r.Itp_obs, "@qtde",r.Itp_qtde);

        }
        public int buscamax()
        {
            DataTable dt;
            string SQL = @"Select Max(rgp_cod) from registrar_Pedido";
            banco.ExecuteQuery(SQL, out dt);
            return Convert.ToInt32(dt.Rows[0][0]);
        }
        public DataTable busca(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT* FROM Item_Pedido i INNER JOIN Produtos p on i.pro_cod = p.pro_cod  WHERE rgp_cod = @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", cod );
            return dt;
        }
    }
}

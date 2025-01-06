using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Produto
    {
        private int cod, qtde;
        private string status, descricao;
        private decimal valor;
        private ProdutoBD bancoProd;

        public Produto()
        {
        }

        public int Cod { get => cod; set => cod = value; }
        public int Qtde { get => qtde; set => qtde = value; }
        public string Status { get => status; set => status = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public DataTable buscaProdutosDESC(string desc)
        {
            bancoProd = new ProdutoBD(Banco.conecta());
            DataTable dt = bancoProd.buscaProdutosDESC(desc);
            return dt;
        }
        public Produto buscaProdutosCODIGO(int cod)
        {
            bancoProd = new ProdutoBD(Banco.conecta());
            DataTable dt = bancoProd.buscaProdutosCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                
                descricao = dt.Rows[0]["pro_descricao"].ToString();                
                qtde = Convert.ToInt32(dt.Rows[0]["pro_qtde"]);
                status = dt.Rows[0]["pro_status"].ToString();
                cod = Convert.ToInt32(dt.Rows[0]["pro_cod"]);
                valor = Convert.ToDecimal(dt.Rows[0]["pro_valor"]);           
                
                
                return this;
            }
            return null;

        }
    }
}

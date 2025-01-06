using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class formaPagamento
    {
        private string descricao;
        private FormaPagamentoBD bancoFor;
        private int codigo;
        public string getDescricao()
        {
            return descricao;
        }
        public void setDescricao (string descricao)
        {
            this.descricao = descricao;
        }
        public int getCodigo()
        {
            return codigo;
        }
        public void setCodigO(int codigo)
        {
            this.codigo = codigo;
        }
        public formaPagamento buscaFormaCODIGO(int cod)
        {
            bancoFor = new FormaPagamentoBD(Banco.conecta());
            DataTable dt = bancoFor.buscaFormaCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                this.codigo = Convert.ToInt32(dt.Rows[0]["forma_cod"]);
                this.descricao = dt.Rows[0]["forma_descricao"].ToString();
                
                return this;
            }
            return null;

        }
    }
}

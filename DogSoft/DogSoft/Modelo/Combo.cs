using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Combo
    {
        private int codigo;
        private string nome;
        private decimal valor, desconto;
        private List<Produto> list;
        private ComboBD bancoCombo;

        public Combo()
        {
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public decimal Desconto { get => desconto; set => desconto = value; }
        internal List<Produto> List { get => list; set => list = value; }
        public DataTable buscaComboDESC(string desc)
        {
            bancoCombo = new ComboBD(Banco.conecta());
            DataTable dt = bancoCombo.buscaComboDESC(desc);
            return dt;
        }
        public Combo buscaComboCODIGO(int cod)
        {
            bancoCombo = new ComboBD(Banco.conecta());
            DataTable dt = bancoCombo.buscaComboCODIGO(cod);
            if (dt.Rows.Count > 0)
            {

                nome = dt.Rows[0]["cmb_nome"].ToString();
                codigo = Convert.ToInt32(dt.Rows[0]["cmb_cod"]);
                valor = Convert.ToDecimal(dt.Rows[0]["cmb_valor"]);
                desconto = Convert.ToDecimal(dt.Rows[0]["cmb_desconto"]);

                return this;
            }
            return null;

        }

    }
}

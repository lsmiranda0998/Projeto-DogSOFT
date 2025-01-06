using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Itens_Combo
    {
        private Combo cmb;
        private Produto prod;
        private int qtde;

        public int Qtde { get => qtde; set => qtde = value; }
        internal Combo Cmb { get => cmb; set => cmb = value; }
        internal Produto Prod { get => prod; set => prod = value; }
    }
}

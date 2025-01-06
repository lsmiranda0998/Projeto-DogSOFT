using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class FluxoCaixa
    {
        private Caixa cx;
        private int cod;
        private decimal valor;
        private string obs, tipo;
        private DateTime data;
        private FluxoCaixaBD bancoFluxo;
        public FluxoCaixa()
        {

        }

        public int Cod { get => cod; set => cod = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime Data { get => data; set => data = value; }
        internal Caixa Cx { get => cx; set => cx = value; }

        public bool adicionaMovimento(FluxoCaixa fc)
        {
            bancoFluxo = new FluxoCaixaBD(Banco.conecta());
            return bancoFluxo.adicionaMovimento(fc);
        }
    }
}

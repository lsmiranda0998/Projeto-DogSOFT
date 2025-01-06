using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Entrega
    {
        private int rgpcod, funcod, cod, erro;
        private double valorRecebido, frete;
        private DateTime saida, retorno;

        public int Rgpcod { get => rgpcod; set => rgpcod = value; }
        public int Funcod { get => funcod; set => funcod = value; }
        public int Cod { get => cod; set => cod = value; }
        public double ValorRecebido { get => valorRecebido; set => valorRecebido = value; }
        public double Frete { get => frete; set => frete = value; }
        public DateTime Saida { get => saida; set => saida = value; }
        public DateTime Retorno { get => retorno; set => retorno = value; }
        public int Erro { get => erro; set => erro = value; }

        public Entrega(int rgpcod, int funcod, int cod, double valorRecebido, double frete, DateTime saida, DateTime retorno,int erro)
        {
            this.rgpcod = rgpcod;
            this.funcod = funcod;
            this.cod = cod;
            this.valorRecebido = valorRecebido;
            this.frete = frete;
            this.saida = saida;
            this.retorno = retorno;
            this.erro = erro;
        }
        public Entrega(int rgpcod, int funcod, double valorRecebido, double frete, DateTime saida, DateTime retorno,int erro)
        {
            this.rgpcod = rgpcod;
            this.funcod = funcod;
            this.valorRecebido = valorRecebido;
            this.frete = frete;
            this.saida = saida;
            this.retorno = retorno;
            this.erro=erro;
        }
    }
}

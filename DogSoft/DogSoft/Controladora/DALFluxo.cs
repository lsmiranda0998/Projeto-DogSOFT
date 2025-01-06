using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALFluxo
    {
        private Banco banc;
        private DALCaixa dalCaixa;
        private FluxoCaixa fc;
        private DALFluxo()
        {
            dalCaixa = DALCaixa.novaInstancia();
        }
        private static DALFluxo dalFluxo = null;
        public static DALFluxo novaInstancia()
        {
            if (dalFluxo == null)
                dalFluxo = new DALFluxo();
            return dalFluxo;
        }
        public bool adicionaMovimentoACRESCIMO(Caixa cx,decimal valor)
        {
            fc = new FluxoCaixa();
            fc.Data = DateTime.Now;
            fc.Valor = valor;
            fc.Tipo = "ACRÉSCIMO";
            fc.Obs = "Atendimento";
            
            fc.Cx = cx;
            banc = Banco.conecta();//**          
            bool res = fc.adicionaMovimento(fc);
            bool res2 = dalCaixa.atualizaCaixa(fc.Cx);
            banc.Desconecta();//**
            return res && res2;
        }
        public bool adicionaMovimento(Caixa cx,ReceberConta conta)
        {
            fc = new FluxoCaixa();
            fc.Data = DateTime.Now;
            fc.Valor = conta.Valor;
            fc.Tipo = "DEDUÇÂO";
            fc.Obs = conta.Observacao;
            fc.Cx = cx;
            banc = Banco.conecta();//**          
            bool res = fc.adicionaMovimento(fc);
            bool res2 = dalCaixa.atualizaCaixa(fc.Cx);
            banc.Desconecta();//**
            return res && res2;
        }
    }
}

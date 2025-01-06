using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALCaixa
    {
        private Banco banc;
        private DALCaixa()
        {

        }
        private static DALCaixa dalCaixa = null;
        public static DALCaixa novaInstancia()
        {
            if (dalCaixa == null)
                dalCaixa = new DALCaixa();
            return dalCaixa;
        }
        public Caixa buscaCaixaDATA(DateTime data)
        {
            banc = Banco.conecta();//**       
            Caixa cx = new Caixa();
            cx = cx.buscaCaixaDATA(data);
            banc.Desconecta();//**
            return cx;
        }
        public Caixa buscaCaixaCODIGO(int cod)
        {
            banc = Banco.conecta();//**       
            Caixa cx = new Caixa();
            cx = cx.buscaCaixaCODIGO(cod);
            banc.Desconecta();//**
            return cx;
        }
        public bool atualizaCaixa(Caixa cx)
        {
            banc = Banco.conecta();//**          
          
            return cx.atualizaCaixa(cx);
            
        }
    }
}

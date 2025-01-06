using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALEntrega
    {
        private static DALEntrega dalent = null;
        private Entrega r;
        private EntregaBD rgpbd;
        private DALEntrega()
        {

        }

        public static DALEntrega novaInstancia()
        {
            if (dalent == null)
                dalent = new DALEntrega();
            return dalent;
        }
        public bool salvar(int rgpcod, int funcod, double valorRecebido, double frete, DateTime saida, DateTime retorno,int erro)
        {
            r = new Entrega(rgpcod, funcod, valorRecebido, frete, saida, retorno,erro);
            //MessageBox.Show(clicod.ToString());
            rgpbd = new EntregaBD(Banco.conecta());
            return rgpbd.inserir(r);
        }
    }
}

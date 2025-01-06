using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALFormaPagamento
    {
        private Banco banco;
        private DALFormaPagamento()
        {

        }
        private static DALFormaPagamento dalFor = null;
        public static DALFormaPagamento novaInstancia()
        {
            if (dalFor == null)
                dalFor = new DALFormaPagamento();
            return dalFor;
        }
        public formaPagamento buscaFormaCODIGO(int cod)
        {
            banco = Banco.conecta();//**       
            formaPagamento form  = new formaPagamento();
            form = form.buscaFormaCODIGO(cod);
            banco.Desconecta();//**
            return form;
        }
    }
}

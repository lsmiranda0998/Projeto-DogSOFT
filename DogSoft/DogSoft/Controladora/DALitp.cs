using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALitp
    {
        private static DALitp dali = null;
        private intens_Pedido r;
        private itpBD rgpbd;
        private DALitp()
        {

        }

        public static DALitp novaInstancia()
        {
            if (dali == null)
                dali = new DALitp();
            return dali;
        }
        public bool salvar(int pro_cod, int rgp_cod, string itp_obs, int itp_qtde)
        {
            r = new intens_Pedido(pro_cod, rgp_cod, itp_obs, itp_qtde);
            //MessageBox.Show(clicod.ToString());
            rgpbd = new itpBD(Banco.conecta());
            return rgpbd.inserir(r);
        }
        public int buscamax()
        {
            rgpbd = new itpBD(Banco.conecta());
            return rgpbd.buscamax();
        }
        public DataTable buscaRgpCliente(int cod)
        {
            DataTable dt;
            rgpbd = new itpBD(Banco.conecta());

            return rgpbd.busca(cod);

        }
    }
}

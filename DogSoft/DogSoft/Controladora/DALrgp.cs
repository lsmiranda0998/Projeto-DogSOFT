using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Controladora
{
    class DALrgp
    {
        private static DALrgp dalrgp = null;
        private Rgp r;
        private RgpBD rgpbd;
        private DALrgp()
        {
            
        }

        public static DALrgp novaInstancia()
        {
            if (dalrgp == null)
                dalrgp = new DALrgp();
            return dalrgp;
        }
       
        public bool salvar( int clicod, int forma_cod, int fun_cod, double rgp_troco, double valorTotal, DateTime dataHorario, string descricao)
        {
            r = new Rgp( clicod, forma_cod, fun_cod, rgp_troco, valorTotal, dataHorario, descricao);
            //MessageBox.Show(clicod.ToString());
            rgpbd = new RgpBD(Banco.conecta());
            return rgpbd.inserir(r);
        }
        public bool deletar(int cod)
        {
           
            //MessageBox.Show(clicod.ToString());
            rgpbd = new RgpBD(Banco.conecta());
            return rgpbd.deletar(cod);
        }
        public bool deletar2(int cod)
        {

            //MessageBox.Show(clicod.ToString());
            rgpbd = new RgpBD(Banco.conecta());
            return rgpbd.deletar2(cod);
        }
        public DataTable buscaRgpCliente(string nome)
        {
            DataTable dt;
            rgpbd = new RgpBD(Banco.conecta());
            
            return rgpbd.buscaCli(nome);

        }
    }
}

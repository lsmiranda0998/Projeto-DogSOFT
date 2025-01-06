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
    class DALCombo
    {
        private Banco banc;
        private DALCombo()
        {

        }
        private static DALCombo dalCombo = null;
        public static DALCombo novaInstancia()
        {
            if (dalCombo == null)
                dalCombo = new DALCombo();
            return dalCombo;
        }

        public DataTable buscaComboDESC(string desc)
        {
            DataTable dt = new DataTable();
            banc = Banco.conecta();
            Combo cmb = new Combo();
            dt = cmb.buscaComboDESC(desc);
            banc.Desconecta();
            return dt;

        }
        public Combo buscaComboCODIGO(int cod)
        {
            banc = Banco.conecta();//**
            Combo cmb = new Combo();
            cmb = cmb.buscaComboCODIGO(cod);
            banc.Desconecta();//**
            return cmb;
        }
    }
}

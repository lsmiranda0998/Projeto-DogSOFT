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
    class DALMesa
    {
        private Banco banc;
        private DALMesa()
        {

        }
        private static DALMesa dalMesa = null;
        public static DALMesa novaInstancia()
        {
            if (dalMesa == null)
                dalMesa = new DALMesa();
            return dalMesa;
        }
        public DataTable buscaMesas()
        {
            DataTable dt = new DataTable();
            banc = Banco.conecta();
            Mesa m = new Mesa();
            dt = m.buscaMesas();
            banc.Desconecta();
            return dt;

        }
        public Mesa buscaMesaCODIGO(int cod)
        {
            banc = Banco.conecta();//**       
            Mesa m = new Mesa();
            m = m.buscaMesaCODIGO(cod);
            banc.Desconecta();//**
            return m;
        }
        public bool atualizaMesa(Mesa m)
        {
            banc = Banco.conecta();//**          

            return m.atualizaMesa(m);

        }
    }
}

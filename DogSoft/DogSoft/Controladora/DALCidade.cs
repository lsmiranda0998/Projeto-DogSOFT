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
    class DALCidade
    {
        private Cidade cid;

        private static DALCidade dal = null;
        private DALCidade()
        {

        }

        public static DALCidade novaInstancia()
        {
            if (dal == null)
                dal = new DALCidade();
            return dal;
        }

        public DataTable buscarALL(int estado)
        {
            DataTable dtt;
            cid = new Cidade();
            Banco b = Banco.conecta();
            dtt = cid.buscaTODOS(estado);
            b.Desconecta();
            return dtt;
        }
        public object buscarCid(int cod)
        {

            Banco b = Banco.conecta();
            cid = new Cidade();
            Cidade res = (Cidade)cid.buscaCidade(cod);
            b.Desconecta();

            return res;
        }
        public object buscarCidNOME(string nome)
        {

            Banco b = Banco.conecta();
            cid = new Cidade();

            Cidade res = (Cidade)cid.buscaCidadeNOME(nome);
            b.Desconecta();

            return res;
        }

        public DataTable buscar(int codigo)
        {
            DataTable dtt;


            Banco b = Banco.conecta();
            cid = new Cidade();
            dtt = cid.buscar(codigo);
            b.Desconecta();

            return dtt;
        }
    }
}

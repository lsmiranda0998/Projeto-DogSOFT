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
    class DALAtendimento
    {
        private Banco banc;
        private DALAtendimento()
        {

        }
        private static DALAtendimento dalAten = null;
        public static DALAtendimento novaInstancia()
        {
            if (dalAten == null)
                dalAten  = new DALAtendimento();
            return dalAten;
        }
        public int getLastCOD()
        {
            Atendimento a = new Atendimento();
            return a.getLastCOD();
        }
        public bool insereAtendimento(Cliente cli, int codMesa, Funcionario f,decimal valor,out int cod)
        {

            banc = Banco.conecta();
            Atendimento a = new Atendimento();
            a.Cli = cli;
            Mesa m = new Mesa();
            a.Mesa = m.buscaMesaCODIGO(codMesa);
            a.Fun = f;
            a.Status = "EM ABERTO";
            a.ValorFinal =valor;
            a.Data = DateTime.Today;
            bool res = a.insereAtendimento(a,out cod);
            banc.Desconecta();
            return res;
        }
        public bool insereITENS(DataTable dt,int cod)
        {

            banc = Banco.conecta();
            Atendimento aten = new Atendimento();
            bool res = aten.insereITENS(dt,cod);
            banc.Desconecta();
            return res;
        }
        public bool alteraAtendimento(Cliente cli, int codMesa, Funcionario f, decimal valor,int cod)
        {

            banc = Banco.conecta();
            Atendimento a = new Atendimento();
            a.Cli = cli;
            Mesa m = new Mesa();
            a.Mesa = m.buscaMesaCODIGO(codMesa);
            a.Fun = f;
            a.Status = "EM ABERTO";
            a.ValorFinal = valor;
            a.Data = DateTime.Today;
            bool res = a.alteraAtendimento(a,cod);
            banc.Desconecta();
            return res;
        }
        public bool alteraITENS(DataTable dt, int cod)
        {

            banc = Banco.conecta();
            Atendimento aten = new Atendimento();
            bool res = aten.alteraITENS(dt, cod);
            banc.Desconecta();
            return res;
        }

        public Atendimento buscaAtenCODIGO(int cod)
        {
            banc = Banco.conecta();//**
            Atendimento aten = new Atendimento();
            aten = aten.buscaAtenCODIGO(cod);
            banc.Desconecta();//**
            return aten;
        }
        public DataTable buscaAtenCLI(string nome)
        {
           
            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            Atendimento aten = new Atendimento();
            dt = aten.buscaAtenCLI(nome);
            b.Desconecta();
            return dt;

        }
        public DataTable buscaAtenDATA(DateTime data)
        {

            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            Atendimento aten = new Atendimento();
            dt = aten.buscaAtenDATA(data);
            b.Desconecta();
            return dt;

        }
        public DataTable buscaItens(int cod)
        {

            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            Atendimento aten = new Atendimento();
            dt = aten.buscaItens(cod);
            b.Desconecta();
            return dt;

        }
        public bool atualizaAtendimento(Atendimento a)
        {
            banc = Banco.conecta();//**          

            return a.atualizaAtendimento(a);

        }
    }
}

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
    class DALReceberConta
    {
        private Banco banc;
        private ReceberConta nova;
        private DALReceberConta()
        {
            
        }
        private static DALReceberConta dalRec = null;
        public static DALReceberConta novaInstancia()
        {
            if (dalRec == null)
                dalRec = new DALReceberConta();
            return dalRec;
        }
        public DataTable buscaContaVENCIMENTO(Cliente c, DateTime dataVencINI, DateTime dataVencFINAL,bool flag)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaVENCIMENTO(c,dataVencINI,dataVencFINAL,flag);
            banc.Desconecta();//**
            return dt;
        }
        public DataTable buscaContaVALORES(Cliente c, double valorIni, double valorFinal, bool flag)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaVALORES(c, valorIni, valorFinal, flag);
            banc.Desconecta();//**
            return dt;
        }
        public DataTable buscaContaVENCIDAS(Cliente c, bool flag)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaVENCIDAS(c, flag);
            banc.Desconecta();//**
            return dt;
        }
        public DataTable buscaContaHOJE(Cliente c, bool flag)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaHOJE(c, flag);
            banc.Desconecta();//**
            return dt;
        }
        public ReceberConta buscaContaCODIGO(int cod)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            conta = conta.buscaContaCODIGO(cod);
            banc.Desconecta();//**
            return conta;
        }
        public DataTable buscaContaATENDIMENTO(int cod)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaATENDIMENTO(cod);
            banc.Desconecta();//**
            return dt;
        }
        public DataTable buscaContaATENDIMENTO2(int cod)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            DataTable dt = conta.buscaContaATENDIMENTO2(cod);
            banc.Desconecta();//**
            return dt;
        }
        public bool atualizaConta(ReceberConta co)
        {
            banc = Banco.conecta();//**
            ReceberConta conta = new ReceberConta();
            bool res = conta.atualizaConta(co);
            banc.Desconecta();//**
            return res;
        }
        public bool insereContaRGP(ReceberConta conta, decimal dif,int cod)
        {
            nova = new ReceberConta();
            nova.Valor = Convert.ToDecimal(dif);
            nova.Observacao = "Gerada automaticamenta com o saldo devedor";
            nova.DataVenc = conta.DataVenc;
            nova.Situacao = "PENDENTE";
            //nova.Aten = conta.Aten;
            Banco b = Banco.conecta();
            bool res = nova.inserirContaRGP(nova,cod);
            b.Desconecta();
            return res;
        }
        public bool insereConta(ReceberConta conta, decimal dif)
        {
            nova = new ReceberConta();
            nova.Valor = Convert.ToDecimal(dif);
            nova.Observacao = "Gerada automaticamenta com o saldo devedor";
            nova.DataVenc = conta.DataVenc;
            nova.Situacao = "PENDENTE";
            nova.Aten = conta.Aten;
            Banco b = Banco.conecta();
            bool res = nova.inserirConta(nova);
            b.Desconecta();
            return res;
        }
        //a, 0, "Esta conta foi paga a vista", "BAIXADA", DateTime.Now, DateTime.Today
        public bool insereContaATEN(Atendimento a,string obs, string sit, DateTime? dataPago, DateTime dataVenc,decimal valorPago,decimal valor)
        {
            nova = new ReceberConta();
            if (valorPago != a.ValorFinal)
            {
                
                nova.Valor = valorPago;
                nova.ValorPago = valorPago;
            }
            else
            {
                nova.Valor = a.ValorFinal;
                nova.ValorPago = valorPago;
            }
            if (valor != 0)
                nova.Valor = valor;

           
            nova.Observacao = obs;
            nova.DataPago = dataPago;
            nova.DataVenc = dataVenc;
            nova.Situacao = sit;
            nova.Aten = a;
            
            Banco b = Banco.conecta();
            bool res = nova.inserirContaATEN(nova);
            b.Desconecta();
            return res;
        }
        public bool deletaConta(ReceberConta conta)
        {
            banc = Banco.conecta();
            ReceberConta co = new ReceberConta();
            bool res = co.deletaConta(conta);
            banc.Desconecta();
            return res;
        }
    }
}

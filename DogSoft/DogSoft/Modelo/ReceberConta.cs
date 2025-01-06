using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class ReceberConta
    {
        private int cod;
        private Atendimento aten;
        //private Caixa caixa;
        private string observacao;
        private DateTime dataVenc;
        private decimal valor;
        private string situacao;
        private ReceberContaBD bancoConta;
        private decimal? valorPago;
        private DateTime? dataPago;

        public ReceberConta()
        {

        }
        public int Cod { get => cod; set => cod = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public DateTime DataVenc { get => dataVenc; set => dataVenc = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        internal Atendimento Aten { get => aten; set => aten = value; }
        //internal Caixa Caixa { get => caixa; set => caixa = value; }
        public decimal? ValorPago { get => valorPago; set => valorPago = value; }
        public DateTime? DataPago { get => dataPago; set => dataPago = value; }

        public DataTable buscaContaVENCIMENTO(Cliente c, DateTime dataVencINI, DateTime dataVencFINAL,bool flag)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaConta(c,dataVencINI,dataVencFINAL, flag);
            return dt;
        }
        public DataTable buscaContaVALORES(Cliente c,double valorIni, double valorFinal, bool flag)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaVALORES(c, valorIni, valorFinal, flag);
            return dt;
        }
        public DataTable buscaContaVENCIDAS(Cliente c, bool flag)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaVENCIDAS(c, flag);
            return dt;
        }
        public DataTable buscaContaHOJE(Cliente c, bool flag)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaHOJE(c, flag);
            return dt;
        }
        public bool atualizaConta(ReceberConta co)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            return bancoConta.atualizaConta(co);
        }
        public ReceberConta buscaContaCODIGO(int cod)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                
                situacao = dt.Rows[0]["cr_situacao"].ToString();
                this.cod = Convert.ToInt32(dt.Rows[0]["cr_cod"]);
                observacao = dt.Rows[0]["cr_observacao"].ToString();
                valor = Convert.ToDecimal(dt.Rows[0]["cr_valor"]);
                dataVenc = Convert.ToDateTime(dt.Rows[0]["cr_dataVenc"]);
                if (dt.Rows[0]["cr_dataPagamento"] != DBNull.Value)
                    dataPago = Convert.ToDateTime(dt.Rows[0]["cr_dataPagamento"]);
                if (dt.Rows[0]["cr_valorPago"] != DBNull.Value)
                    valorPago = Convert.ToDecimal(dt.Rows[0]["cr_valorPago"]);
                aten = new Atendimento();
                aten = aten.buscaAtenCODIGO(Convert.ToInt32(dt.Rows[0]["aten_cod"]));                
                return this;


            }
            return null;
        }
        public DataTable buscaContaATENDIMENTO(int cod)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaATENDIMENTO(cod);
            return dt;
        }
        public DataTable buscaContaATENDIMENTO2(int cod)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            DataTable dt = bancoConta.buscaContaATENDIMENTO2(cod);
            return dt;
        }
        public bool inserirConta(ReceberConta co)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            return bancoConta.inserirConta(co);
        }
        public bool inserirContaRGP(ReceberConta co,int cod)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            return bancoConta.inserirContaRGP(co,cod);
        }
        public bool inserirContaATEN(ReceberConta co)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            return bancoConta.inserirContaATEN(co);
        }
        public bool deletaConta(ReceberConta co)
        {
            bancoConta = new ReceberContaBD(Banco.conecta());
            return bancoConta.deletaConta(co);
        }
    }
}

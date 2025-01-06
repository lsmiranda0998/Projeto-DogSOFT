using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Caixa
    {
        private int cod;
        private DateTime data;
        private decimal valorAbertura, valorFechamento,valorAtual;
        private string situacao;
        private Funcionario funAbriu, funFechou;
        private CaixaBD bancoCaixa;
        public Caixa()
        {

        }
        public int Cod { get => cod; set => cod = value; }
        public DateTime Data { get => data; set => data = value; }
        public decimal ValorAbertura { get => valorAbertura; set => valorAbertura = value; }
        public decimal ValorFechamento { get => valorFechamento; set => valorFechamento = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public Funcionario FunAbriu { get => funAbriu; set => funAbriu = value; }
        public Funcionario FunFechou { get => funFechou; set => funFechou = value; }
        public decimal ValorAtual { get => valorAtual; set => valorAtual = value; }

        public void adicionaValor (decimal valor)
        {
            this.ValorAtual += valor;
        }
        public void reduzValor(decimal valor)
        {
            this.ValorAtual -= valor;
        }
        public Caixa buscaCaixaDATA(DateTime data)
        {
            bancoCaixa = new CaixaBD(Banco.conecta());
            DataTable dt = bancoCaixa.buscaCaixaDATA(data);
            if (dt.Rows.Count > 0)
            {
                this.cod = Convert.ToInt32(dt.Rows[0]["caixa_cod"]);
                data = Convert.ToDateTime(dt.Rows[0]["caixa_data"]);
                valorAbertura = Convert.ToDecimal(dt.Rows[0]["caixa_valorAbertura"]);
                if (dt.Rows[0]["caixa_valorFechamento"] != DBNull.Value)
                    ValorFechamento = Convert.ToDecimal(dt.Rows[0]["caixa_valorFechamento"]);
                situacao = dt.Rows[0]["caixa_situacao"].ToString();
                Funcionario f = new Funcionario();
                funAbriu = f.buscaFuncionarioCODIGO(Convert.ToInt32(dt.Rows[0]["funAbriu_cod"]));
                if (dt.Rows[0]["funFechou_cod"] != DBNull.Value)
                    FunFechou = f.buscaFuncionarioCODIGO(Convert.ToInt32(dt.Rows[0]["funFechou_cod"]));
                valorAtual = Convert.ToDecimal(dt.Rows[0]["caixa_valorAtual"]);
                return this;
            }
            return null;
        }
        public Caixa buscaCaixaCODIGO(int cod)
        {
            bancoCaixa = new CaixaBD(Banco.conecta());
            DataTable dt = bancoCaixa.buscaCaixaCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                this.cod = Convert.ToInt32(dt.Rows[0]["caixa_cod"]);
                data = Convert.ToDateTime(dt.Rows[0]["caixa_data"]);
                valorAbertura = Convert.ToDecimal(dt.Rows[0]["caixa_valorAbertura"]);
                if (dt.Rows[0]["caixa_valorFechamento"] != DBNull.Value)
                    ValorFechamento = Convert.ToDecimal(dt.Rows[0]["caixa_valorFechamento"]);
                situacao = dt.Rows[0]["caixa_situacao"].ToString();
                Funcionario f = new Funcionario();                
                funAbriu = f.buscaFuncionarioCODIGO(Convert.ToInt32(dt.Rows[0]["funAbriu_cod"]));
                if (dt.Rows[0]["funFechou_cod"] != DBNull.Value)
                    FunFechou = f.buscaFuncionarioCODIGO(Convert.ToInt32(dt.Rows[0]["funFechou_cod"]));
                valorAtual = Convert.ToDecimal(dt.Rows[0]["caixa_valorAtual"]);
                return this;
            }
            return null;

        }
        public bool atualizaCaixa (Caixa cx)
        {
            bancoCaixa = new CaixaBD(Banco.conecta());
            return bancoCaixa.atualizaCaixa(cx);
        }
    }
}

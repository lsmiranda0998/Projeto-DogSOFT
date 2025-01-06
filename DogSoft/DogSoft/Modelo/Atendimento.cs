using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class Atendimento
    {
        private int codigo;
        private Cliente cli;
        private formaPagamento forma;
        private Funcionario fun;
        private Mesa mesa;
        private string status;
        private DateTime data;
        private decimal valorFinal;
        private AtendimentoBD bancoAten;
        public Atendimento()
        {

        }
        public Funcionario Fun { get => fun; set => fun = value; }
        public string Status { get => status; set => status = value; }
        public DateTime Data { get => data; set => data = value; }
        public decimal ValorFinal { get => valorFinal; set => valorFinal = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        internal Cliente Cli { get => cli; set => cli = value; }
        internal formaPagamento Forma { get => forma; set => forma = value; }
        internal Mesa Mesa { get => mesa; set => mesa = value; }

        public bool insereAtendimento(Atendimento a,out int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            return bancoAten.insereAtendimento(a,out cod);
        }
        public int getLastCOD()
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            return bancoAten.getLastCOD();
        }
        public bool insereITENS(DataTable dt,int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            bool res = true;
            bool flag;
            for (int i=0;i<dt.Rows.Count;i++)
            {
                if (dt.Rows[i]["cmb_cod"] != DBNull.Value)
                {
                    flag = true;
                }
                else
                    flag = false;
                res &= bancoAten.insereITENS(dt.Rows[i],flag,cod);
            }
            return res;
            
        }
        public bool alteraITENS(DataTable dt, int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            bool res = true;
            res &= bancoAten.deletaITENS(cod);
            bool flag;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["cmb_cod"] != DBNull.Value)
                {
                    flag = true;
                }
                else
                    flag = false;
                res &= bancoAten.insereITENS(dt.Rows[i], flag, cod);
            }
            return res;

        }
        public bool alteraAtendimento(Atendimento a,int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            return bancoAten.alteraAtendimento(a,cod);
        }
        public Atendimento buscaAtenCODIGO(int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            DataTable dt = bancoAten.buscaAtenCODIGO(cod);
            if (dt.Rows.Count > 0)
            {

                cli = new Cliente();
                cli = cli.buscaClienteCODIGO(Convert.ToInt32(dt.Rows[0]["cli_cod"]));
                if (dt.Rows[0]["forma_cod"] != DBNull.Value)                    
                {
                    forma = new formaPagamento();
                    forma = forma.buscaFormaCODIGO(Convert.ToInt32(dt.Rows[0]["forma_cod"]));
                }
                
                fun = new Funcionario();
                fun = fun.buscaFuncionarioCODIGO(Convert.ToInt32(dt.Rows[0]["fun_cod"]));
                mesa = new Mesa();
                mesa = mesa.buscaMesaCODIGO(Convert.ToInt32(dt.Rows[0]["mes_cod"]));
                status = dt.Rows[0]["aten_status"].ToString();
                valorFinal = Convert.ToDecimal(dt.Rows[0]["aten_valorFinal"]);
                data = Convert.ToDateTime(dt.Rows[0]["aten_data"]);
                codigo = Convert.ToInt32(dt.Rows[0]["aten_cod"]);
                return this;
            }
            return null;
        }
        public DataTable buscaAtenCLI(string nome)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            DataTable dt = bancoAten.buscaAtenCLI(nome);
            return dt;
        }
        public DataTable buscaAtenDATA(DateTime data)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            DataTable dt = bancoAten.buscaAtenDATA(data);
            return dt;
        }
        public DataTable buscaItens(int cod)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            DataTable dt = bancoAten.buscaItens(cod);
            return dt;
        }
        public bool atualizaAtendimento(Atendimento a)
        {
            bancoAten = new AtendimentoBD(Banco.conecta());
            return bancoAten.atualizaAtendimento(a);
        }
    }
}

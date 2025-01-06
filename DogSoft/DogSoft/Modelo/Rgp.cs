using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Rgp
    {
        private int cod, clicod, forma_cod, fun_cod;
        private double rgp_troco, valorTotal;
        DateTime dataHorario;
        private string descricao;
        public Rgp()
        {

        }
        public Rgp(int cod, int clicod, int forma_cod, int fun_cod, double rgp_troco, double valorTotal, DateTime dataHorario, string descricao)
        {
            this.cod = cod;
            this.clicod = clicod;
            this.forma_cod = forma_cod;
            this.fun_cod = fun_cod;
            this.rgp_troco = rgp_troco;
            this.valorTotal = valorTotal;
            this.dataHorario = dataHorario;
            this.descricao= descricao;
            
        }
        public Rgp( int clicod, int forma_cod, int fun_cod, double rgp_troco, double valorTotal, DateTime dataHorario, string descricao)
        {
            
            this.clicod = clicod;
            this.forma_cod = forma_cod;
            this.fun_cod = fun_cod;
            this.rgp_troco = rgp_troco;
            this.valorTotal = valorTotal;
            this.dataHorario = dataHorario;
            this.descricao = descricao;
           
        }
        public int getcod()
        {
            return cod;
        }
        public int getclicod()
        {
            return clicod;
        }
        public int getformacod()
        {
            return forma_cod;
        }
        public int getfuncioanriocod()
        {
            return fun_cod;
        }
        public double gettroco()
        {
            return rgp_troco;
        }
        public double getvalortot()
        {
            return valorTotal;
        }
        public DateTime getdata()
        {
            return dataHorario;
        }
        public string getDescricao()
        {
            return descricao;
        }
       
        public void setcod(int cod)
        {
            this.cod=cod;
        }
        public void setclicod(int cod)
        {
             clicod=cod;
        }
        public void setformacod(int cod)
        {
             forma_cod=cod;
        }
        public void setfuncioanriocod(int cod)
        {
             fun_cod=cod;
        }
        public void settroco(double troco)
        {
             rgp_troco=troco;
        }
        public void setvalortot(double valortot)
        {
             valorTotal=valortot;
        }
        public void setdata(DateTime data)
        {
            dataHorario=data;

        }
        public void setDescricao(string descricao)
        {
            this.descricao = descricao;
        }

    }
}

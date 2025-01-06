using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class intens_Pedido
    {
        private int itp_cod; 
        private int pro_cod;
        private int rgp_cod;
        private string itp_obs;
        private int itp_qtde;

        public intens_Pedido(int itp_cod, int pro_cod, int rgp_cod, string itp_obs, int itp_qtde)
        {
            this.itp_cod = itp_cod;
            this.pro_cod = pro_cod;
            this.rgp_cod = rgp_cod;
            this.itp_obs = itp_obs;
            this.itp_qtde = itp_qtde;
        }
        public intens_Pedido(int pro_cod, int rgp_cod, string itp_obs, int itp_qtde)
        {
            
            this.pro_cod = pro_cod;
            this.rgp_cod = rgp_cod;
            this.itp_obs = itp_obs;
            this.itp_qtde = itp_qtde;
        }
        public int Itp_cod { get => itp_cod; set => itp_cod = value; }
        public int Pro_cod { get => pro_cod; set => pro_cod = value; }
        public int Rgp_cod { get => rgp_cod; set => rgp_cod = value; }
        public string Itp_obs { get => itp_obs; set => itp_obs = value; }
        public int Itp_qtde { get => itp_qtde; set => itp_qtde = value; }
    }
}

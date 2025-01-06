using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Parametrizacao
    {
        private int cod, size, num;
        private String fonte, corFonte, corFundo, nomefantasia, site, telefone, email, bairrro, rua, razaoSocial;
        private String logo1, logo2;
        public Parametrizacao()
        {

        }
        public Parametrizacao( int size, int num, string fonte, string corFonte, string corFundo, string nomefantasia, string site, string telefone, string email, string bairrro, string rua, string razaoSocial, String logo1, String logo2)
        {
            
            this.size = size;
            this.num = num;
            this.fonte = fonte;
            this.corFonte = corFonte;
            this.corFundo = corFundo;
            this.nomefantasia = nomefantasia;
            this.site = site;
            this.telefone = telefone;
            this.email = email;
            this.bairrro = bairrro;
            this.rua = rua;
            this.razaoSocial = razaoSocial;
            this.logo1 = logo1;
            this.logo2 = logo2;
        }
        public Parametrizacao(int cod, int size, int num, string fonte, string corFonte, string corFundo, string nomefantasia, string site, string telefone, string email, string bairrro, string rua, string razaoSocial, String logo1, String logo2)
        {
            this.cod = cod;
            this.size = size;
            this.num = num;
            this.fonte = fonte;
            this.corFonte = corFonte;
            this.corFundo = corFundo;
            this.nomefantasia = nomefantasia;
            this.site = site;
            this.telefone = telefone;
            this.email = email;
            this.bairrro = bairrro;
            this.rua = rua;
            this.razaoSocial = razaoSocial;
            this.logo1 = logo1;
            this.logo2 = logo2;
        }

        public int Cod { get => cod; set => cod = value; }
        public int Size { get => size; set => size = value; }
        public int Num { get => num; set => num = value; }
        public string Fonte { get => fonte; set => fonte = value; }
        public string CorFonte { get => corFonte; set => corFonte = value; }
        public string CorFundo { get => corFundo; set => corFundo = value; }
        public string Nomefantasia { get => nomefantasia; set => nomefantasia = value; }
        public string Site { get => site; set => site = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Bairrro { get => bairrro; set => bairrro = value; }
        public string Rua { get => rua; set => rua = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public String Logo1 { get => logo1; set => logo1 = value; }
        public String Logo2 { get => logo2; set => logo2 = value; }
    }
}

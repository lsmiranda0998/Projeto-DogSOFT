using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Fornecedor : Pessoa
    {
       
        private String CNPJ;
        private String nomeFantasia;
        private String razaoSocial;
        
        public Fornecedor(String CNPJ,String nomeFantasia,String razaoSocial)
        {
            this.razaoSocial = razaoSocial;
            this.nomeFantasia = nomeFantasia;
            this.CNPJ = CNPJ;
        }
        public String getCNPJ()
        {
            return CNPJ;
        }
        public String getnomeFantasia()
        {
            return nomeFantasia;
        }
        public String getrazaoSocial()
        {
            return razaoSocial;
        }
        public void setCNPJ(String cnpj)
        {
            this.CNPJ = cnpj;
        }
        public void setnomeFantasia(String nomeFantasia)
        {
            this.nomeFantasia = nomeFantasia;
        }
        public void setrazaoSocial(String razaoSocial)
        {
            this.razaoSocial = razaoSocial;
        }

        /*public string CNPJ1 { get => CNPJ; set => CNPJ = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }*/
    }
}

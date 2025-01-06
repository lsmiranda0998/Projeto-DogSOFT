using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class Pessoa
    {
        private int cod, num;
        private string nome, email, telefone, rua, complemento, bairro, cep;
        private Cidade c;
 
        public Pessoa()
        {

        }

        public Pessoa(int cod, int num, string nome, string email, string telefone, string rua, string complemento, string bairro, string cep, Cidade c)
        {
            this.cod = cod;
            this.num = num;
            this.nome = nome;
            this.email = email;
            this.telefone = telefone;
            this.rua = rua;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cep = cep;
            this.c = c;

        }
    
        public int getCod()
        {
            return cod;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public int getNum()
        {
            return num;
        }
        public void setNum(int num)
        {
            this.num = num;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getEmail ()
        {
            return email;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getTelefone ()
        {
            return telefone;
        }
        public void setTelefone (string telefone)
        {
            this.telefone = telefone;
        }
        public string getRua()
        {
            return rua;
        }
        public void setRua(string rua)
        {
            this.rua = rua;
        }
        public string getComplemento()
        {
            return complemento;
        }
        public void setComplemento(string complemento)
        {
            this.complemento = complemento;
        }
        public string getBairro()
        {
            return bairro;
        }
        public void setBairro (string bairro)
        {
            this.bairro = bairro;
        }
        public string getCep ()
        {
            return cep;
        }
        public void setCep(string cep)
        {
            this.cep = cep;
        }
        public Cidade getCidade()
        {
            return c;
        }
        public void setCIdade (Cidade c)
        {
            this.c = c;
        }


    }
}

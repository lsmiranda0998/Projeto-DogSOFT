using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class Estado
    {
        private int codigo;
        private string sigla, nome;
        private EstadoBD estadoBD;
        public Estado()
        {

        }
        public Estado(int codigo, string sigla, string nome)
        {
            this.codigo = codigo;
            this.sigla = sigla;
            this.nome = nome;
        }
        public int getCodigo()
        {
            return codigo;
        }

        public void setCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getSigla()
        {
            return sigla;
        }

        public void setSigla(string sigla)
        {
            this.sigla = sigla;
        }
        public DataTable buscAll()
        {
            estadoBD = new EstadoBD(Banco.conecta());
            return estadoBD.buscAll();
        }

        public DataTable busc(int codigo)
        {
            estadoBD = new EstadoBD(Banco.conecta());
            return estadoBD.busc(codigo);
        }
    }
}

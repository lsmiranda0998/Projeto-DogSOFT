using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class Cidade
    {
        private int codigo;
        private string nome;
        private Estado estado;
        private CidadeBD bancC;

        public Cidade(int codigo, string nome, Estado estado)
        {
            this.codigo = codigo;
            this.nome = nome;
            this.estado = estado;
        }
        public Cidade()
        {

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

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public Estado getEstado()
        {
            return estado;
        }

        public void setEstado(Estado estado)
        {
            this.estado = estado;
        }
        public DataTable buscaTODOS(int estado)
        {
            bancC = new CidadeBD(Banco.conecta());
            return bancC.buscaTODOS(estado);
        }
        public object buscaCidade(int cod)
        {
            bancC = new CidadeBD(Banco.conecta());
            return bancC.buscaCidade(cod);
        }
        public object buscaCidadeNOME(string nome)
        {
            bancC = new CidadeBD(Banco.conecta());
            return bancC.buscaCidadeNOME(nome);
        }

        public DataTable buscar(int codigo)
        {
            bancC = new CidadeBD(Banco.conecta());
            return bancC.buscar(codigo);
        }
    }
}

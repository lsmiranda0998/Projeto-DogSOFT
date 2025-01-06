using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DALProduto
    {
        private Banco banc;
        private DALProduto()
        {

        }
        
        private ProdutoBD fbd;
        private static DALProduto dalProd = null;
        public static DALProduto novaInstancia()
        {
            if (dalProd == null)
                dalProd = new DALProduto();
            return dalProd;
        }
        public DataTable buscaProdutosDESC(string desc)
        {
            DataTable dt = new DataTable();
            banc = Banco.conecta();
            Produto p = new Produto();
            dt = p.buscaProdutosDESC(desc);
            banc.Desconecta();
            return dt;

        }
        public Produto buscaProdutosCODIGO(int cod)
        {
            banc = Banco.conecta();//**
            Produto p = new Produto();
            p = p.buscaProdutosCODIGO(cod);
            banc.Desconecta();//**
            return p;
        }
        public DataTable buscaNomeFantasia(String nome)
        {
            fbd = new ProdutoBD(Banco.conecta());
            return fbd.buscaProduto(nome);
        }
        public DataTable buscaCod(int cod)
        {
            fbd = new ProdutoBD(Banco.conecta());
            return fbd.buscaProdutoCod(cod);
        }
        public bool Decrementa(int cod)
        {

            //MessageBox.Show(clicod.ToString());
            fbd = new ProdutoBD(Banco.conecta());
            return fbd.decrementaEstoque(cod);
        }
    }
}

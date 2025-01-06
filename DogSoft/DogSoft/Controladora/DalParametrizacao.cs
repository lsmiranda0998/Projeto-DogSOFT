using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Controladora
{
    class DalParametrizacao
    {
        private Parametrizacao p;
        private static DalParametrizacao dalp = null;
        private ParametrizacaoBD fbd;
        private DalParametrizacao()
        {
            //dalp = DalParametrizacao.novaInstancia();
        }

        public static DalParametrizacao novaInstancia()
        {
            if (dalp == null)
                dalp = new DalParametrizacao();
            return dalp;
        }
        public bool primeiroAcesso()
        {
            fbd = new ParametrizacaoBD(Banco.conecta());
            return fbd.primeiroAcesso();
        }
        public bool salvar(int size, int num, string fonte, string corFonte, string corFundo, string nomefantasia, string site, string telefone, string email, string bairrro, string rua, string razaoSocial, string logo1, string logo2)
        {
            p = new Parametrizacao( size,  num,  fonte,  corFonte,  corFundo,  nomefantasia,  site,  telefone,  email,  bairrro,  rua,  razaoSocial,  logo1,  logo2);
            fbd = new ParametrizacaoBD(Banco.conecta());
            return fbd.inserir(p);
        }
        public bool salvar2(String logo1, String logo2)
        {
            p = new Parametrizacao( );
            p.Logo1 = logo1;
            p.Logo2 = logo2;
            fbd = new ParametrizacaoBD(Banco.conecta());
            return fbd.inserir2(p);
        }
        public bool alterar(int size, int num, string fonte, string corFonte, string corFundo, string nomefantasia, string site, string telefone, string email, string bairrro, string rua, string razaoSocial, String logo1, String logo2,int cod)
        {
            p = new Parametrizacao(size, num, fonte, corFonte, corFundo, nomefantasia, site, telefone, email, bairrro, rua, razaoSocial, logo1, logo2);
            p.Cod = cod;
            fbd = new ParametrizacaoBD(Banco.conecta());
            return fbd.alterar(p);
        }
        public DataTable carrega()
        {
            fbd = new ParametrizacaoBD(Banco.conecta());
            return fbd.carrega();
        }
    }
}

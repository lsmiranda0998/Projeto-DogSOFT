using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class ParametrizacaoBD
    {
        private Banco banco;
        public  ParametrizacaoBD(Banco banco)
        {
            this.banco = banco;
        }
        public bool primeiroAcesso()
        {
            
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Parametrizacao ";
            banco.ExecuteQuery(SQL, out dt );
            if (dt.Rows.Count <= 0)
                return true;
            else
                return false;
        }
        public bool inserir(Parametrizacao P)
        {
            string SQL;
            
            SQL = @"INSERT INTO Parametrizacao (prm_nomeFantasia,prm_corFundo,prm_fonte,prm_site,prm_corFonte,prm_telefone,prm_rua,prm_bairro,prm_email,prm_num,prm_size,prm_razaoSocial,prm_logo1,prm_logo2) 
                        VALUES (@NOME,@CORFU,@FONTE,@SITE,@CORFO,@TELEFONE,@RUA,@BAIRRO,@EMAIL,@NUM,@SIZE,@RAZAO,@logo1,@logo2)";
            return  banco.ExecuteNonQuery(SQL, "@NOME", P.Nomefantasia, "@CORFU", P.CorFundo, "@FONTE", P.Fonte, "@SITE", P.Site, "@CORFO", P.CorFonte, "@TELEFONE", P.Telefone, "@RUA",P.Rua, "@BAIRRO",P.Bairrro, "@EMAIL", P.Email, "@NUM", P.Num, "@SIZE", P.Size, "@RAZAO", P.RazaoSocial,"@logo1",P.Logo1,"@logo2",P.Logo2);

        }
        public bool inserir2(Parametrizacao P)
        {
            string SQL;

            SQL = @"INSERT INTO Parametrizacao (prm_logo1,prm_logo2) 
                        VALUES (@NOME,@CORFU)";
            return banco.ExecuteNonQuery(SQL, "@NOME", P.Logo1, "@CORFU",P.Logo2);

        }
        public DataTable carrega()
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Parametrizacao";
            banco.ExecuteQuery(SQL, out dt);
            return dt;
        }
        public bool alterar(Parametrizacao P)
        {
            string SQL;
            
           SQL = @"DELETE FROM Parametrizacao  WHERE prm_cod=@COD";
           banco.ExecuteNonQuery(SQL, "@COD", P.Cod);
           return inserir(P);
            

        }
    }
}


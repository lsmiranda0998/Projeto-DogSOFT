using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Persistencia
{
    class FornecedorBD
    {
        private Banco banco;

        public FornecedorBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaFornecedor(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Fornecedor f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE for_nomeFantasia LIKE @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome+"%");
            return dt;
        }
        public DataTable buscaBairro(string bairro)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Fornecedor f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE pes_Bairro LIKE @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", bairro + "%");
            return dt;
        }

        public bool alterar(Fornecedor f)
        {
            string SQL;
            bool res1;
            
            SQL = @"UPDATE Pessoa SET pes_nome=@NOME,pes_telefone=@TELEFONE,pes_email=@EMAIL,pes_rua=@RUA,pes_complemento=@COMP,pes_bairro=@BAIRRO,pes_num=@NUM,pes_cep=@CEP,cid_cod=@CID WHERE pes_cod=@COD ";
            res1 = banco.ExecuteNonQuery(SQL, "@NOME", f.getNome(), "@TELEFONE", f.getTelefone(), "@EMAIL", f.getEmail(), "@RUA", f.getRua(), "@COMP", f.getComplemento(), "@BAIRRO", f.getBairro(), "@NUM", f.getNum(), "@CEP", f.getCep(), "@CID", f.getCidade().getCodigo(),"@COD",f.getCod());
            if (!res1)
                MessageBox.Show("problema ao alterar pessoa");
            



            SQL = @"UPDATE Fornecedor SET for_nomeFantasia=@NOME,for_cnpj=@CNPJ,for_razaoSocial=@RAZAO 
                    WHERE pes_cod=@COD";
            return banco.ExecuteNonQuery(SQL, "@NOME", f.getnomeFantasia(), "@CNPJ", f.getCNPJ(), "@RAZAO", f.getrazaoSocial(), "@COD", f.getCod());


        }
        public bool deleta(int cod)
        {
            bool res1;
            string SQL = @"DELETE FROM Fornecedor WHERE pes_cod = @COD";
            res1 = banco.ExecuteNonQuery(SQL, "@COD", cod);
            if (!res1)
                MessageBox.Show("problema ao deletar pessoa");

            SQL = @"DELETE FROM Pessoa WHERE pes_cod = @COD";
            return  banco.ExecuteNonQuery(SQL, "@COD", cod);
        }
        public bool inserir(Fornecedor f)
        {
            string SQL;
            bool res1;
            int aux=0;
            SQL = @"INSERT INTO Pessoa (pes_nome,pes_telefone,pes_email,pes_rua,pes_complemento,pes_bairro,pes_num,pes_cep,cid_cod) 
                        VALUES (@NOME,@TELEFONE,@EMAIL,@RUA,@COMP,@BAIRRO,@NUM,@CEP,@CID)";
            res1=banco.ExecuteNonQuery(SQL, "@NOME", f.getNome(), "@TELEFONE", f.getTelefone(), "@EMAIL", f.getEmail(), "@RUA", f.getRua(), "@COMP", f.getComplemento(), "@BAIRRO", f.getBairro(),"@NUM",f.getNum() ,"@CEP", f.getCep(), "@CID", f.getCidade().getCodigo());
            if (!res1)
                MessageBox.Show("problema ao cadastrar pessoa");
            else
                 aux = banco.GetIdentity();
               
            
            
            SQL = @"INSERT INTO Fornecedor (for_nomeFantasia,for_cnpj,for_razaoSocial,pes_cod) 
                    VALUES (@NOME,@CNPJ,@RAZAO,@COD)";
            return banco.ExecuteNonQuery(SQL, "@NOME", f.getnomeFantasia(), "@CNPJ", f.getCNPJ(), "@RAZAO", f.getrazaoSocial(), "@COD", aux );

            
        }
    }
}

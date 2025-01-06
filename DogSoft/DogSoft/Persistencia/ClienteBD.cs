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
    class ClienteBD
    {
        private Banco banco;
        public ClienteBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaClienteNOME(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE pes_nome LIKE @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome + "%");

            return dt;
        }     
        public DataTable buscaClienteCPF(string CPF)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE cli_cpf = @CPF";
            banco.ExecuteQuery(SQL, out dt, "@CPF", CPF);
           
            return dt;
        }
        public DataTable buscaClienteCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE p.pes_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);

            return dt;
        }
        public DataTable buscaClienteNOME2(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE pes_nome = @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome);

            return dt;
        }
        public bool inserir(Cliente c)
        {
            
            string SQL = @"INSERT INTO Pessoa (pes_nome) 
                        VALUES (@NOME)";
            bool res1 = banco.ExecuteNonQuery(SQL, "@NOME", c.getNome());
            int cod = banco.GetIdentity();
            bool res2;
            if (c.getCpf() != null)
            {
                string SQL2 = @"INSERT INTO Cliente(cli_cpf,pes_cod) 
                        VALUES (@CPF,@COD)";
                res2 = banco.ExecuteNonQuery(SQL2, "@CPF", c.getCpf(),"@COD",cod);
                return res1 && res2;
            }
            return res1;
        }
        public int buscaClientecod(string nome)
        {

            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE pes_nome = @CPF";
            banco.ExecuteQuery(SQL, out dt, "@CPF", nome);

            return Convert.ToInt32(dt.Rows[0]["pes_cod"]);
        }
        public DataTable buscaCliente(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod WHERE pes_nome LIKE @CPF";
            banco.ExecuteQuery(SQL, out dt, "@CPF", nome + "%");

            return dt;
        }
        public Boolean insere(Cliente c)
        {
            string SQL;
            bool res1;
            int aux = 0;
            SQL = @"INSERT INTO Pessoa (pes_nome,pes_telefone,pes_email,pes_rua,pes_complemento,pes_bairro,pes_num,pes_cep,cid_cod) 
                        VALUES (@NOME,@TELEFONE,@EMAIL,@RUA,@COMP,@BAIRRO,@NUM,@CEP,@CID)";
            res1 = banco.ExecuteNonQuery(SQL, "@NOME", c.getNome(), "@TELEFONE", c.getTelefone(), "@EMAIL", "", "@RUA", c.getRua(), "@COMP", c.getComplemento(), "@BAIRRO", c.getBairro(), "@NUM", c.getNum(), "@CEP", c.getCep(), "@CID", c.getCidade().getCodigo());
            if (!res1)
                MessageBox.Show("problema ao cadastrar pessoa");
            else
                aux = banco.GetIdentity();



            SQL = @"INSERT INTO Cliente (pes_cod) 
                    VALUES (@COD)";
            return banco.ExecuteNonQuery(SQL, "@COD", aux);

        }


    }
}

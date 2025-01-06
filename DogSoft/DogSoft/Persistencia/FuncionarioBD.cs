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
    class FuncionarioBD
    {
        private Banco banco;

        public FuncionarioBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaFuncionarioCPF(string cpf)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE fun_cpf = @CPF";
            banco.ExecuteQuery(SQL, out dt, "@CPF", cpf);
            return dt;
        }
        public DataTable buscaFuncionarioCODIGO(int cod)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE p.pes_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);
            return dt;
        }
        public DataTable buscaFuncionarioNOME(string nome)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE pes_nome LIKE @nome order by pes_nome";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome + "%");
            return dt;
        }
        public DataTable buscaFuncionarioTodosLOGIN(string login)
        {
            DataTable dt = null ;
            string SQL = @"SELECT * FROM Funcionario WHERE fun_login LIKE @login";
            banco.ExecuteQuery(SQL, out dt, "@login", login +"%");
            if (dt.Rows.Count == 0)
                dt = null;
            return dt;
        }
        public DataTable buscaFuncionarioLOGIN(string login)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT * FROM Funcionario f INNER JOIN Pessoa p on f.pes_cod = p.pes_cod WHERE fun_login = @login";
            banco.ExecuteQuery(SQL, out dt, "@login", login);
            return dt;
        }
       public bool deletaFuncionarioCOD(int cod)
        {
            string SQL = @"DELETE FROM Funcionario WHERE pes_cod = @COD";
            bool res1 = banco.ExecuteNonQuery(SQL, "@COD", cod);
            string SQL2 = @"DELETE FROM Pessoa WHERE pes_cod = @COD";
            bool res2 = banco.ExecuteNonQuery(SQL2, "@COD", cod);
            return res1 && res2;
            

        }


        public bool inserir(Funcionario f)
        {
            string SQL,SQL2, nome, bairro, rua, cpf, cep;
            string tipo;

            char sexo;
            decimal salario;
            DateTime date;
            date = f.getDataNasc();
            nome = f.getNome();
            bairro = f.getBairro();
            rua = f.getRua();
            salario = f.getSalario();
            tipo = f.getNivel();
            cep = f.getCep();
            cpf = f.getCpf();
            sexo = f.getSexo();
            SQL = @"INSERT INTO Pessoa (cid_cod,pes_rua,pes_bairro,pes_nome,pes_cep,pes_email,pes_telefone,pes_complemento,pes_num) 
                        VALUES (@CID,@RUA,@BAIRRO,@NOME,@CEP,@MAIL,@FONE,@COMPLEMENTO,@NUM)";
            bool res1 = banco.ExecuteNonQuery(SQL, "@CID", f.getCidade().getCodigo(), "@RUA", rua, "@BAIRRO", bairro, "@NOME", nome,"@CEP", cep, "@MAIL", f.getEmail(), "@FONE", f.getTelefone(),"@COMPLEMENTO",f.getComplemento(),"@NUM",f.getNum());
            int cod = banco.GetIdentity();  
            f.setCod(cod);
            SQL2 = @"INSERT INTO Funcionario (pes_cod,fun_ativo,fun_login,fun_senha,fun_nivel,fun_salario,fun_cpf,fun_sexo,fun_dataNasc) 
                        VALUES (@PES,@ATIVO,@LOGIN,@SENHA,@NIVEL,@SALARIO,@CPF,@SEXO,@DATA)";
            bool res2 = banco.ExecuteNonQuery(SQL2, "@PES", f.getCod(), "@ATIVO", f.getAtivo(), "@LOGIN", f.getLogin(), "@SENHA",f.getSenha(), "@NIVEL", f.getNivel(), "@SALARIO",f.getSalario(),"@CPF",f.getCpf(),"@SEXO",f.getSexo(),"@DATA",f.getDataNasc());
 
            return res1 && res2;
        }
        public bool alterar(Funcionario f)
        {
            string SQL, SQL2, nome, bairro, rua, cpf, cep;
            string tipo;

            char sexo;
            decimal salario;
            DateTime date;
            date = f.getDataNasc();
            nome = f.getNome();
            bairro = f.getBairro();
            rua = f.getRua();
            salario = f.getSalario();
            tipo = f.getNivel();
            cep = f.getCep();
            cpf = f.getCpf();
            sexo = f.getSexo();
            SQL = @"UPDATE Pessoa SET
                        cid_cod=@CID, pes_rua=@RUA, pes_bairro=@BAIRRO, pes_nome=@NOME, pes_cep=@CEP, pes_email=@MAIL, pes_telefone=@FONE, pes_complemento=@COMPLEMENTO, pes_num=@NUM WHERE pes_cod = @COD";        
            bool res1 = banco.ExecuteNonQuery(SQL, "@CID", f.getCidade().getCodigo(), "@RUA", rua, "@BAIRRO", bairro, "@NOME", nome, "@CEP", cep, "@MAIL", f.getEmail(), "@FONE", f.getTelefone(), "@COMPLEMENTO", f.getComplemento(), "@NUM", f.getNum(),"@COD",f.getCod());
  
            SQL2 = @"UPDATE Funcionario SET
                        fun_ativo=@ATIVO, fun_login=@LOGIN, fun_senha=@SENHA, fun_nivel=@NIVEL, fun_salario=@SALARIO, fun_cpf=@CPF, fun_sexo=@SEXO, fun_dataNasc=@DATA WHERE pes_cod = @COD";
        
            bool res2 = banco.ExecuteNonQuery(SQL2, "@ATIVO", f.getAtivo(), "@LOGIN", f.getLogin(), "@SENHA", f.getSenha(), "@NIVEL", f.getNivel(), "@SALARIO", f.getSalario(), "@CPF", f.getCpf(), "@SEXO", f.getSexo(), "@DATA", f.getDataNasc(),"@COD",f.getCod());
        
            return res1 && res2;
        }
    }
}

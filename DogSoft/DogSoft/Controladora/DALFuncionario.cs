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
    class DALFuncionario
    {
        private Funcionario f;
        private Cidade ci;
        private DALCidade dalC;


       private static DALFuncionario dalFun = null;

        private DALFuncionario()
        {
            dalC = DALCidade.novaInstancia();
        }

        public static DALFuncionario novaInstancia()
        {
            if (dalFun == null)
                dalFun = new DALFuncionario();
            return dalFun;
        }
        public bool deletaFuncionarioCOD(int cod)
        {
            /*login = new LoginBD(bco);
            bco.Conecta();*/
            Banco b = Banco.conecta();
            f = new Funcionario();
            bool res =  f.deletaFuncionarioCOD(cod);           
            b.Desconecta();
            return res;
        }

        //private CidadeBD bdC;
        public DataTable buscaFuncionarioTodosLOGIN(string login)
        {

            Banco b = Banco.conecta();            
            DataTable dt;
            f = new Funcionario();
            dt = f.buscaFuncionarioTodosLOGIN(login);
            b.Desconecta();
            return dt;
        }
        public Funcionario buscaFuncionarioLOGIN(string login)
        {

            Banco b = Banco.conecta();

            f = new Funcionario();
            f = f.buscaFuncionarioLOGIN(login);
            b.Desconecta();
            return f;
        }
      
        public DataTable buscaFuncionarioNOME(string nome)
        {
            //bancoU = new UsuarioBD(banco);
            //banco.Conecta();
            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            f = new Funcionario();
            dt = f.buscaFuncionarioNOME(nome);
            b.Desconecta();
            return dt;

        }
        public DataTable buscaFuncionarioCPF(string cpf)
        {
            //bancoU = new UsuarioBD(banco);
            //banco.Conecta();
            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            f = new Funcionario();
            dt = f.buscaFuncionarioCPF(cpf);
            b.Desconecta();
            return dt;

        }
        public bool insereFuncionario2(Funcionario f)
        {

            Banco b = Banco.conecta(); 
            
            bool res = f.inserir(f);
            b.Desconecta();
            return res;
        }
        public bool insereFuncionario(string nome, string rua, string bairro, decimal salario, String tipo, string cep, DateTime dataNasc, char sexo, Cidade c, string cpf, string fone, string mail,Char ativo, string login,string senha,string complemento,int numero)
        {

            Banco b = Banco.conecta();
            Funcionario f;
            f = new Funcionario(nome, rua, bairro, salario, tipo, cep, dataNasc, sexo, c, cpf, fone, mail,ativo,login,senha,complemento,numero);

            bool res = f.inserir(f);
            b.Desconecta();
            return res;
        }

        public bool alteraFuncionario(string nome, string rua, string bairro, decimal salario, String tipo, string cep, DateTime dataNasc, char sexo, Cidade c, string cpf, string fone, string mail, Char ativo, string login, string senha, string complemento, int numero,int codPes)
        {

            Banco b = Banco.conecta();
            Funcionario f;
            f = new Funcionario(nome, rua, bairro, salario, tipo, cep, dataNasc, sexo, c, cpf, fone, mail, ativo, login, senha, complemento, numero);
            f.setCod(codPes);
            bool res = f.alterar(f);
            b.Desconecta();
            return res;
        }
       
    }
}

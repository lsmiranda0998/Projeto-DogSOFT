using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    public class Funcionario : Pessoa
    {

        private char ativo,sexo;
        private string login, senha, nivel,cpf;
        private decimal salario;
        private FuncionarioBD bancoFun;
        private CidadeBD bancoCid;
        private DateTime dataNasc;
        
    
        public Funcionario()
        {

        }
        public Funcionario(string usr_nome, string usr_rua, string usr_bairro, decimal usr_salario, string usr_nivel, string usr_cep, DateTime usr_dataNasc, char sexo, Cidade cid, string usr_cpf, string usr_telefone, string usr_email,char ativo, string login, string senha,string complemento, int num)
        {
            setNome(usr_nome);
            setRua(usr_rua);
            setBairro(usr_bairro);    
            salario = usr_salario;
            nivel = usr_nivel;
            setCep(usr_cep);
            dataNasc = usr_dataNasc;
            this.sexo = sexo;
            setCIdade(cid);
            cpf = usr_cpf;
            setTelefone(usr_telefone);
            setEmail(usr_email);
            this.ativo = ativo;
            this.login = login;
            this.senha = senha;
            setComplemento(complemento);
            setNum(num);
        }
        public char getAtivo()
        {
            return ativo;
        }
        public void setAtivo(char ativo)
        {
            this.ativo = ativo;
        }
        public string getLogin()
        {
            return login;
        }
        public void setLogin(string login)
        {
            this.login = login;
        }
        public string getSenha()
        {
            return senha;
        }

        public void setSenha(string senha)
        {
            this.senha = senha;
        }
        public string getNivel()
        {
            return nivel;
        }
        public void setNivel(string nivel)
        {
            this.nivel = nivel;
        }
        public decimal getSalario()
        {
            return salario;
        }
        public void setSalario(decimal salario)
        {
            this.salario = salario;
        }
       
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public DateTime getDataNasc()
        {
            return dataNasc;
        }
        public void setDataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public char getSexo()
        {
            return sexo;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public DataTable buscaFuncionarioNOME(string nome)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            DataTable dt = bancoFun.buscaFuncionarioNOME(nome);
            return dt;
        }
        public DataTable buscaFuncionarioCPF(string cpf)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            DataTable dt =  bancoFun.buscaFuncionarioCPF(cpf);
            return dt;
        }
        public bool deletaFuncionarioCOD(int cod)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            return bancoFun.deletaFuncionarioCOD(cod);
            
        }
        public DataTable buscaFuncionarioTodosLOGIN(string login)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            DataTable dt = bancoFun.buscaFuncionarioTodosLOGIN(login);
            return dt;
        }
        public Funcionario buscaFuncionarioCODIGO(int cod)
        {

            bancoFun = new FuncionarioBD(Banco.conecta());
            DataTable dt = bancoFun.buscaFuncionarioCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                bancoCid = new CidadeBD(Banco.conecta());
                this.login = dt.Rows[0]["fun_login"].ToString();
                senha = dt.Rows[0]["fun_senha"].ToString();
                nivel = dt.Rows[0]["fun_nivel"].ToString();
                ativo = Convert.ToChar(dt.Rows[0]["fun_ativo"]);
                setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                salario = Convert.ToDecimal(dt.Rows[0]["fun_salario"]);
                setNome(dt.Rows[0]["pes_nome"].ToString());
                setNum(Convert.ToInt32(dt.Rows[0]["pes_num"]));
                setTelefone(dt.Rows[0]["pes_telefone"].ToString());
                setEmail(dt.Rows[0]["pes_email"].ToString());
                setBairro(dt.Rows[0]["pes_bairro"].ToString());
                setRua(dt.Rows[0]["pes_rua"].ToString());
                setComplemento(dt.Rows[0]["pes_complemento"].ToString());
                setCep(dt.Rows[0]["pes_cep"].ToString());
                setCpf(dt.Rows[0]["fun_cpf"].ToString());
                setDataNasc(Convert.ToDateTime(dt.Rows[0]["fun_dataNasc"]));
                setSexo(Convert.ToChar(dt.Rows[0]["fun_sexo"]));
                Cidade c = (Cidade)bancoCid.buscaCidade(Convert.ToInt32(dt.Rows[0]["cid_cod"])); // nasci    
                setCIdade(c);
                return this;
            }
            return null;

        }
        public Funcionario buscaFuncionarioLOGIN(string login)
        {

            bancoFun = new FuncionarioBD(Banco.conecta());
            DataTable dt = bancoFun.buscaFuncionarioLOGIN(login);
            if (dt.Rows.Count > 0)
            {
                bancoCid = new CidadeBD(Banco.conecta());
                this.login = dt.Rows[0]["fun_login"].ToString();
                senha = dt.Rows[0]["fun_senha"].ToString();
                nivel = dt.Rows[0]["fun_nivel"].ToString();
                ativo = Convert.ToChar(dt.Rows[0]["fun_ativo"]);
                setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                salario = Convert.ToDecimal(dt.Rows[0]["fun_salario"]);
                setNome(dt.Rows[0]["pes_nome"].ToString());
                setNum(Convert.ToInt32(dt.Rows[0]["pes_num"]));
                setTelefone(dt.Rows[0]["pes_telefone"].ToString());
                setEmail(dt.Rows[0]["pes_email"].ToString());
                setBairro(dt.Rows[0]["pes_bairro"].ToString());
                setRua(dt.Rows[0]["pes_rua"].ToString());
                setComplemento(dt.Rows[0]["pes_complemento"].ToString());
                setCep(dt.Rows[0]["pes_cep"].ToString());
                setCpf(dt.Rows[0]["fun_cpf"].ToString());
                setDataNasc(Convert.ToDateTime(dt.Rows[0]["fun_dataNasc"]));
                setSexo(Convert.ToChar(dt.Rows[0]["fun_sexo"]));
                Cidade c = (Cidade)bancoCid.buscaCidade(Convert.ToInt32(dt.Rows[0]["cid_cod"])); // nasci    
                setCIdade(c);
                return this;
            }
            return null;
     
        }
      
        public bool inserir(Funcionario f)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            return bancoFun.inserir(f);
        }
        public bool alterar(Funcionario f)
        {
            bancoFun = new FuncionarioBD(Banco.conecta());
            return bancoFun.alterar(f);
        }
    }
}

using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Modelo
{
    public class Cliente : Pessoa
    {
        private string cpf;
        private char sexo;
        private DateTime dataNasc;
        private CidadeBD bancoCid;
        private ClienteBD bancoCli;

        public Cliente()
        {
            
        }

        public Cliente(string cli_nome, string cli_rua, string cli_bairro, string cli_cep, DateTime dataNasc, char sexo, Cidade cid, string cpf, string cli_telefone, string cli_email, string complemento, int num)
        {
            setComplemento(complemento);
            setNum(num);
            setNome(cli_nome);
            setRua(cli_rua);
            setBairro(cli_bairro);         
            setCep(cli_cep);       
            setCIdade(cid);            
            setTelefone(cli_telefone);
            setEmail(cli_email);
            this.cpf = cpf;
            this.dataNasc = dataNasc;
            this.sexo = sexo;
            
        }
        public string getCpf()
        {
            return cpf;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public char getSexo()
        {
            return sexo;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public DateTime getdataNasc()
        {
            return dataNasc;
        }
        public void setdataNasc(DateTime dataNasc)
        {
            this.dataNasc = dataNasc;
        }
        public DataTable buscaClienteNOME(string nome)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteNOME(nome);
            return dt;
        }
        public DataTable buscaClienteCPF2(string cpf)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteCPF(cpf);
            return dt;
        }
        public Cliente buscaClienteCPF(string cpf)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteCPF(cpf);
            if (dt.Rows.Count > 0)
            {
                bancoCid = new CidadeBD(Banco.conecta());
                setNome(dt.Rows[0]["pes_nome"].ToString());
                if (dt.Rows[0]["pes_num"] != DBNull.Value)
                    setNum(Convert.ToInt32(dt.Rows[0]["pes_num"]));
                if (dt.Rows[0]["pes_telefone"] != DBNull.Value)
                    setTelefone(dt.Rows[0]["pes_telefone"].ToString());
                if (dt.Rows[0]["pes_email"] != DBNull.Value)
                    setEmail(dt.Rows[0]["pes_email"].ToString());
                if (dt.Rows[0]["pes_bairro"] != DBNull.Value)
                    setBairro(dt.Rows[0]["pes_bairro"].ToString());
                if (dt.Rows[0]["pes_rua"] != DBNull.Value)
                    setRua(dt.Rows[0]["pes_rua"].ToString());
                if (dt.Rows[0]["pes_complemento"] != DBNull.Value)
                    setComplemento(dt.Rows[0]["pes_complemento"].ToString());
                if (dt.Rows[0]["pes_cep"] != DBNull.Value)
                    setCep(dt.Rows[0]["pes_cep"].ToString());
                if (dt.Rows[0]["cli_cpf"] != DBNull.Value)
                    cpf = dt.Rows[0]["cli_cpf"].ToString();
                if (dt.Rows[0]["cli_dataNascimento"] != DBNull.Value)
                    dataNasc = (Convert.ToDateTime(dt.Rows[0]["cli_dataNascimento"]));
                if (dt.Rows[0]["cli_sexo"] != DBNull.Value)
                    sexo = (Convert.ToChar(dt.Rows[0]["cli_sexo"]));
                //MessageBox.Show(Convert.ToInt32(dt.Rows[0]["cid_cod"]).ToString());
                // nasci  
                if (dt.Rows[0]["cid_cod"] != DBNull.Value)
                {
                    Cidade cid = (Cidade)bancoCid.buscaCidade(Convert.ToInt32(dt.Rows[0]["cid_cod"])); // nasci    
                    setCIdade(cid);
                }
                if (dt.Rows[0]["pes_cod"] != DBNull.Value)
                    setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                return this;
            }
            return null;

        }
        public Cliente buscaClienteCODIGO(int cod)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                bancoCid = new CidadeBD(Banco.conecta());
                setNome(dt.Rows[0]["pes_nome"].ToString());
                if (dt.Rows[0]["pes_num"] != DBNull.Value)
                    setNum(Convert.ToInt32(dt.Rows[0]["pes_num"]));
                if (dt.Rows[0]["pes_telefone"] != DBNull.Value)
                    setTelefone(dt.Rows[0]["pes_telefone"].ToString());
                if (dt.Rows[0]["pes_email"] != DBNull.Value)
                    setEmail(dt.Rows[0]["pes_email"].ToString());
                if (dt.Rows[0]["pes_bairro"] != DBNull.Value)
                    setBairro(dt.Rows[0]["pes_bairro"].ToString());
                if (dt.Rows[0]["pes_rua"] != DBNull.Value)
                    setRua(dt.Rows[0]["pes_rua"].ToString());
                if (dt.Rows[0]["pes_complemento"] != DBNull.Value)
                    setComplemento(dt.Rows[0]["pes_complemento"].ToString());
                if (dt.Rows[0]["pes_cep"] != DBNull.Value)
                    setCep(dt.Rows[0]["pes_cep"].ToString());
                if (dt.Rows[0]["cli_cpf"] != DBNull.Value)
                    cpf = dt.Rows[0]["cli_cpf"].ToString();
                if (dt.Rows[0]["cli_dataNascimento"] != DBNull.Value)
                    dataNasc = (Convert.ToDateTime(dt.Rows[0]["cli_dataNascimento"]));
                if (dt.Rows[0]["cli_sexo"] != DBNull.Value)
                    sexo = (Convert.ToChar(dt.Rows[0]["cli_sexo"]));
                //MessageBox.Show(Convert.ToInt32(dt.Rows[0]["cid_cod"]).ToString());
                // nasci  
                if (dt.Rows[0]["cid_cod"] != DBNull.Value)
                {
                    Cidade cid = (Cidade)bancoCid.buscaCidade(Convert.ToInt32(dt.Rows[0]["cid_cod"])); // nasci    
                    setCIdade(cid);
                }
                if (dt.Rows[0]["pes_cod"] != DBNull.Value)
                    setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                return this;
            }
            return null;

        }
        public Cliente buscaClienteNOME2(string nome)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteNOME2(nome);
            if (dt.Rows.Count > 0)
            {
                bancoCid = new CidadeBD(Banco.conecta());
                setNome(dt.Rows[0]["pes_nome"].ToString());
                setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                if (dt.Rows[0]["cli_cpf"] != DBNull.Value)
                    cpf = dt.Rows[0]["cli_cpf"].ToString();                
                return this;
            }
            return null;

        }
        public Cliente buscaCliente(string NOME)
        {
            ClienteBD bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaCliente(NOME);
            if (dt.Rows.Count > 0)
            {
                setNome(dt.Rows[0]["pes_nome"].ToString());
                setNum(Convert.ToInt32(dt.Rows[0]["pes_num"]));
                setTelefone(dt.Rows[0]["pes_telefone"].ToString());
                setEmail(dt.Rows[0]["pes_email"].ToString());
                setBairro(dt.Rows[0]["pes_bairro"].ToString());
                setRua(dt.Rows[0]["pes_rua"].ToString());
                setComplemento(dt.Rows[0]["pes_complemento"].ToString());
                setCep(dt.Rows[0]["pes_cep"].ToString());
                cpf = dt.Rows[0]["cli_cpf"].ToString();
                dataNasc = (Convert.ToDateTime(dt.Rows[0]["cli_dataNascimento"]));
                sexo = (Convert.ToChar(dt.Rows[0]["cli_sexo"]));
                setCod(Convert.ToInt32(dt.Rows[0]["pes_cod"]));
                //MessageBox.Show(Convert.ToInt32(dt.Rows[0]["cid_cod"]).ToString());
                // nasci  
                //setCIdade((Cidade)bancoCid.buscaCidade(Convert.ToInt32(dt.Rows[0]["cid_cod"])));
                return this;
            }
            return null;

        }
        public DataTable buscaClienteCPF1(string cpf)
        {
            ClienteBD bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaClienteCPF(cpf);
            return dt;

        }
        public DataTable buscaCliente1(string NOME)
        {
            ClienteBD bancoCli = new ClienteBD(Banco.conecta());
            DataTable dt = bancoCli.buscaCliente(NOME);
            return dt;
            //return null;

        }

        public bool inserir(Cliente c)
        {
            bancoCli = new ClienteBD(Banco.conecta());
            return bancoCli.inserir(c);
        }
    }
}

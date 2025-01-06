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
    class DALCliente
    {
        private Estado estado;
        private Cliente cli;
        private static DALCliente dal = null;
        private Banco banc;
        private ClienteBD bancCli;
        private Cidade cidade;
        private DALCidade dalCid;
        private DALCliente()
        {
            dalCid = DALCidade.novaInstancia();
        }
        public static DALCliente novaInstancia()
        {
            if (dal == null)
                dal = new DALCliente();
            return dal;
        }
        public Cliente buscaClienteCPF(string cpf)
        {
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            c = c.buscaClienteCPF(cpf);
            banc.Desconecta();//**
            return c;

        }
        public DataTable buscaClienteNOME(string nome)
        {
            //bancoU = new UsuarioBD(banco);
            //banco.Conecta();
            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            Cliente c = new Cliente();
            dt = c.buscaClienteNOME(nome);
            b.Desconecta();
            return dt;

        }
        public DataTable buscaClienteCPF2(string cpf)
        {
            //bancoU = new UsuarioBD(banco);
            //banco.Conecta();
            DataTable dt = new DataTable();
            Banco b = Banco.conecta();
            Cliente c = new Cliente();
            dt = c.buscaClienteCPF2(cpf);
            b.Desconecta();
            return dt;

        }
        public Cliente buscaClienteCODIGO(int cod)
        {
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            c = c.buscaClienteCODIGO(cod);
            banc.Desconecta();//**
            return c;
        }
        public bool insereCliente (string nome, string CPF)
        {
            Banco b = Banco.conecta();
            Cliente c;
            c = new Cliente();
            c.setNome(nome);
            c.setCpf(CPF);
            bool res = c.inserir(c);
            b.Desconecta();
            return res;
        }
        public Cliente adicionaCliente (DataRow dr)
        {
            if (dr == null)
                return null;
            Cliente cli = new Cliente();

            cli.setNome(dr["pes_nome"].ToString());
            if (dr["pes_num"]!=DBNull.Value)
                cli.setNum(Convert.ToInt32(dr["pes_num"]));
            if (dr["pes_telefone"] != DBNull.Value)
                cli.setTelefone(dr["pes_telefone"].ToString());
            if (dr["pes_email"] != DBNull.Value)
                cli.setEmail(dr["pes_email"].ToString());
            if (dr["pes_bairro"] != DBNull.Value)
                cli.setBairro(dr["pes_bairro"].ToString());
            if (dr["pes_rua"] != DBNull.Value)
                cli.setRua(dr["pes_rua"].ToString());
            if (dr["pes_complemento"] != DBNull.Value)
                cli.setComplemento(dr["pes_complemento"].ToString());
            if (dr["pes_cep"] != DBNull.Value)
                cli.setCep(dr["pes_cep"].ToString());
            if (dr["cli_cpf"] != DBNull.Value)
                cli.setCpf(dr["cli_cpf"].ToString());
            if (dr["cli_dataNascimento"] != DBNull.Value)
                cli.setdataNasc((Convert.ToDateTime(dr["cli_dataNascimento"])));
            if (dr["cli_sexo"] != DBNull.Value)
                cli.setSexo((Convert.ToChar(dr["cli_sexo"])));
            //MessageBox.Show(Convert.ToInt32(dt.Rows[0]["cid_cod"]).ToString());
            // nasci  
            if (dr["cid_cod"] != DBNull.Value)
            {
                Cidade cid = (Cidade)dalCid.buscarCid(Convert.ToInt32(dr["cid_cod"])); // nasci    
                cli.setCIdade(cid);
            }
            if (dr["pes_cod"] != DBNull.Value)
                cli.setCod(Convert.ToInt32(dr["pes_cod"]));
            return cli;
        }
        public Cliente buscaClienteNOME2(string nome)
        {            
            Cliente cli = new Cliente();
            cli = cli.buscaClienteNOME2(nome);            
            return cli;
        }
        /*public Cliente buscaClienteCPF(string cpf)
        {
            DataTable dt;
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            c = c.buscaClienteCPF(cpf);
            banc.Desconecta();//**
            return c;

        }*/
        public Cliente buscaCliente(string nome)
        {
            DataTable dt;
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            c = c.buscaCliente(nome);
            banc.Desconecta();//**
            return c;

        }
        public DataTable buscaClienteCPF1(string cpf)
        {
            DataTable dt;
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            dt = c.buscaClienteCPF1(cpf);
            banc.Desconecta();//**
            return dt;

        }
        public DataTable buscaCliente1(string nome)
        {
            DataTable dt;
            banc = Banco.conecta();//**
            Cliente c = new Cliente();
            dt = c.buscaCliente1(nome);
            banc.Desconecta();//**
            return dt;

        }
        public bool salvar(String CEP, String Bairro, String telefone, String rua, String nome, int Num, String complemento, int cidcod)
        {
            estado = new Estado(0, "a", "...");
            cidade = new Cidade(cidcod, "a", estado);
            cli = new Cliente();
            cli.setBairro(Bairro);
            cli.setCep(CEP);

            cli.setNome(nome);
            cli.setRua(rua);
            cli.setTelefone(telefone);
            cli.setNum(Num);
            cli.setComplemento(complemento);
            cli.setCIdade(cidade);
            bancCli = new ClienteBD(Banco.conecta());
            return bancCli.insere(cli);

        }
        public int getUltimo(string n)
        {
            bancCli = new ClienteBD(Banco.conecta());
            ///MessageBox.Show(bancCli.buscaClientecod(n).ToString());
            return bancCli.buscaClientecod(n);
        }
    }
}

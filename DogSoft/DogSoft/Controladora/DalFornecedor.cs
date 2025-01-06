using DogSoft.Modelo;
using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Controladora
{
    class DalFornecedor
    {
        private Fornecedor F;
        private Cidade cidade;
        private Estado estado;
        private DALCidade dalC;
        private FornecedorBD fbd;
        private static DalFornecedor dalFun = null;
        private DalFornecedor()
        {
            dalC = DALCidade.novaInstancia();
        }

        public static DalFornecedor novaInstancia()
        {
            if (dalFun == null)
                dalFun = new DalFornecedor();
            return dalFun;
        }
        public bool salvar(String nomeFantasia,String razaoSocial,String CNPJ,String CEP,String Bairro, String email, String telefone, String rua,String nome,int Num,String complemento,int cidcod)
        {
            estado =new Estado(0,"a","...");
            cidade = new Cidade(cidcod, "a", estado);
            F = new Fornecedor(CNPJ,nomeFantasia,razaoSocial);
            F.setBairro(Bairro);
            F.setCep(CEP);
            F.setEmail(email);
            F.setNome(nome);
            F.setRua(rua);
            F.setTelefone(telefone);
            F.setNum(Num);
            F.setComplemento(complemento);
            F.setCIdade(cidade);
            fbd = new FornecedorBD(Banco.conecta());
            return fbd.inserir(F);
                
        }
        public bool alterar(String nomeFantasia, String razaoSocial, String CNPJ, String CEP, String Bairro, String email, String telefone, String rua, String nome, int Num, String complemento, int cidcod,int pescod)
        {
            estado = new Estado(0, "a", "...");
            cidade = new Cidade(cidcod, "a", estado);
            F = new Fornecedor(CNPJ, nomeFantasia, razaoSocial);
            F.setBairro(Bairro);
            F.setCep(CEP);
            F.setEmail(email);
            F.setNome(nome);
            F.setRua(rua);
            F.setTelefone(telefone);
            F.setNum(Num);
            F.setComplemento(complemento);
            F.setCIdade(cidade);
            F.setCod(pescod);
            fbd = new FornecedorBD(Banco.conecta());
            return fbd.alterar(F);

        }
        public bool deletar(int cod)
        {
            fbd = new FornecedorBD(Banco.conecta());
            return fbd.deleta(cod);
        }
        public DataTable buscaNomeFantasia(String NomeFantasia)
        {
            fbd = new FornecedorBD(Banco.conecta());
            return fbd.buscaFornecedor(NomeFantasia);
        }
        public DataTable buscaBairro(String bairro)
        {
            fbd = new FornecedorBD(Banco.conecta());
            return fbd.buscaBairro(bairro);
        }

    }
}

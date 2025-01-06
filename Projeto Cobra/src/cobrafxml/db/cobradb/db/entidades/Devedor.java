

package cobrafxml.db.cobradb.db.entidades;

public class Devedor extends Cobrador
{
    private int cpf, cep;
    private String logradouro, bairro;
    private Cidade cidade;

    public Devedor() {
        this(0, "", "", "", 0, 0, "", "", null);
    }
    

    public Devedor(int cpf, int cep, String logradouro, String bairro, Cidade cidade, String telefone, String email, String nome) {
        this(0, nome, telefone, email, cpf, cep, logradouro, bairro, cidade);
    }

    public Devedor(int codigo, String nome) {
        super(codigo, nome);
    }

    
    public Devedor(int cpf, int cep, String logradouro, String bairro) {
        this.cpf = cpf;
        this.cep = cep;
        this.logradouro = logradouro;
        this.bairro = bairro;
    }

    public Devedor(int cpf, int cep, String bairro, String telefone, String email, String nome) {
        super(telefone, email, nome,null);
        this.cpf = cpf;
        this.cep = cep;
        this.bairro = bairro;
    }
    

    public Devedor(int codigo, String nome, String telefone, String email, int cpf, int cep, String logradouro, String bairro, Cidade cidade) {
        super(codigo, nome, telefone, email,null);
        this.cpf = cpf;
        this.cep = cep;
        this.logradouro = logradouro;
        this.bairro = bairro;
        this.cidade = cidade;
    }



    public int getCpf() {
        return cpf;
    }

    public void setCpf(int cpf) {
        this.cpf = cpf;
    }

    public int getCep() {
        return cep;
    }

    public void setCep(int cep) {
        this.cep = cep;
    }

    public String getLogradouro() {
        return logradouro;
    }

    public void setLogradouro(String logradouro) {
        this.logradouro = logradouro;
    }

    public String getBairro() {
        return bairro;
    }

    public void setBairro(String bairro) {
        this.bairro = bairro;
    }

    public Cidade getCidade() {
        return cidade;
    }

    public void setCidade(Cidade cidade) {
        this.cidade = cidade;
    }
}

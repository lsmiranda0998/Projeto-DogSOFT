package cobrafxml.db.cobradb.db.entidades;

public class Estado
{
    private int id;
    private String nome, sigla;

    public Estado() {
        this(0, "", "");
    }
    
    public Estado(String nome, String sigla) {
        this(0, nome, sigla);
    }
    
    public Estado(int id, String nome, String sigla) {
        this.id = id;
        this.nome = nome;
        this.sigla = sigla;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getSigla() {
        return sigla;
    }

    public void setSigla(String sigla) {
        this.sigla = sigla;
    }

    @Override
    public String toString() {
        return nome;
    }
}

package cobrafxml.db.cobradb.db.entidades;

public class Cidade
{
    private int id;
    private String nome;
    private Estado estado;

    public Cidade() {
        this(0, "", null);
    }

    public Cidade(String nome) {
        this.nome = nome;
    }
    

    public Cidade(String nome, Estado estado) {
        this(0, nome, estado);
    }

    public Cidade(int id, String nome) {
        this.id = id;
        this.nome = nome;
    }
    

    public Cidade(int id, String nome, Estado estado) {
        this.id = id;
        this.nome = nome;
        this.estado = estado;
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

    public Estado getEstado() {
        return estado;
    }

    public void setEstado(Estado estado) {
        this.estado = estado;
    }

    @Override
    public String toString() {
        return nome
                ;
    }
}


package cobrafxml.db.cobradb.db.entidades;

public class Usuario extends Pessoa
{
    private int nivel;
    private String senha;

    public Usuario() {
        this(0, 0, "", "");
    }

    public Usuario(int nivel, String nome, String senha) {
        this(0, nivel, nome, senha);
    }
    
    public Usuario(int codigo, int nivel, String nome, String senha) {
        super(codigo, nome);
        this.nivel = nivel;
        this.senha = senha;
    }

    public int getNivel() {
        return nivel;
    }

    public void setNivel(int nivel) {
        this.nivel = nivel;
    }
    
    public String getSenha(){
        return senha;
    }
    
    public void setSenha(String senha){
        this.senha = senha;
    }
    
}

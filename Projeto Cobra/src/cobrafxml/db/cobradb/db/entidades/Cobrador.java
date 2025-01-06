
package cobrafxml.db.cobradb.db.entidades;

import java.awt.Image;
import java.awt.image.BufferedImage;

public class Cobrador extends Pessoa
{
    private String telefone, email;
    private BufferedImage img;

    public Cobrador() {
        this(0, "", "", "",null);
    }
    
    public Cobrador(String telefone, String email, String nome,BufferedImage img) {
        super(nome);
        this.telefone = telefone;
        this.email = email;
        
    }

    public Cobrador(int codigo, String nome) {
        super(codigo, nome);
    }

    public Cobrador(int codigo, String nome, String telefone, String email,BufferedImage img) {
        super(codigo, nome);
        this.telefone = telefone;
        this.email = email;
        this.img = img;
    }



    public String getTelefone() {
        return telefone;
    }

    public void setTelefone(String telefone) {
        this.telefone = telefone;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
     public Image getImg() {
        return img;
    }
    
}

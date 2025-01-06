
package cobrafxml.db.cobradb.db.entidades;

import java.sql.Date;
import java.time.LocalDate;

public class Lembrete
{
    private int codigo, status;
    private LocalDate data;
    private String texto;

    public Lembrete() {
        this(0, 0, null, "");
    }

    public Lembrete(int status, LocalDate data, String texto) {
        this(0, status, data, texto);
    }

    public Lembrete(int codigo, int status, LocalDate data, String texto) {
        this.codigo = codigo;
        this.status = status;
        this.data = data;
        this.texto = texto;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public int getStatus() {
        return status;
    }

    public void setStatus(int status) {
        this.status = status;
    }

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    @Override
    public String toString() {
        return texto;
    }
}

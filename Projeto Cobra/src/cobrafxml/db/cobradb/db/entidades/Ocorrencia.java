
package cobrafxml.db.cobradb.db.entidades;

import java.sql.Date;
import java.time.LocalDate;

public class Ocorrencia
{
    private int codigo;
    private LocalDate data;
    private String anotacao;

    public Ocorrencia() {
        this(0, null, "");
    }

    public Ocorrencia(LocalDate data, String anotacao) {
        this(0, data, anotacao);
    }

    public Ocorrencia(int codigo, LocalDate data, String anotacao) {
        this.codigo = codigo;
        this.data = data;
        this.anotacao = anotacao;
    }



    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }

    public String getAnotacao() {
        return anotacao;
    }

    public void setAnotacao(String anotacao) {
        this.anotacao = anotacao;
    }

    @Override
    public String toString() {
        return anotacao;
    }
}

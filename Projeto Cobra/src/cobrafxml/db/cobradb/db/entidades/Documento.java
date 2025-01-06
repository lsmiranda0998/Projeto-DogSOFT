
package cobrafxml.db.cobradb.db.entidades;

import java.io.RandomAccessFile;
import java.time.LocalDate;

public class Documento
{
    private int codigo;
    private String descricao;
    private LocalDate data;
    private RandomAccessFile dados;

    public Documento() {
        this(0, "", null, null);
    }

    public Documento(String descricao, LocalDate data, RandomAccessFile dados) {
        this(0, descricao, data, dados);
    }

    public Documento(int codigo, String descricao, LocalDate data, RandomAccessFile dados) {
        this.codigo = codigo;
        this.descricao = descricao;
        this.data = data;
        this.dados = dados;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public String getDescricao() {
        return descricao;
    }

    public void setDescricao(String descricao) {
        this.descricao = descricao;
    }

    public LocalDate getData() {
        return data;
    }

    public void setData(LocalDate data) {
        this.data = data;
    }

    public RandomAccessFile getDados() {
        return dados;
    }

    public void setDados(RandomAccessFile dados) {
        this.dados = dados;
    }

    @Override
    public String toString() {
        return descricao;
    }
}


package cobrafxml.db.cobradb.db.entidades;

import java.sql.Date;
import java.time.LocalDate;
import java.util.ArrayList;

public class Cobranca
{
    private int codigo;
    private double valor;
    private LocalDate data;
    private String texto;
    private Origem origem;
    private Situacao situacao;
    private Cobrador cobrador;
    private Devedor devedor;
    private ArrayList <Lembrete> lembretes;
    private ArrayList <Ocorrencia>ocorrencias;
    private ArrayList <Documento> documentos;

      public Cobranca(int codigo, double valor, LocalDate data, String texto) {
        this.codigo = codigo;
        this.valor = valor;
        this.data = data;
        this.texto = texto;
    }
    public Cobranca() {
        this(0, 0, null, "", null, null, null, null);
        lembretes = new ArrayList<>();
        ocorrencias = new ArrayList<>();
        documentos =  new ArrayList<>();
        
    }
    

  


    
    public Cobranca(double valor, LocalDate data, String texto, Origem origem, Situacao situacao, Cobrador cobrador, Devedor devedor) {
        this(0, valor, data, texto, origem, situacao, cobrador, devedor);
        lembretes = new ArrayList<>();
        ocorrencias = new ArrayList<>();
        documentos =  new ArrayList<>();
    }

    public Cobranca(int codigo, double valor, LocalDate data, String texto, Origem origem, Situacao situacao, Cobrador cobrador, Devedor devedor) {
        this.codigo = codigo;
        this.valor = valor;
        this.data = data;
        this.texto = texto;
        this.origem = origem;
        this.situacao = situacao;
        this.cobrador = cobrador;
        this.devedor = devedor;
        lembretes = new ArrayList<>();
        ocorrencias = new ArrayList<>();
        documentos =  new ArrayList<>();
    }


   


    
    
    public void addLembrete(Lembrete novo)
    {
        this.lembretes.add(novo);
    }
    
    public void addOcorrencia(Ocorrencia nova)
    {
        this.ocorrencias.add(nova);
    }
    
    /*public void addDocumento(Documento doc)
    {
        this.documentos.add(doc);
    }*/

    
    public Lembrete buscLembrete(int cod)
    {
        Lembrete l = lembretes.get(0), aux;  
        
        for(int i = 0; i < lembretes.size() && l.getCodigo() != cod; i++)
        {
            aux = (Lembrete) lembretes.get(i);
            if(aux.getCodigo() == cod)
                l = aux;
        }
        return l;
    }
    
    public Ocorrencia buscOcorrencia(int cod)
    {
        Ocorrencia o = null, aux;
        
        for(int i = 0; i < ocorrencias.size(); i++)
        {
            aux = (Ocorrencia) ocorrencias.get(i);
            if(aux.getCodigo() == cod)
                o = aux;
        }
        return o;
    }
    
    public Documento buscDocumento(int cod)
    {
        Documento doc = null, aux;
        
        for(int i = 0; i < documentos.size(); i++)
        {
            aux = (Documento) documentos.get(i);
            if(aux.getCodigo() == cod)
                doc = aux;
        }
        return doc;
    }
    
    public double getValor()
    {
        return valor;
    }
    
    public void setValor(double valor)
    {
        this.valor = valor;
    }
    
    public LocalDate getData()
    {
        return data;
    }
    
    
    public void setData(LocalDate data)
    {
        this.data = data;
    }
   
    public String getTexto()
    {
        return texto;
    }
    
    public void setTexto(String texto)
    {
        this.texto = texto;
    }

    public int getCodigo() {
        return codigo;
    }

    public void setCodigo(int codigo) {
        this.codigo = codigo;
    }

    public Origem getOrigem() {
        return origem;
    }

    public void setOrigem(Origem origem) {
        this.origem = origem;
    }

    public Situacao getSituacao() {
        return situacao;
    }

    public void setSituacao(Situacao situacao) {
        this.situacao = situacao;
    }

    public ArrayList getLembretes() {
        return lembretes;
    }

    public void setLembretes(ArrayList lembretes) {
        this.lembretes = lembretes;
    }

    public ArrayList getOcorrencias() {
        return ocorrencias;
    }

    public void setOcorrencias(ArrayList ocorrencias) {
        this.ocorrencias = ocorrencias;
    }

    public ArrayList getDocumentos() {
        return documentos;
    }

    public void setDocumentos(ArrayList documentos) {
        this.documentos = documentos;
    }

    public Cobrador getCobrador() {
        return cobrador;
    }

    public void setCobrador(Cobrador cobrador) {
        this.cobrador = cobrador;
    }

    public Devedor getDevedor() {
        return devedor;
    }

    public void setDevedor(Devedor devedor) {
        this.devedor = devedor;
    }
    public ArrayList buscAllLembrete()
    {
        return lembretes;
    }
    
    public ArrayList buscAllOcorrencia()
    {
        return ocorrencias;
    }
     public ArrayList buscAllDocumento()
    {
        return documentos;
    }

}

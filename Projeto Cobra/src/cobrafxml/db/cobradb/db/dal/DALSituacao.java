
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Situacao;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class DALSituacao
{
    private Situacao situacao;
    private String sql;
    private ResultSet rs;
    
    public DALSituacao(){
        this(null);
    } 
    public DALSituacao(Situacao situacao){
        this.situacao = situacao;
    }  
    public boolean cadSituacao(Situacao sit)
    {
        sql = "insert into situacao (sit_descricao) values ('$1')";     
        sql = sql.replace("$1", sit.getDescricao());       
        return Banco.getCon().manipular(sql);
    }
    
    public boolean altSituacao(Situacao sit)
    {
        sql = "update situacao set sit_descricao = '$1' where sit_cod ="+sit.getCodigo();
        
        sql = sql.replace("$1", sit.getDescricao());
        
        return Banco.getCon().manipular(sql);
    }
    
    public boolean excSituacao(int codigo)
    {
        sql = "delete from situacao where sit_cod ="+codigo;
        
        return Banco.getCon().manipular(sql);
    }
    
    public Situacao buscSituacao(int codigo)
    {
        Situacao s;        
        sql = "select * from situacao where sit_cod ="+codigo;        
        try
        {
            rs = Banco.getCon().consultar(sql);       
            s = new Situacao(rs.getInt("sit_cod"), rs.getString("sit_descricao"));
        }
        catch(Exception e)
        {
            s = null;
        } 
        return s;
    }
    
    public ArrayList buscaTodos(String filtro)
    {
        ArrayList listSit = new ArrayList<Situacao>();  
        sql = "select * from situacao";
        String sql = "select * from Situacao";
        if (!filtro.isEmpty())
            sql += "where " + filtro;       
        try
        {
            rs = Banco.getCon().consultar(sql);
            while(rs.next())
            {
                listSit.add(new Situacao(rs.getInt("sit_cod"), rs.getString("sit_descricao")));
            }
        }
        catch(Exception e)
        {
            listSit = null;
        }
        
        return listSit;
    }
}

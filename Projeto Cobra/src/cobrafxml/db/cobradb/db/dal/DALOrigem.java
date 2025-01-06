
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Origem;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class DALOrigem
{
    private String sql;
    private Origem origem;
    private ResultSet rs;
    
    public DALOrigem(){
        this(null);
    }
    
    public DALOrigem(Origem origem){
        this.origem = origem;
    }
    
    public boolean cadOrigem(Origem or)
    {
        sql = "insert into origem (org_descricao) values ('$1')";
        
        sql = sql.replace("$1", or.getDescricao());
        
        return Banco.getCon().manipular(sql);
    }
    
    public boolean altOrigem(Origem or)
    {
        sql = "update origem set org_descricao = '$1' where org_cod ="+or.getCodigo();
        
        sql = sql.replace("$1", or.getDescricao());
        
        return Banco.getCon().manipular(sql);
    }
    
    public boolean excOrigem(int codigo)
    {
        sql = "delete from origem where org_cod ="+codigo;
        
        return Banco.getCon().manipular(sql);
    }
    
    public Origem buscOrigem(int codigo)
    {
        Origem o;
        
        sql = "select *from origem where org_cod ="+codigo;
        
        try
        {
            rs = Banco.getCon().consultar(sql);
            
            o = new Origem(rs.getInt("org_cod"), rs.getString("org_descricao"));
        }
        catch(Exception e)
        {
            o  = null;
        }
        
        return o;
    }
    
    public ArrayList<Origem> buscarTodos (String filtro)
    {      
        ArrayList<Origem> ori = new ArrayList();
        String sql = "select * from Origem";
        if (!filtro.isEmpty())
            sql += "where " + filtro;
        ResultSet rs = Banco.getCon().consultar(sql);
        try
        {
            while(rs.next())
            {
                ori.add(new Origem(rs.getInt("org_cod"),
                                rs.getString("org_descricao")));
            }
        }catch(Exception e)
        {
            System.out.println(e);
        }
        return ori;  
    }
}

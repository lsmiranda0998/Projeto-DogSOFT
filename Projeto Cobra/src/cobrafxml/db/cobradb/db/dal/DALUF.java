
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Estado;
import java.sql.ResultSet;
import java.util.ArrayList;

public class DALUF
{
    private Estado estado;
    private String sql;
    
    public DALUF(){
        this.estado = null;
    }
    
    public boolean cadEstado(Estado es)
    {
        sql = "insert into estado (est_sgl, est_nome) values ('$1', '$2')";

        sql = sql.replace("$1", es.getSigla());
        sql = sql.replace("$2", es.getNome());
        System.out.println(sql);
        return Banco.getCon().manipular(sql);
    }
    
    public boolean altEstado(Estado est)
    {
        sql = "update estado set est_sgl = '$1', est_nome = '$2' where est_cod =" +est.getId();
        
        sql = sql.replace("$1", est.getSigla());
        sql = sql.replace("$2", est.getNome());
        
        return Banco.getCon().manipular(sql);
    }
    
    public boolean excEstado(int codigo)
    {
        sql = "delete from estado where est_cod ="+codigo;
        
        return Banco.getCon().manipular(sql);
    }
    public Estado buscar(int chave)
    {
        Estado e = null;
        String sql = "select * from estado where est_cod = " + chave;    
        ResultSet rs = Banco.getCon().consultar(sql);
        
        try{                 
            e = new Estado (rs.getInt("est_cod"), rs.getString("est_sgl"), rs.getString("est_nome"));
        
        }
        catch(Exception ex)
        {
            System.out.println("Error: " + ex.getMessage());
        }
        return e;
    }
    public ArrayList buscaTodos(int codigo)
    {
       ArrayList lista = new ArrayList<Estado>();
        
        sql = "select *from estado where est_cod = $1";
        sql = sql.replace("$1", ""+codigo);
        
        ResultSet rs = Banco.getCon().consultar(sql);
        
        try
        {
            while(rs.next())
            {
                lista.add(new Estado(rs.getString("est_nome"), rs.getString("est_sgl")));
            }
        }
        catch(Exception e)
        {
            System.out.println("CtrEstado: ocorreu um erro!");
        }
        
        return lista;
    }
}

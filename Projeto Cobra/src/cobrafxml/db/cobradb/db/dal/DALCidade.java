
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Cidade;
import cobrafxml.db.cobradb.db.entidades.Estado;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;

public class DALCidade
{
    private Cidade cidade;
    private String sql;
    private DALUF contUF = new DALUF();
    
    public DALCidade(Cidade cidade)
    {
        this.cidade = cidade;
    }

    public DALCidade() {
    }
    
    
    public boolean cadCidade()
    {
        sql = "insert into cidade (est_cod, cid_nome) values ($1, '$2')";
        sql = sql.replace("$1", ""+cidade.getEstado().getId());
        sql = sql.replace("$2", cidade.getNome());
        return Banco.getCon().manipular(sql);
    }
    
    public boolean altCidade(Cidade cid)
    {
        sql = "update cidade set est_cod = $1, cid_nome = '$2' where cid_cod ="+cid.getId();
        
        sql = sql.replace("$1", ""+cid.getEstado().getId());
        sql = sql.replace("$2", cid.getNome());
        
        return Banco.getCon().manipular(sql);
    }
    
    public boolean excluiCidade()
    {
        sql = "delete from cidade where cid_cod ="+cidade.getId();
        
        return Banco.getCon().manipular(sql);
    }
    
    public Cidade buscaCidade(int codigo)
    {
        ArrayList list = new ArrayList<Cidade>();
        ArrayList list2 = new ArrayList<Estado>();
        Estado uf;
        Cidade c = null;
        
        sql = "select * from cidade where cid_cod ="+codigo;
        ResultSet rs = Banco.getCon().consultar(sql);

        try
        {
            list2 = contUF.buscaTodos(rs.getInt("est_cod"));
            uf =(Estado) list2.get(0);
            
            c = new Cidade(rs.getInt("cid_cod"), rs.getString("cid_nome"), new Estado(uf.getId(), uf.getNome(), uf.getSigla()));
        }
        catch(Exception e)
        { 
            System.out.println("DALCidade: Ocorreu um erro!");
        }
        return c;
    }
    
    public ArrayList buscaAllCid(String filtro)
    {
        ArrayList listCid = new ArrayList<Cidade>();
        DALUF dalUF = new DALUF();
        ResultSet rs;
        String sql = "select * from Cidade";
        if (!filtro.isEmpty())
            sql += "where " + filtro;
        rs = Banco.getCon().consultar(sql);
        
        try
        {
           
           while(rs.next())
           {
               listCid.add(new Cidade(rs.getInt("cid_cod"),                               
                                rs.getString("cid_nome"),
                                dalUF.buscar(rs.getInt("est_cod"))));
           }
        }
        catch(Exception e)
        {
            listCid = null;
        }
        
        return listCid;
    }
    /*public ArrayList buscaTodasCID(String filtro)
    {
        ArrayList listCid = new ArrayList<Cidade>();
      
        ResultSet rs;
        String sql = "select * from cidade";
        if (!filtro.isEmpty())
            sql += "where " + filtro;
        rs = Banco.getCon().consultar(sql);
        
        try
        {
           
           while(rs.next())
           {
               listCid.add(new Cidade(
                                rs.getInt("cid_cod"),
                                rs.getString("cid_nome");
                                ));
           }
        }
        catch(Exception e)
        {
            listCid = null;
        }
        
        return listCid;
    }*/
}

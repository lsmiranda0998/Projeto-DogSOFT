/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Cobranca;
import cobrafxml.db.cobradb.db.entidades.Documento;
import cobrafxml.db.cobradb.db.entidades.Lembrete;
import cobrafxml.db.cobradb.db.entidades.Ocorrencia;
import java.sql.SQLException;
import java.util.ArrayList;

/**
 *
 * @author Aluno
 */
public class DALCobranca {

    private String sql;
    
    
    public boolean inserirLembrete (ArrayList<Lembrete> l, int cobraCod)
    {
        boolean retorno =  true;
        //if (l.isEmpty())
            
        for (int i=0;i<l.size() && retorno;i++)
        {
            sql = "insert into lembrete (lem_data,lem_texto,cob_cod,lem_status) values ($2, '$3', $4, $5)";
          
            sql = sql.replace("$2",""+l.get(i).getData());
            sql = sql.replace("$3",l.get(i).getTexto());
            sql = sql.replace ("$4",""+cobraCod);
            sql = sql.replace ("$5",""+l.get(i).getStatus());
            retorno = Banco.getCon().manipular(sql);
        }
        return retorno;      
    }
    public boolean inserirOcorrencia (ArrayList<Ocorrencia> o, int cobraCod)
    {
        boolean retorno =  true;
        for (int i=0;i<o.size() && retorno;i++)
        {
            sql = "insert into ocorrencia (oco_data,oco_anotacao,cob_cod) values ($2, '$3', $4)";
           
            sql = sql.replace("$2",""+o.get(i).getData());
            sql = sql.replace("$3",o.get(i).getAnotacao());
            sql = sql.replace ("$4",""+cobraCod);
            retorno = Banco.getCon().manipular(sql);
        }
        return retorno;      
    }
    public boolean inserirDocumento (ArrayList<Documento>d, int cobraCod)
    {
        boolean retorno = true;
        for (int i=0;i<d.size() && retorno;i++)
        {
            sql = "insert into documentos (doc_descr,doc_data,doc_dados,cob_cod) values ('$2', $3, '$4', $5)";
           
            sql = sql.replace("$2",d.get(i).getDescricao());
            sql = sql.replace("$3",d.get(i).getData().toString());
            sql = sql.replace ("$4",d.get(i).getDados().toString());
            sql = sql.replace ("$5",""+cobraCod);
            retorno = Banco.getCon().manipular(sql);
        }

        return retorno; 
    }
    private boolean excluirLembrete (Cobranca c)
    {
        if(c.getLembretes().size() > 0)
        {
            String sql = "delete from Lembrete where cobranca_cod = " + c.getCodigo();
            return Banco.getCon().manipular(sql);
        }
        return true;
    }
    private boolean excluirOcorrencia (Cobranca c)
    {        
        if(c.getOcorrencias().size() > 0)
        {
            String sql = "delete from Ocorrencia where cobranca_cod = " + c.getCodigo();
            return Banco.getCon().manipular(sql);
        }
        return true;
    }
     private boolean excluirDocumento (Cobranca c)
    {        
        if(c.getDocumentos().size() > 0)
        {
            String sql = "delete from Documento where cobranca_cod = " + c.getCodigo();
            return Banco.getCon().manipular(sql);
        }
        return true;
    }
    public boolean gravarCobranca(Cobranca c)
    {
        ArrayList listOc = new ArrayList<Ocorrencia>();
       ArrayList listLb = new ArrayList<Lembrete>();
       ArrayList listDc = new ArrayList<Documento>();
        /*try {
            Banco.getCon().getConnect().setAutoCommit(false);
        } catch (SQLException ex) {
            System.out.println("Erro no autocommit!");
        }
        sql = "insert into cobranca (cob_valor,cob_data,cob_texto,org_cod,sit_cod,cbr_cod,dev_cod) values ($2, $3,$4,'$5',$6,$7,$8)";
        
        sql = sql.replace("$2", ""+c.getValor());
        sql = sql.replace("$3",c.getData().toString());
        sql = sql.replace("$4", ""+c.getOrigem().getCodigo());
        sql = sql.replace ("$5",c.getTexto());
        sql = sql.replace ("$6",""+c.getSituacao().getCodigo());
        sql = sql.replace ("$7",""+c.getCobrador().getCodigo());
        sql = sql.replace ("$8",""+c.getDevedor().getCodigo());
        if (Banco.getCon().manipular(sql))
        {
           try 
           {
               int t = Banco.getCon().getMaxPK("cobranca", "cobranca_cod");
               c.setCodigo(t);
              if(inserirOcorrencia(c.getOcorrencias(), c.getCodigo()) && inserirLembrete(c.getLembretes(), c.getCodigo()))
              {
                   Banco.getCon().getConnect().commit();
                   return true;
              }
                   
           } 
           catch (SQLException ex)
           {
              System.out.println("Erro no commit!");
           }
        }            
        else
        {
            try 
            {
                Banco.getCon().getConnect().rollback();
            } 
            catch (SQLException ex) 
            {
                System.out.println("Erro no roolback!");
            }
        }
        try {
            Banco.getCon().getConnect().setAutoCommit(true);
        } catch (SQLException ex) {
            System.out.println("Erro no autocommit!");
        }
        return false;    */
        Ocorrencia ocorrencia;
       Lembrete lembrete;
       Documento documento;
       
       int erro = 0, codigo = 0;
       
       listOc = c.buscAllOcorrencia();
       listLb = c.buscAllLembrete();
       listDc = c.buscAllDocumento();
       
       /*try
       {
           Banco.getCon().getConnect().setAutoCommit(false);
       }
       catch(Exception e){};*/
       
       //inserir cobrança
       try
       {
        sql = "INSERT INTO cobranca "
                + "(cob_valor, cob_data, cob_texto, org_cod, sit_cod, cbr_cod, dev_cod)"
                + " values ($1, '$2', '$3', $4, $5, $6, $7)";

        sql = sql.replace("$1", ""+c.getValor());
        sql = sql.replace("$2", c.getData().toString());
        sql = sql.replace("$3", c.getTexto());
        sql = sql.replace("$4", ""+c.getOrigem().getCodigo());
        sql = sql.replace("$5", ""+c.getSituacao().getCodigo());
        sql = sql.replace("$6", ""+c.getCobrador().getCodigo());
        sql = sql.replace("$7", ""+c.getDevedor().getCodigo());
        
        Banco.getCon().manipular(sql);
        //recupera a última cobrança salva
        codigo = Banco.getCon().getMaxPK("cobranca", "cob_cod");
       
        
       }
       catch(Exception e){erro++; System.out.println("1- "+e.getMessage());}
       
       //inserir lembretes
       try
       {
        for(int i = 0; i < listLb.size(); i++)
        {
            lembrete = (Lembrete) listLb.get(i);

            sql = "INSERT INTO lembrete (lem_data, lem_texto, cob_cod, lem_status) values ('$1', '$2', $3, $4)";

            sql = sql.replace("$1", ""+lembrete.getData());
            sql = sql.replace("$2", lembrete.getTexto());
            sql = sql.replace("$3", ""+codigo);
            sql = sql.replace("$4", ""+lembrete.getStatus());
            
            Banco.getCon().manipular(sql);
        }
       }
       catch(Exception e){erro++;System.out.println("2- "+e.getMessage());}
       
       //inserir ocorrencias
       try
       {
        for(int j = 0; j < listOc.size(); j++)
        {
            ocorrencia = (Ocorrencia) listOc.get(j);

            sql = "INSERT INTO ocorrencia (oco_data, oco_anotacao, cob_cod) values ('$1', '$2', $3)";

            sql = sql.replace("$1", ocorrencia.getData().toString());
            sql = sql.replace("$2", ocorrencia.getAnotacao());
            sql = sql.replace("$3", ""+codigo);
            
            Banco.getCon().manipular(sql);
        }

       }
       catch(Exception e){erro++;System.out.println("3- "+e.getMessage());}
       
       //inserir documentos
       /*try
       {
           for(int k = 0; k < listDc.size(); k++)
           {
               documento = (Documento) listDc.get(k);
               
               sql = "INSERT INTO documentos (doc_descr, doc_data, doc_dados, cob_cod) VALUES ('$1', '$2', $3, $4)";
               
               sql = sql.replace("$1", documento.getDescricao());
               sql = sql.replace("$2", documento.getData().toString());
               sql = sql.replace("$3", documento.getDados().toString());
               
               Banco.getCon().manipular(sql);
           }
           Banco.getCon().getConnect().commit();
   
       }
       catch(Exception e){}
       
       try
       {
           Banco.getCon().getConnect().setAutoCommit(true);
           return true;
       }
       catch(Exception e){}*/
       
       if(erro == 0)
           return true;
       return false;
    }
    
    public boolean deletaCobranca(Cobranca c)
    {
        try {
            Banco.getCon().getConnect().setAutoCommit(false);
        } catch (SQLException ex) {
            System.out.println("Erro no autocommit!");
            return false;
        }
        sql = "delete from cobranca where cob_cod = "+c.getCodigo();
        if (Banco.getCon().manipular(sql))
        {
           try 
           {
              if (excluirLembrete(c) && excluirOcorrencia(c) && excluirDocumento(c))
              {
                  Banco.getCon().getConnect().commit();
                  Banco.getCon().getConnect().setAutoCommit(true);
                  return true;
              }
                    
              else
              {
                  Banco.getCon().getConnect().rollback();
                  Banco.getCon().getConnect().setAutoCommit(true);
                  return false;
              }
                    

           } 
           catch (SQLException ex)
           {
               
              System.out.println("Erro no commit!");
              return false;
           }
         }            
        else
        {
            try 
            {
                Banco.getCon().getConnect().rollback();
                Banco.getCon().getConnect().setAutoCommit(true);
            } 
            catch (SQLException ex) 
            {
                System.out.println("Erro no roolback!");
                
            }
            return false;
        }

   
        
    }
    public boolean setCobranca(Cobranca c)
    {
        try {
            Banco.getCon().getConnect().setAutoCommit(false);
        } catch (SQLException ex) {
            System.out.println("Erro no auto commit!");
            return false;
        }
        sql = "update cobranca set cob_valor = '$2', cob_data = $3, cob_text = '$4', org_cod = $5, sit_cod = $6, cbr_cod = $7, dev_cod = $8 where cob_cod ="+c.getCodigo(); 
       
        sql = sql.replace("$2", ""+c.getValor());
        sql = sql.replace("$3", ""+c.getData());
        sql = sql.replace("$4", ""+c.getOrigem().getCodigo());
        sql = sql.replace ("$5",c.getTexto());
        sql = sql.replace ("$6",""+c.getSituacao().getCodigo());
        sql = sql.replace ("$7",""+c.getCobrador().getCodigo());
        sql = sql.replace ("$8",""+c.getDevedor().getCodigo()); 
        if (Banco.getCon().manipular(sql))
        {
           try 
           {
              Banco.getCon().getConnect().commit();
           } 
           catch (SQLException ex)
           {
              System.out.println("Erro no commit!");
              return false;
           }
         }            
        else
        {
            try 
            {
                Banco.getCon().getConnect().rollback();
            } 
            catch (SQLException ex) 
            {
                System.out.println("Erro no roolback!");
                return false;
            }
        }
        ArrayList lembretes = c.getLembretes();
        ArrayList ocorrencias = c.getOcorrencias();
        ArrayList documentos = c.getDocumentos();
        for (int i=0;i<lembretes.size();i++)
        {
            Lembrete l = (Lembrete) lembretes.get(i);
            sql = "update lembretes set lem_cod = $1, lem_data = $2, lem_text = '$3', cob_cod = $4, lem_status = $5 where cob_cod ="+c.getCodigo();
            sql = sql.replace("$1", ""+l.getCodigo());
            sql = sql.replace("$2",l.getData().toString());
            sql = sql.replace("$3",l.getTexto());
            sql = sql.replace ("$4",""+c.getCodigo());
            sql = sql.replace ("$5",""+l.getStatus());
            if (Banco.getCon().manipular(sql))
            {
               try 
               {
                  Banco.getCon().getConnect().commit();
               } 
               catch (SQLException ex)
               {
                  System.out.println("Erro no commit!");
                  return false;
               }
             }            
            else
            {
                try 
                {
                    Banco.getCon().getConnect().rollback();
                } 
                catch (SQLException ex) 
                {
                    System.out.println("Erro no roolback!");
                    return false;
                }
            }
        }
        
        for (int i=0;i<ocorrencias.size();i++)
        {
            Ocorrencia o = (Ocorrencia) ocorrencias.get(i);
            sql = "update ocorrencia set oco_cod = $1, oco_data = $2, oco_anotacao = '$3', cob_cod = $4 where cob_cod ="+c.getCodigo();
            sql = sql.replace("$1", ""+o.getCodigo());
            sql = sql.replace("$2",o.getData().toString());
            sql = sql.replace("$3",o.getAnotacao());
            sql = sql.replace ("$4",""+c.getCodigo());
            if (Banco.getCon().manipular(sql))
            {
                try 
                {
                   Banco.getCon().getConnect().commit();
                } 
                catch (SQLException ex)
                {
                   System.out.println("Erro no commit!");
                   return false;
                }
             }            
            else
             {
                try 
                {
                    Banco.getCon().getConnect().rollback();
                } 
                catch (SQLException ex) 
                {
                    System.out.println("Erro no roolback!");
                    return false;
                }
             }
        }
          for (int i=0;i<documentos.size();i++)
        {
            Documento d = (Documento) documentos.get(i);
            sql = "update documentos set doc_cod = $1, doc_descr = '$2', doc_data = $3, doc_dados = '$4', cob_cod = $5 where cob_cod ="+c.getCodigo();
            sql = sql.replace("$1", ""+d.getCodigo());
            sql = sql.replace("$2",d.getDescricao());
            sql = sql.replace("$3",d.getData().toString());
            sql = sql.replace ("$4",d.getDados().toString());
            sql = sql.replace ("$5",""+c.getCodigo());
            if (Banco.getCon().manipular(sql))
            {
               try 
               {
                  Banco.getCon().getConnect().commit();
               } 
               catch (SQLException ex)
               {
                  System.out.println("Erro no commit!");
                  return false;
               }
             }            
            else
             {
                try 
                {
                    Banco.getCon().getConnect().rollback();
                } 
                catch (SQLException ex) 
                {
                    System.out.println("Erro no roolback!");
                    return false;
                }
             }
               
            
        }
       
        try {
            Banco.getCon().getConnect().setAutoCommit(true);
        } catch (SQLException ex) {
            System.out.println("Erro no autocommit!");
            return false;
        }
        return true;
    }
    /*public Cobranca getCobranca (int codigo)
    {
        DALOrigem dalO = null;
        DALSituacao dalS = null;
        DALPessoa dalP = null;
        Origem o;
        Ocorrencia oco;
        Situacao s;
        Pessoa cbr;
        Pessoa dev;
        try {
            Banco.getCon().getConnect().setAutoCommit(false);
        } catch (SQLException ex) {
            System.out.println("Erro no autocommit!");
        }
        sql = "select * from cobranca where cob_cod ="+codigo;
        // cob_cod,cob_valor,cob_data,cob_texto,org_cod,sit_cod,cbr_cod,dev_cod
        ResultSet rs = Banco.getCon().consultar(sql);
        Cobranca c;
        try {
            c = new Cobranca (rs.getInt("cob_cod"),rs.getDouble("cob_valor"),rs.getDate("cob_data"),rs.getString("cob_texto"));
            o =  dalO.buscOrigem(rs.getInt("org_cod"));
            c.setOrigem(o);
            s =  dalS.buscSituacao(rs.getInt("sit_cod"));
            c.setSituacao(s);
            cbr = dalP.getPessoa(rs.getInt("cbr_cod"),3);
            c.setCobrador((Cobrador) cbr);
            dev = dalP.getPessoa(rs.getInt("dev_cod"), 2);
            c.setDevedor((Devedor) dev);
            
            
        } catch (SQLException ex) {
            c = null;
        }
        sql = "select * from lembrete where cob_cod ="+c.getCodigo();
        ResultSet rst = Banco.getCon().consultar(sql);
        ArrayList listLembretes = new ArrayList<Lembrete>();
        try {
            while (rst.next())
            {
                //listLembretes.add(new Lembrete (rst.getInt("lem_cod"),rst.getInt("lem_status"),rst.getDate("lem_data"),rst.getString("lem_texto")));
            }
        } catch (SQLException ex) {
            Logger.getLogger(DALCobranca.class.getName()).log(Level.SEVERE, null, ex);
        }
        for (int i=0;i<listLembretes.size();i++)
        {
           c.addLembrete((Lembrete) listLembretes.get(i));
        }
        sql = "select * from ocorrencias where cob_cod ="+c.getCodigo();
        rst = Banco.getCon().consultar(sql);
        ArrayList listOcorrencias = new ArrayList<Ocorrencia>();
        try {
           while (rst.next())
           {
               //listOcorrencias.add(new Ocorrencia (rst.getInt("oco_cod"),rst.getDate("oco_data"),rst.getString("oco_anotacao")));
           }
        } catch (SQLException ex) {
            Logger.getLogger(DALCobranca.class.getName()).log(Level.SEVERE, null, ex);
        }
        for (int i=0;i<listOcorrencias.size();i++)
        {
           c.addOcorrencia((Ocorrencia) listOcorrencias.get(i));
        }

         return c;  
    }*/
    
}

    


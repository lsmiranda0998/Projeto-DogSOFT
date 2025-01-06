package cobrafxml.db.cobradb;
//singleton

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.RandomAccessFile;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import javax.swing.JOptionPane;

public class Banco 
{   static private Conexao con;
    private Banco() { }
    static public boolean conectar()
    {
        con=new Conexao();
        return con.conectar("jdbc:postgresql://localhost/", 
                "cobra", "postgres", "postgres123");
    }
    static public Conexao getCon()
    {   return con;
    }    
    public static boolean criarBD(String BD)
    { try{
        String url = "jdbc:postgresql://localhost/";
        Connection con = DriverManager.getConnection(url,"postgres","postgres123");

        Statement statement = con.createStatement();
        statement.execute("CREATE DATABASE "+BD+" WITH OWNER = postgres ENCODING = 'UTF8'  "
                                + "TABLESPACE = pg_default LC_COLLATE = 'Portuguese_Brazil.1252'  "
                                + "LC_CTYPE = 'Portuguese_Brazil.1252'  CONNECTION LIMIT = -1;");
        statement.close();
        con.close();
      }catch(Exception e)
      {  System.out.println(e.getMessage()); return false;}
         return true;                
    }
    public static boolean criarTabelas(String script,String BD)
    { try{
        String url = "jdbc:postgresql://localhost/"+BD;
        Connection con = DriverManager.getConnection(url, "postgres","postgres123");

        Statement statement = con.createStatement();
        RandomAccessFile arq=new RandomAccessFile(script, "r");
        while(arq.getFilePointer() < arq.length()) 
             statement.addBatch(arq.readLine());
        statement.executeBatch();

        statement.close();
        con.close();
      }catch(Exception e)
      {  System.out.println(e.getMessage()); return false;}
      return true;
    }
    public static String realizaBackup() {
        String linha = "",tudo="";
        Runtime r = Runtime.getRuntime();
        try {
            Process p = r.exec("scripts/backup.bat");
            if (p != null) {
                InputStreamReader str = new InputStreamReader(p.getErrorStream());
                BufferedReader reader = new BufferedReader(str);
                
                while ((linha = reader.readLine()) != null) {
                    System.out.println(linha);
                    tudo+=linha+'\n';
                }
            }
            JOptionPane.showMessageDialog(null, tudo+"Backup realizado com sucesso!");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null, tudo+"Erro no backup!\n"+linha + ex.getMessage());
        }
        return linha;
    }
    public static String realizaRestore() {
        String linha = "",tudo="";
        Runtime r = Runtime.getRuntime();
        try {
            Process p = r.exec("scripts/restore.bat");
            if (p != null) {
                InputStreamReader str = new InputStreamReader(p.getErrorStream());
                BufferedReader reader = new BufferedReader(str);
                
                while ((linha = reader.readLine()) != null) {
                    System.out.println(linha);
                    tudo+=linha+'\n';
                }
            }
            JOptionPane.showMessageDialog(null, tudo+"Restaurado realizado com sucesso!");
        } catch (IOException ex) {
            JOptionPane.showMessageDialog(null, tudo+"Erro ao restaurar!\n"+linha + ex.getMessage());
        }
        return linha;
    }


}

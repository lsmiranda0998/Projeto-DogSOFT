
package cobrafxml.db.cobradb.db.dal;

import cobrafxml.db.cobradb.Banco;
import cobrafxml.db.cobradb.db.entidades.Cidade;
import cobrafxml.db.cobradb.db.entidades.Cobrador;
import cobrafxml.db.cobradb.db.entidades.Devedor;
import cobrafxml.db.cobradb.db.entidades.Estado;
import cobrafxml.db.cobradb.db.entidades.Pessoa;
import cobrafxml.db.cobradb.db.entidades.Usuario;
import java.awt.image.BufferedImage;
import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.InputStream;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.List;
import javax.imageio.ImageIO;

public class DALPessoa
{
        private String sql;
        private ResultSet rs;


        //uma dal para as três "herancas"
        public boolean gravarPessoa (Pessoa p)
        {
            if (p instanceof Usuario)
            {
                 sql = "insert into usuario (usr_nome,usr_nivel, usr_senha) values ('$2',$3,'$4')";
             
                 sql = sql.replace("$2",p.getNome());
                 sql = sql.replace("$3", ""+((Usuario) p).getNivel());
                 sql = sql.replace("$4",((Usuario) p).getSenha());
                 return Banco.getCon().manipular(sql);
            }
            
            else if (p instanceof Devedor)
            {
                 sql = "insert into devedor (dev_nome,dev_cpf,dev_cep,dev_logradouro,dev_bairro,cid_cod,dev_telefone,dev_email) values ('$2',$3,$4,'$5','$6',$7,'$8','$9')";
              
                 sql = sql.replace("$2",p.getNome());
                 sql = sql.replace("$3", ""+((Devedor) p).getCpf());
                 sql = sql.replace("$4",""+((Devedor) p).getCep());
                 sql = sql.replace("$5",((Devedor) p).getLogradouro());
                 sql = sql.replace("$6",((Devedor) p).getBairro());
                 sql = sql.replace("$7",""+((Devedor) p).getCidade().getId());
                 sql = sql.replace("$8",((Devedor) p).getTelefone());
                 sql = sql.replace("$9",((Devedor) p).getEmail());
                 return Banco.getCon().manipular(sql);
            }
            else if (p instanceof Cobrador)
            {
                sql = "insert into cobrador (cbr_nome,cbr_telefone,cbr_email) values ('$2','$3','$4')";
                
                sql = sql.replace("$2",p.getNome());
                sql = sql.replace("$3",((Cobrador) p).getTelefone());
                sql = sql.replace("$4",((Cobrador) p).getEmail());
                Banco.getCon().manipular(sql);
                int codigo = Banco.getCon().getMaxPK("cobrador", "cbr_cod");
                SalvarImagem(codigo, (BufferedImage) ((Cobrador) p).getImg());
                return true;
            }
          return false;
                
            
        }
        public boolean setPessoa (Pessoa p)
        {
            if (p instanceof Usuario)
            {
                 sql = "update usuario set usr_nome = '$2', usr_nivel = $3, usr_senha = '$4' where usr_codigo ="+p.getCodigo();
               
                 sql = sql.replace("$2",p.getNome());
                 sql = sql.replace("$3", ""+((Usuario) p).getNivel());
                 sql = sql.replace("$4",((Usuario) p).getSenha());
                 return Banco.getCon().manipular(sql);
            }
            
            else if (p instanceof Devedor)
            {
                 sql = "update devedor set dev_nome = '$2', dev_cpf = $3, dev_cep = $4, dev_logradouro = '$5', dev_bairro = '$6', dev_cidade = $7, dev_telefone = $8, dev_email = $9, where dev_codigo ="+p.getCodigo();
  
                 sql = sql.replace("$2",p.getNome());
                 sql = sql.replace("$3", ""+((Devedor) p).getCpf());
                 sql = sql.replace("$4",""+((Devedor) p).getCep());
                 sql = sql.replace("$5",((Devedor) p).getLogradouro());
                 sql = sql.replace("$6",((Devedor) p).getBairro());
                 sql = sql.replace("$7",""+((Devedor) p).getCidade().getId());
                 sql = sql.replace("$8",((Devedor) p).getTelefone());
                 sql = sql.replace("$9",((Devedor) p).getEmail());
                 return Banco.getCon().manipular(sql);
            }
            else if (p instanceof Cobrador)
            {
                sql = "update cobrador set cbr_nome = '$2', cbr_telefone = '$3', cbr_email = '$4' where cbr_codigo ="+p.getCodigo();

                sql = sql.replace("$2",p.getNome());
                sql = sql.replace("$3",((Cobrador) p).getTelefone());
                sql = sql.replace("$4",((Cobrador) p).getEmail());
                
                return Banco.getCon().manipular(sql);
            }
          return false;
        }
        public boolean excluiPessoa (Pessoa p)
        {
            if (p instanceof Usuario)
            {
                sql = "delete from usuario where usr_cod ="+p.getCodigo();      
                return Banco.getCon().manipular(sql);
            }
            else if (p instanceof Devedor)
            {
                System.out.println(""+p.getCodigo());
                sql = "delete from devedor where dev_cod ="+p.getCodigo();      
                return Banco.getCon().manipular(sql);
            }
            else if (p instanceof Cobrador)
            {
                sql = "delete from cobrador where cbr_cod ="+p.getCodigo();      
                return Banco.getCon().manipular(sql);
            }
            return false;
        }
        public Pessoa getPessoa(int codigo, int flag)
        {
            Usuario usuario;
            Devedor devedor;
            Cobrador cobrador;
            
            ArrayList list = new ArrayList<Pessoa>();
            if (flag == 1)
            {
                sql = "select * from usuario where usr_cod ="+codigo;
                
            }              
            else if (flag == 2)
            {
                //System.out.println(""+codigo);
                sql = "select * from devedor where dev_cod ="+codigo;
            
            }
             
            else
            {
                sql = "select * from cobrador where cbr_cod ="+codigo;
                
            }
            ResultSet rs = Banco.getCon().consultar(sql);
            try
            {
                if (flag == 1)
                    return usuario = new Usuario(rs.getInt("usr_cod"), rs.getInt("usr_nivel"), rs.getString("usr_nome"), rs.getString("usr_senha"));
                else if (flag == 2)
                    return devedor = (new Devedor (rs.getInt("dev_cod"), rs.getString("dev_nome"), rs.getString("dev_telefone"), rs.getString("dev_email"), rs.getInt("dev_cpf"), rs.getInt("dev_cep"), rs.getString("dev_logradouro"), rs.getString("dev_bairro"), (Cidade) rs.getObject("dev_cidade")));
                else if (flag == 3)
                    return cobrador = (new Cobrador(rs.getInt("cbr_cod"), rs.getString("cbr_nome"), rs.getString("cbr_telefone"), rs.getString("cbr_email"),null));
                else
                    return null;

                
            }
            catch(Exception e)
            { 
                System.out.println("DALPessoa: Ocorreu um erro!");
            }
            return null;
         
        }
        public ArrayList getAllPessoas (Pessoa p,String filtro)
        {
            if (p instanceof Usuario)
            {
                sql = "select * from usuario";
                if (!filtro.isEmpty())
                    sql += "where " + filtro;
                // public Usuario(int codigo, int nivel, String nome, String senha) {
                ArrayList listUsuario = new ArrayList<Usuario>();
                try
                {
                    rs = Banco.getCon().consultar(sql);
                    while(rs.next())
                    {
                        listUsuario.add(new Usuario(rs.getInt("usr_cod"), rs.getInt("usr_nivel"), rs.getString("usr_nome"),rs.getString("usr_senha")));
                    }
                }
                catch(Exception e)
                {
                    listUsuario = null;
                }
        
                return listUsuario;
               
            }  
            else if (p instanceof Devedor)
            {
               sql = "select * from devedor";
               if (!filtro.isEmpty())
                sql += "where " + filtro;
               ArrayList listDevedor = new ArrayList<Devedor>();
               DALCidade dalC = null;
               Cidade c;
                try
                {
                    //public Devedor(int codigo, String nome, String telefone, String email, int cpf, int cep, String logradouro, String bairro, Cidade cidade)
                    rs = Banco.getCon().consultar(sql);
                    while(rs.next())
                    {
                       
                        //c = dalC.buscaCidade(rs.getInt("cid_cod"));
                        listDevedor.add(new Devedor(rs.getInt("dev_cod"), rs.getString("dev_nome")));
                        
                    }
                }
                catch(Exception e)
                {
                    listDevedor = null;
                }
        
                return listDevedor;
            }            
            /*else if (p instanceof Devedor)
            {
               sql = "select * from devedor";
               if (!filtro.isEmpty())
                sql += "where " + filtro;
               ArrayList listDevedor = new ArrayList<Devedor>();
               DALCidade dalC = null;
               Cidade c;
                try
                {
                    //public Devedor(int codigo, String nome, String telefone, String email, int cpf, int cep, String logradouro, String bairro, Cidade cidade)
                    rs = Banco.getCon().consultar(sql);
                    while(rs.next())
                    {
                        c = dalC.buscaCidade(rs.getInt("cid_cod"));
                        listDevedor.add(new Devedor(rs.getInt("dev_cod"), rs.getString("dev_nome"), rs.getString("dev_telefone"),rs.getString("dev_email"),rs.getInt("dev_cpf"),rs.getInt("dev_cep"),rs.getString("dev_logradouro"),rs.getString("dev_bairro"),c));
                    }
                }
                catch(Exception e)
                {
                    listDevedor = null;
                }
        
                return listDevedor;
            }*/
             
            else if (p instanceof Cobrador)
            {
               sql = "select * from cobrador";
               if (!filtro.isEmpty())
                sql += "where " + filtro;
               ArrayList listCobrador = new ArrayList<Cobrador>();
  
                try
                {
                    //public Cobrador(int codigo, String nome, String telefone, String email)
                    rs = Banco.getCon().consultar(sql);
                    while(rs.next())
                    {
                        
                        listCobrador.add(new Cobrador(rs.getInt("cbr_cod"), rs.getString("cbr_nome"), rs.getString("cbr_telefone"),rs.getString("cbr_email"),recuperarImg(rs.getInt("cbr_cod"))));
                    }
                }
                catch(Exception e)
                {
                    listCobrador = null;
                }
        
                return listCobrador;
            
            }
           return null;    
        }
    public boolean SalvarImagem(int codigo, BufferedImage img)
    {
        try
        {
           PreparedStatement st = Banco.getCon().getConnect().prepareStatement(
                "update cobrador set cbr_foto=? where cbr_cod=?");
           
           ByteArrayOutputStream baos = new ByteArrayOutputStream();
           ImageIO.write(img, "jpg", baos);
           InputStream is = new ByteArrayInputStream(baos.toByteArray());
           st.setBinaryStream(1, is, baos.toByteArray().length);//primeiro ?
           st.setInt(2, codigo);//segundo ?
           st.executeUpdate();
           return true;
           
        }catch(Exception e)
        {System.out.println(e);}
        return false;
    }
    
    public BufferedImage recuperarImg(int codigo)
    {
        BufferedImage bImageFromConvert = null;
        try
        {
            PreparedStatement ps = Banco.getCon().getConnect().prepareStatement("SELECT cbr_foto FROM cobrador WHERE cbr_cod = "+codigo);
            //ps.setString(1, ""+codigo);
            ResultSet rs = ps.executeQuery();
            if (rs.next()) {
              byte[] imgBytes = rs.getBytes("cbr_foto");
              // transforma um byte[] em uma imagem  
              InputStream in = new ByteArrayInputStream(imgBytes);
              bImageFromConvert = ImageIO.read(in);
            }
            rs.close();
            ps.close();
        }
        catch(Exception e){}
        return bImageFromConvert;
    }
}
      
                
                
        /*
        salvar:
        public .....(Pessoa  p)
        if(p instanceof Usuário)
        
        
        o mesmo ocorre para o alterar e o apagar
        
        public get (Pessoa p) //uma instance do objeto que carrega o código
        */
    


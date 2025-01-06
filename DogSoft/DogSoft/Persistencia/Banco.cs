using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DogSoft.Persistencia
{
    public class Banco
    {
        private static Banco b = null;

        private String strcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Desktop\Eng 2 2019\DogSoft\DogSoft\DogSoft.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection con = null;
        private SqlTransaction trans = null;

        private Banco()
        {
            try
            {
                con = new SqlConnection(strcon);
                con.Open();

            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro conexão" + e.Message);
            }
        }
        //Singleton em todas as controladoras
        public static Banco conecta()
        {
            if (b == null)
            {
                b = new Banco();
            }
            return b;
        }

        public bool Conecta()
        {
            bool resultado = false;
            try
            {
                con = new SqlConnection(strcon);
                con.Open();
                resultado = true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro conexão" + e.Message);
            }
            return resultado;
        }

        public void Desconecta()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
            {
                con.Close();
                con = null;
                b = null;// nao sei se isto esta correto , mas n funciona sem isso
            }
        }

        public void BeginTransaction()
        {
            if ((con != null) && (con.State == System.Data.ConnectionState.Open))
                trans = con.BeginTransaction();
        }

        public void CommitTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Commit();
                trans = null;
            }
        }

        public void RollbackTransaction()
        {
            if ((con != null) && (trans != null) && (con.State == System.Data.ConnectionState.Open))
            {
                trans.Rollback();
                trans = null;
            }
        }

        public bool ExecuteQuery(String sql, out DataTable dt, params Object[] parametros) // para fazer select, parametro(sql, DataTable, passa aos pares o nome do parametros e o valor)
        {
            dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);//nome do parâmetro e o valor ex(pos 0 nome e pos 1 valor)
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute query" + e.Message);
                return false;
            }
        }

        public bool ExecuteNonQuery(String sql, params Object[] parametros)//insert, update e delete
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Transaction = trans;
                for (int i = 0; i < parametros.Length; i += 2)
                    cmd.Parameters.AddWithValue(parametros[i].ToString(), parametros[i + 1]);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("Erro execute nonquery" + e.Message);
                return false;
            }
        }

        public int GetIdentity()//buscar o ultimo codigo gerado
        {
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", con);
            object o = cmd.ExecuteScalar();
            try
            {
                if (o != null)
                    return Convert.ToInt32(o);
                else
                    return 0;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public SqlConnection getcon()
        {
            return con;
        }
    }
}

using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class AtendimentoBD
    {
        private Banco banco;
        public AtendimentoBD(Banco banco)
        {
            this.banco = banco;
        }
        public int getLastCOD()
        {
            return banco.GetIdentity();
        }
        public bool insereAtendimento(Atendimento a,out int cod)
        {
            string SQL;
            
            SQL = @"INSERT INTO Atendimento (cli_cod,fun_cod,mes_cod,aten_status,aten_valorFinal,aten_data) 
                        VALUES (@CLI,@FUN,@MES,@STATUS,@VALOR,@DATA)";
            bool res = banco.ExecuteNonQuery(SQL, "@CLI", a.Cli.getCod(), "@FUN", a.Fun.getCod(), "@MES",a.Mesa.getCod(), "@STATUS", a.Status, "@VALOR", a.ValorFinal, "@DATA",a.Data);
            cod = banco.GetIdentity();
            return res;
        }
        public bool alteraAtendimento(Atendimento a,int cod)
        {
            string SQL;          
            SQL = @"UPDATE Atendimento SET
                    cli_cod=@CLI, fun_cod=@FUN, mes_cod=@MES, aten_status=@STATUS, aten_valorFinal=@VALOR, aten_data=@DATA WHERE aten_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@CLI", a.Cli.getCod(), "@FUN", a.Fun.getCod(), "@MES", a.Mesa.getCod(), "@STATUS", a.Status, "@VALOR", a.ValorFinal, "@DATA", a.Data,"@COD",cod);
          
        }
        public bool deletaITENS(int cod)
        {
           
            string SQL = @"DELETE FROM Itens_Atendimento WHERE aten_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod);

        }
        public bool insereITENS(DataRow dr, bool flag,int cod)
        {
            string SQL;
            decimal valorUnit = Convert.ToDecimal(Convert.ToDecimal(dr["Valor"]));
            int qtde = Convert.ToInt32(dr["Quantidade"]);  
            if (flag)
            {
                SQL = @"INSERT INTO Itens_Atendimento (aten_cod,ita_valorUnitario,ita_qtde,cmb_cod) 
                        VALUES (@ATEN,@VALOR,@QTDE,@CMB)";
                return banco.ExecuteNonQuery(SQL, "@ATEN",cod , "@VALOR", valorUnit, "@QTDE",qtde, "@CMB", Convert.ToInt32(dr["cmb_cod"]));
                
            }
            SQL = @"INSERT INTO Itens_Atendimento (aten_cod,ita_valorUnitario,ita_qtde,pro_cod) 
                        VALUES (@ATEN,@VALOR,@QTDE,@PRO)";
            return banco.ExecuteNonQuery(SQL, "@ATEN", cod, "@VALOR", valorUnit, "@QTDE", qtde, "@PRO", Convert.ToInt32(dr["pro_cod"]));

        }
        public DataTable buscaAtenCODIGO(int cod)
        {
            DataTable dt;
            string SQL = @"SELECT * FROM Atendimento WHERE aten_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);
            return dt;
        }
        public DataTable buscaAtenCLI(string nome)
        {
            DataTable dt;
            string SQL = @"SELECT cli_cod,aten_cod,aten_status,aten_valorFinal,aten_data,pes_nome,mes_cod,fun_login FROM Atendimento a INNER JOIN Pessoa p on a.cli_cod = p.pes_cod INNER JOIN Funcionario f on f.pes_cod = fun_cod WHERE pes_nome LIKE @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", nome+"%");
            return dt;
        }
        public DataTable buscaAtenDATA(DateTime data)
        {
            DataTable dt;
            string SQL = @"SELECT cli_cod,aten_cod,aten_status,aten_valorFinal,aten_data,pes_nome,mes_cod,fun_login FROM Atendimento a INNER JOIN Pessoa p on a.cli_cod = p.pes_cod INNER JOIN Funcionario f on f.pes_cod = fun_cod WHERE aten_data = @DATA";
            banco.ExecuteQuery(SQL, out dt, "@DATA", data);
            return dt;
        }
        public DataTable buscaItens(int cod)
        {
            DataTable dt;
            string SQL = @"SELECT * FROM Itens_Atendimento WHERE aten_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);
            return dt;
        }
        public bool atualizaAtendimento(Atendimento a)
        {

            string SQL = @"UPDATE Atendimento SET
                        aten_status = @STATUS,forma_cod=@FORMA,aten_valorFINAL=@VALOR WHERE aten_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@STATUS", a.Status,"@FORMA",a.Forma.getCodigo(),"@VALOR",a.ValorFinal, "@COD", a.Codigo);
        }
    }
}

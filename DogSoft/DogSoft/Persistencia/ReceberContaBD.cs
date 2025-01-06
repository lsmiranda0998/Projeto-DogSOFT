using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogSoft.Persistencia
{
    class ReceberContaBD
    {
        private Banco banco;
        public ReceberContaBD(Banco banco)
        {
            this.banco = banco;
        }
        public DataTable buscaContaCODIGO (int cod)
        {
            DataTable dt;
            string SQL = @"SELECT * FROM Contas_a_receber WHERE cr_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD",cod);
            return dt;
        }
        public DataTable buscaContaVALORES(Cliente c, double valorIni, double valorFinal,bool flag)
        {
            string situacao;
            if (flag)
                situacao = "PENDENTE";
            else
                situacao = "BAIXADA";
            string SQL;
            DataTable dt;
            //MessageBox.Show(valorIni.ToString() + "--" + valorFinal.ToString());
            if (c==null)
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE cr_valor between @VALORINI AND @VALORFINAL AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt,"@VALORINI", valorIni, "@VALORFINAL", valorFinal, "@SIT", situacao);
            }
            else
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE p.pes_cod = @COD AND cr_valor between @VALORINI AND @VALORFINAL AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt, "@COD", c.getCod(), "@VALORINI", valorIni, "@VALORFINAL", valorFinal,"@SIT",situacao);
            }
           
            return dt;
        }
        public DataTable buscaConta(Cliente c, DateTime dataVencINI, DateTime dataVencFINAL,bool flag)
        {         
            string SQL;
            string situacao;
            if (flag)
                situacao = "PENDENTE";
            else
                situacao = "BAIXADA";

            DataTable dt;
            if (c==null)
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE cr_dataVenc between @DATAINI and @DATAFIM AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt, "@DATAINI", dataVencINI, "@DATAFIM", dataVencFINAL, "@SIT", situacao);
            }
            else
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE p.pes_cod = @COD AND cr_dataVenc between @DATAINI and @DATAFIM AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt, "@COD", c.getCod(), "@DATAINI", dataVencINI, "@DATAFIM", dataVencFINAL, "@SIT", situacao);
            }            
            return dt;          
        }
        public DataTable buscaContaVENCIDAS(Cliente c, bool flag)
        {
            string situacao;
            if (flag)
                situacao = "PENDENTE";
            else
                situacao = "BAIXADA";
            string SQL;
            DataTable dt;
            DateTime data = DateTime.Today.AddDays(-1);
            if (c==null)
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE cr_dataVenc <= @DATA AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt, "@DATA", data, "@SIT", situacao);
            }
            else
            {
                SQL = @"SELECT cr_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE p.pes_cod = @COD AND cr_dataVenc <= @DATA AND cr_situacao = @SIT";
                banco.ExecuteQuery(SQL, out dt, "@COD", c.getCod(), "@DATA", data,"@SIT",situacao);
            }
            
            return dt;
        }
        public bool atualizaConta(ReceberConta co)
        {
            string SQL;
            if (co.DataPago == null || co.ValorPago == null)
            {
                SQL = @"UPDATE Contas_a_receber SET
                        cr_observacao=@OBS, cr_situacao=@SIT, cr_dataPagamento=@DATA, cr_valorPago=@VALOR,cr_valor=@VALOR2 WHERE cr_cod = @COD";
                return banco.ExecuteNonQuery(SQL, "@OBS", co.Observacao, "@SIT", co.Situacao, "@DATA", DBNull.Value, "@VALOR", DBNull.Value,"@VALOR2",co.Valor, "@COD", co.Cod);
            }

            SQL = @"UPDATE Contas_a_receber SET
                        cr_observacao=@OBS, cr_situacao=@SIT, cr_dataPagamento=@DATA, cr_valorPago=@VALOR,cr_valor=@VALOR2 WHERE cr_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@OBS", co.Observacao, "@SIT", co.Situacao, "@DATA", co.DataPago, "@VALOR", co.ValorPago,"@VALOR2",co.Valor, "@COD", co.Cod);

        }
        public DataTable buscaContaATENDIMENTO(int cod)
        {
            string SQL; 
            DataTable dt;          
            SQL = @"SELECT * FROM Contas_a_receber WHERE aten_cod = @COD";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod);
            return dt;
        }
        public DataTable buscaContaATENDIMENTO2(int cod)
        {
            string SQL;
            DataTable dt;
            SQL = @"SELECT * FROM Contas_a_receber WHERE aten_cod = @COD AND cr_situacao = @sit";
            banco.ExecuteQuery(SQL, out dt, "@COD", cod,"@sit","PENDENTE");
            return dt;
        }
        public DataTable buscaContaHOJE(Cliente c, bool flag)
        {
            string SQL;
            string situacao;
            if (flag)
                situacao = "PENDENTE";
            else
                situacao = "BAIXADA";
            DataTable dt;
            DateTime data = DateTime.Today;
            //MessageBox.Show(data.ToString());
            SQL = @"SELECT aten_cod,cr_observacao,cr_valorPago,cr_dataPagamento,cr_cod,cr_situacao,pes_nome,aten_data,cr_dataVenc,aten_valorFinal,cr_valor FROM cliente c INNER JOIN Pessoa p on c.pes_cod = p.pes_cod INNER JOIN Atendimento a on a.cli_cod = p.pes_cod INNER JOIN Contas_a_receber cr on cr.aten_cod = a.aten_cod WHERE p.pes_cod = @COD AND cr_dataVenc = @DATA AND cr_situacao = @SIT";
            banco.ExecuteQuery(SQL, out dt, "@COD", c.getCod(), "@DATA", data,"@SIT",situacao);
            return dt;
        }
        public bool inserirConta(ReceberConta co)
        {
            string SQL;
         
            SQL = @"INSERT INTO Contas_a_receber (aten_cod,cr_observacao,cr_dataVenc,cr_valor,cr_situacao) 
                        VALUES (@ATEN,@OBS,@DATAVENC,@VALOR,@SIT)";
            return banco.ExecuteNonQuery(SQL, "@ATEN", co.Aten.Codigo,"@OBS", co.Observacao, "@DATAVENC", co.DataVenc, "@VALOR", co.Valor, "@SIT", co.Situacao);
            
        }
        public bool inserirContaRGP(ReceberConta co,int cod)
        {
            string SQL;
            //MessageBox.Show(cod +" | "+co.Observacao + " | "+co.DataVenc +" | "+ co.Valor+" | " + co.Situacao);
            SQL = @"INSERT INTO Contas_a_receber (rgp_cod,cr_observacao,cr_dataVenc,cr_valor,cr_situacao) 
                        VALUES (@ATEN,@OBS,@DATAVENC,@VALOR,@SIT)";
            return banco.ExecuteNonQuery(SQL, "@ATEN", cod, "@OBS", co.Observacao, "@DATAVENC", co.DataVenc, "@VALOR", co.Valor, "@SIT", co.Situacao);

        }
        public bool deletaConta(ReceberConta co)
        {
            string SQL;

            SQL = @"DELETE FROM Contas_a_receber WHERE cr_cod = @COD";
            
            return banco.ExecuteNonQuery(SQL, "@COD", co.Cod);

        }
        public bool inserirContaATEN(ReceberConta co)
        {
            string SQL;
            if (co.DataPago == null)
            {
                SQL = @"INSERT INTO Contas_a_receber (aten_cod,cr_observacao,cr_dataVenc,cr_valor,cr_situacao,cr_valorPago,cr_dataPagamento) 
                        VALUES (@ATEN,@OBS,@DATAVENC,@VALOR,@SIT,@VALORP,@DATAP)";
                return banco.ExecuteNonQuery(SQL, "@ATEN", co.Aten.Codigo, "@OBS", co.Observacao, "@DATAVENC", co.DataVenc, "@VALOR", co.Valor, "@SIT", co.Situacao, "@VALORP", co.ValorPago, "@DATAP", DBNull.Value);
            }
            SQL = @"INSERT INTO Contas_a_receber (aten_cod,cr_observacao,cr_dataVenc,cr_valor,cr_situacao,cr_valorPago,cr_dataPagamento) 
                        VALUES (@ATEN,@OBS,@DATAVENC,@VALOR,@SIT,@VALORP,@DATAP)";
            return banco.ExecuteNonQuery(SQL, "@ATEN", co.Aten.Codigo, "@OBS", co.Observacao, "@DATAVENC", co.DataVenc, "@VALOR", co.Valor, "@SIT", co.Situacao,"@VALORP",co.ValorPago,"@DATAP",co.DataPago);
            
        }
    }
}

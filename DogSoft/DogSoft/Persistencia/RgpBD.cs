using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class RgpBD
    {
        private Banco banco;
        public RgpBD(Banco banco)
        {
            this.banco = banco;
        }

        public bool inserir(Rgp r)
        {
            string SQL;

            SQL = @"INSERT INTO Registrar_Pedido (rgp_dataHorario,rgp_descricao,rgp_valorTotal,rgp_troco,forma_cod,cli_cod,fun_cod,rgp_status) 
                        VALUES (@DATA,@DESCRICAO,@VAL,@TROCO,@FORMA,@CLIENTE,@FUNCIONARIO,@STATUS)";
            return banco.ExecuteNonQuery(SQL, "@DATA", r.getdata(), "@DESCRICAO", r.getDescricao(), "@VAL", r.getvalortot(), "@TROCO", r.gettroco(), "@FORMA", r.getformacod(), "@CLIENTE", r.getclicod(), "@FUNCIONARIO", r.getfuncioanriocod(), "@STATUS","aberto");

        }
        public bool deletar(int cod)
        {
            string SQL;
            itpBD itp = new itpBD(banco);
            ProdutoBD p = new ProdutoBD(banco);
            DataTable dt = itp.busca(cod);
            for(int i=0;i<dt.Rows.Count;i++)
            {
                if(p.buscaprodutostatus(Convert.ToInt32(dt.Rows[i]["pro_cod"]))== "venda")
                {
                    p.incrementaEstoque(Convert.ToInt32(dt.Rows[i]["pro_cod"]), Convert.ToInt32(dt.Rows[i]["itp_qtde"]));

                }
            }
            /*SQL = @"DELETE FROM Registrar_Pedido WHERE rgp_cod = @COD";*/
            SQL = "UPDATE Registrar_Pedido SET rgp_status = 'cancelado' WHERE rgp_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod);

        }
        public bool deletar2(int cod)
        {
            string SQL;

            /*SQL = @"DELETE FROM Registrar_Pedido WHERE rgp_cod = @COD";*/
            SQL = "UPDATE Registrar_Pedido SET rgp_status = 'finalizado' WHERE rgp_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod);

        }
        public DataTable buscaCli(string bairro)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT p.pes_nome,p2.pes_nome,f.cli_cod,f.fun_cod,fr.forma_descricao,f.rgp_dataHorario,f.rgp_troco,f.rgp_descricao,f.rgp_cod,f.rgp_valorTotal, p.pes_bairro,p.pes_rua,p.pes_num FROM Registrar_Pedido f INNER JOIN Pessoa p on f.cli_cod = p.pes_cod INNER JOIN Pessoa p2 on f.fun_cod = p2.pes_cod INNER JOIN Forma_pagamento fr on f.forma_cod = fr.forma_cod WHERE p.pes_nome LIKE @NOME AND rgp_status='aberto'";
            banco.ExecuteQuery(SQL, out dt, "@NOME", bairro + "%");
            return dt;
        }
    }
}

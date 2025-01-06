using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class EntregaBD
    {
        private Banco banco;
        public EntregaBD(Banco banco)
        {
            this.banco = banco;
        }

        public bool inserir(Entrega r)
        {
            string SQL;

            SQL = @"INSERT INTO Entrega (ent_valorRecebido,ent_frete,ent_dataSaida,ent_dataRetorno,rgp_cod,fun_cod,ent_erro) 
                        VALUES (@VAL,@FRETE,@SAIDA,@RETORNO,@RGP,@FUNCIONARIO,@erro)";
            return banco.ExecuteNonQuery(SQL, "@VAL", r.ValorRecebido, "@FRETE", r.Frete, "@SAIDA", r.Saida, "@RETORNO", r.Retorno, "@RGP", r.Rgpcod, "@FUNCIONARIO", r.Funcod,"@erro",r.Erro);

        }
       /* public bool deletar(int cod)
        {
            string SQL;

            SQL = @"DELETE FROM Registrar_Pedido WHERE rgp_cod = @COD";
            return banco.ExecuteNonQuery(SQL, "@COD", cod);

        }
        public DataTable buscaCli(string bairro)
        {
            DataTable dt = new DataTable();
            string SQL = @"SELECT p.pes_nome,p2.pes_nome,f.cli_cod,f.fun_cod,fr.forma_descricao,f.rgp_dataHorario,f.rgp_troco,f.rgp_descricao,f.rgp_cod,f.rgp_valorTotal, p.pes_bairro,p.pes_rua,p.pes_num FROM Registrar_Pedido f INNER JOIN Pessoa p on f.cli_cod = p.pes_cod INNER JOIN Pessoa p2 on f.fun_cod = p2.pes_cod INNER JOIN Forma_pagamento fr on f.forma_cod = fr.forma_cod WHERE p.pes_nome LIKE @NOME";
            banco.ExecuteQuery(SQL, out dt, "@NOME", bairro + "%");
            return dt;
        }*/
    }
}


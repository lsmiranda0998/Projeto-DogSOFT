using DogSoft.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Persistencia
{
    class FluxoCaixaBD
    {
        private Banco banco;
        public FluxoCaixaBD(Banco banco)
        {
            this.banco = banco;
        }
        public bool adicionaMovimento(FluxoCaixa fc)
        {

            string SQL = @"INSERT INTO Movimentos_caixa (caixa_cod,mov_valor,mov_tipo,mov_observacao,mov_data) 
                        VALUES (@COD,@VALOR,@TIPO,@OBS,@DATA)";
            return banco.ExecuteNonQuery(SQL, "@COD", fc.Cx.Cod, "@VALOR", fc.Valor, "@TIPO", fc.Tipo, "@OBS", fc.Obs, "@DATA", fc.Data);
            
        }
    }
}

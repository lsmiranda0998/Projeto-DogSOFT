using DogSoft.Persistencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogSoft.Modelo
{
    class Mesa
    {
        private int cod;
        private string status;
        private MesaBD bancoMesa;
        public int getCod()
        {
            return cod;
        }
        public void setCod(int cod)
        {
            this.cod = cod;
        }
        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
        public DataTable buscaMesas()
        {
            bancoMesa = new MesaBD(Banco.conecta());
            DataTable dt = bancoMesa.buscaMesas();
            return dt;
        }
        public Mesa buscaMesaCODIGO(int cod)
        {
            bancoMesa = new MesaBD(Banco.conecta());
            DataTable dt = bancoMesa.buscaMesaCODIGO(cod);
            if (dt.Rows.Count > 0)
            {
                this.cod = Convert.ToInt32(dt.Rows[0]["mes_cod"]);
                this.status = dt.Rows[0]["mes_status"].ToString();
                return this;
            }
            return null;

        }
        public bool atualizaMesa(Mesa m)
        {
            bancoMesa= new MesaBD(Banco.conecta());
            return bancoMesa.atualizaMesa(m);
        }
    }
}

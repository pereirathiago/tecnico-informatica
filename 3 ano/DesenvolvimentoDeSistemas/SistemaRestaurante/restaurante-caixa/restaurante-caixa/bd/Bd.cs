using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante_caixa.bd
{
    internal class Bd
    {
        public string User;
        public string bd;
        public string Senha;
        public string Servidor;
        public MySqlConnection Connection;

        public Bd()
        {
            Connection = new MySqlConnection();
        }

        public void Open()
        {
            string strConnString = "server=" + Servidor + ";User id=" + User + ";password=" + Senha + ";database=" + bd + ";sslmode=none;";
            if (Connection.State == System.Data.ConnectionState.Broken || Connection.State == System.Data.ConnectionState.Closed)
            {
                Connection = new MySqlConnection();
                Connection.ConnectionString = strConnString;
                Connection.Open();
            }
        }

        public void Close()
        {
            Connection.Close();
        }
    }
}

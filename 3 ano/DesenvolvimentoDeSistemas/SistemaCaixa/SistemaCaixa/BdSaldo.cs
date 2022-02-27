using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaCaixa
{
    class BdSaldo : Bd
    {
        public BdSaldo()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "caixa";
        }

        public DataTable PreencheTabela()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable saldo = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from saldo";
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(saldo);
                return saldo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}

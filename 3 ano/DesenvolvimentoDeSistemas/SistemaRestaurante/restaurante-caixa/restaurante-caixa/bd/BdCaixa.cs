using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_caixa.bd
{
    internal class BdCaixa : Bd
    {
        public BdCaixa()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "restaurante";
        }

        public DataTable PreencheTabelaPedidos(string mesa)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable pratos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from pedido where mesa like @mesa and status != 'Fechado'";
                cmd.Parameters.AddWithValue("@mesa", mesa);
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(pratos);
                return pratos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void fechaPedido(string mesa, string status)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update pedido set status = @status where mesa= @mesa and status != 'Fechado'";
                cmd.Parameters.AddWithValue("@mesa", mesa);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Connection = Connection;
                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool VerificaLogin(string usuario, string senha)
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from admin_users where username = @username and senha= @senha and funcao = 2";
                cmd.Parameters.AddWithValue("@username", usuario);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                cmd.Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

    }
}

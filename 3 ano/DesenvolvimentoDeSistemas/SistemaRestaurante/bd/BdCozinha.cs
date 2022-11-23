using MySql.Data.MySqlClient;
using restaurante_cozinha.vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurante_cozinha.bd
{
    internal class BdCozinha : Bd
    {
        public BdCozinha()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "restaurante";
        }

        public DataTable PreencheTabelaPedidos(string pedido)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable pratos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from pedidos where pedido like @pedido";
                cmd.Parameters.AddWithValue("@pedido", "%" + pedido + "%");
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

        public void atualizaPrato(Pedido pedido)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update pedidos set status = @status, descricao = @descricao, preco = @preco where id = @id";
                cmd.Parameters.AddWithValue("@id", pedido.Id);
                cmd.Parameters.AddWithValue("@status", pedido.Status);
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
                cmd.CommandText = "select * from admin_users where usuario = @usuario and senha= @senha";
                cmd.Parameters.AddWithValue("@usuario", usuario);
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

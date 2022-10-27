using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using restaurant_admin.vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurant_admin.bd
{
    internal class BdPratos : Bd
    {
        public BdPratos()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "restaurante";
        }

        public DataTable PreencheTabelaPratos(string nome)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable pratos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from admin_pratos where nome like @nome";
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
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

        public void cadastrarPrato(Pratos pratos)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into admin_pratos (nome, descricao, preco) values (@nome, @descricao, @preco)";
                cmd.Parameters.AddWithValue("@nome", pratos.Nome);
                cmd.Parameters.AddWithValue("@descricao", pratos.Descricao);
                cmd.Parameters.AddWithValue("@preco", pratos.Preco);
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

        public void atualizaPrato(Pratos prato)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update admin_pratos set nome = @nome, descricao = @descricao, preco = @preco where id = @id";
                cmd.Parameters.AddWithValue("@id", prato.Id);
                cmd.Parameters.AddWithValue("@nome", prato.Nome);
                cmd.Parameters.AddWithValue("@descricao", prato.Descricao);
                cmd.Parameters.AddWithValue("@preco", prato.Preco);
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

        public void salva(Pratos prato)
        {
            if (prato.Id == 0)
            {
                cadastrarPrato(prato);
            }
            else
            {
                atualizaPrato(prato);
            }
        }

        public void excluirPrato(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from admin_pratos where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
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
    }
}

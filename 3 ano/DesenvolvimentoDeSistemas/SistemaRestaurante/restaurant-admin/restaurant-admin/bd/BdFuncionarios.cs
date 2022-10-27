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
    internal class BdFuncionario : Bd
    {
        public BdFuncionario()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "restaurante";
        }

        public DataTable PreencheTabelaFuncionarios(string nome)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable funcionarios = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from admin_users where nome like @nome";
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(funcionarios);
                return funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void cadastrarFuncionario(Funcionarios funcionario)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into admin_users (nome, username, senha, funcao) values (@nome, @username, @senha, @funcao)";
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@username", funcionario.Username);
                cmd.Parameters.AddWithValue("@senha", funcionario.Senha);
                cmd.Parameters.AddWithValue("@funcao", funcionario.Funcao);
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

        public void atualizaFuncionario(Funcionarios funcionarios)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update admin_users set nome = @nome, username = @username, senha = @senha, funcao = @funcao where id = @id";
                cmd.Parameters.AddWithValue("@id", funcionarios.Id);
                cmd.Parameters.AddWithValue("@nome", funcionarios.Nome);
                cmd.Parameters.AddWithValue("@descricao", funcionarios.Username);
                cmd.Parameters.AddWithValue("@senha", funcionarios.Senha);
                cmd.Parameters.AddWithValue("@funcao", funcionarios.Funcao);
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

        public void salva(Funcionarios funcionarios)
        {
            if (funcionarios.Id == 0)
            {
                cadastrarFuncionario(funcionarios);
            }
            else
            {
                atualizaFuncionario(funcionarios);
            }
        }

        public void excluirFuncionario(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from admin_users where id=@id";
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

        public Funcionarios localiza(int codigo)
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            Funcionarios funcionario = new Funcionarios();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from admin_users where id = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    funcionario.Id = dr.GetInt32("id");
                    funcionario.Nome = dr.GetString("nome");
                    funcionario.Senha = dr.GetString("senha");
                    funcionario.Username = dr.GetString("username");
                    funcionario.Funcao = dr.GetInt32("funcao");
                }
                cmd.Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return funcionario;
        }
    }
}

using MySql.Data.MySqlClient;
using SistemaEmprestimo.vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo.bd
{
    internal class BdCliente : Bd
    {
        public BdCliente()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "emprestimos";
        }

        public DataTable PreencheTabelaClientes(string cpf)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable clientes = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from cliente where cpf = @cpf order by cpf";
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(clientes);
                return clientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void cadastrarCliente(Cliente cliente)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into cliente (cpf, nome, dataNasc, telefone, endereco) values (@cpf, @nome, @dataNasc, @telefone, @endereco)";
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
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

        public void atualizaCliente(Cliente cliente)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update cliente set nome = @nome, dataNasc = @dataNasc, telefone = @telefone, endereco = @endereco where cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Parameters.AddWithValue("@nome", cliente.Nome);
                cmd.Parameters.AddWithValue("@dataNasc", cliente.DataNasc);
                cmd.Parameters.AddWithValue("@telefone", cliente.Telefone);
                cmd.Parameters.AddWithValue("@endereco", cliente.Endereco);
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

        public void salva(Cliente cliente)
        {
            if (!VerificaCpfAtualiza(cliente))
            {
                cadastrarCliente(cliente);
            }
            else
            {
                atualizaCliente(cliente);
            }
        }

        public bool VerificaCpfAtualiza(Cliente cliente)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable qtd = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM cliente WHERE cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf", cliente.Cpf);
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(qtd);
                Close();
                if (qtd.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public void excluir(string cpf)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from cliente where cpf=@cpf";
                cmd.Parameters.AddWithValue("@cpf", cpf);
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

        public Cliente localiza(string cpf)
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            Cliente cliente = new Cliente();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from cliente where cpf = @cpf";
                cmd.Parameters.AddWithValue("@cpf", cpf);
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente.Cpf = dr.GetInt32("cpf");
                    cliente.Nome = dr.GetString("nome");
                    cliente.Endereco = dr.GetString("endereco");
                    cliente.Telefone = dr.GetString("telefone");
                    cliente.DataNasc = dr.GetDateTime("dataNasc");
                }
                cmd.Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return cliente;
        }
    }
}

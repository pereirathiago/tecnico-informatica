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
    internal class BdEquipamentos : Bd
    {
        public BdEquipamentos()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "emprestimos";
        }

        public DataTable PreencheTabelaEquipamentos(string nome)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable clientes = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from equipamentos where nome like @nome";
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
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

        public DataTable PreencheTabelaEquipamentosVoltagem(string voltagem)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable clientes = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from equipamentos where voltagem like @voltagem";
                cmd.Parameters.AddWithValue("@voltagem", "%" + voltagem + "%");
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

        public void cadastrarEquipamento(Equipamentos equipamento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into equipamentos (id, nome, descricao, marca, voltagem) values (@id, @nome, @descricao, @marca, @voltagem)";
                cmd.Parameters.AddWithValue("@id", equipamento.Id);
                cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
                cmd.Parameters.AddWithValue("@descricao", equipamento.Descricao);
                cmd.Parameters.AddWithValue("@marca", equipamento.Marca);
                cmd.Parameters.AddWithValue("@voltagem", equipamento.Voltagem);
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

        public void atualizaEquipamento(Equipamentos equipamento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update equipamentos set nome = @nome, descricao = @descricao, marca = @marca, voltagem = @voltagem where id = @id";
                cmd.Parameters.AddWithValue("@id", equipamento.Id);
                cmd.Parameters.AddWithValue("@nome", equipamento.Nome);
                cmd.Parameters.AddWithValue("@descricao", equipamento.Descricao);
                cmd.Parameters.AddWithValue("@marca", equipamento.Marca);
                cmd.Parameters.AddWithValue("@voltagem", equipamento.Voltagem);
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

        public void salva(Equipamentos equipamento)
        {
            if (equipamento.Id == 0)
            {
                cadastrarEquipamento(equipamento);
            }
            else
            {
                atualizaEquipamento(equipamento);
            }
        }

        public void excluir(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                if (!verificaExcluir(id))
                {
                    Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from equipamentos where id=@id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Connection = Connection;
                    da.UpdateCommand = cmd;
                    da.UpdateCommand.ExecuteNonQuery();
                    Close();
                } else
                {
                    MessageBox.Show("O item não pode ser excluido porque já foi emprestado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool verificaExcluir(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable qtd = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM emprestimo WHERE idEquipamento = @id";
                cmd.Parameters.AddWithValue("@id", id);
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

        public Equipamentos localiza(int codigo)
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            Equipamentos equipamentos = new Equipamentos();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from equipamentos where id = @codigo";
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    equipamentos.Id = dr.GetInt32("id");
                    equipamentos.Nome = dr.GetString("nome");
                    equipamentos.Descricao = dr.GetString("descricao");
                    equipamentos.Marca = dr.GetString("marca");
                    equipamentos.Voltagem = dr.GetString("voltagem");
                }
                cmd.Dispose();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return equipamentos;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaCaixa 
{
    class BdMovimento : Bd
    {
        public BdMovimento()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "caixa";
        }

        public void inserir(Movimento movimento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into movimento (id, data, descricao, valor, tipo) values (@id, @data, @descricao,@valor, @tipo)";
                cmd.Parameters.AddWithValue("@id", movimento.Id);
                cmd.Parameters.AddWithValue("@data", movimento.Data);
                cmd.Parameters.AddWithValue("@descricao", movimento.Descricao);
                cmd.Parameters.AddWithValue("@valor", movimento.Valor);
                cmd.Parameters.AddWithValue("@tipo", movimento.Tipo);
                cmd.Connection = Connection;
                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();
                Fechar();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void excuir(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();

            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from movimento where id = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection=Connection;
                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();
                Fechar();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Movimento localiza(int id)
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            Movimento movimento = new Movimento();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from movimento where id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    movimento.Id = dr.GetInt32("id");
                    movimento.Data = dr.GetDateTime("data");
                    movimento.Descricao = dr.GetString("descricao");
                    movimento.Valor = dr.GetDouble("valor");
                    movimento.Tipo = dr.GetString("tipo");
                }
                cmd.Dispose();
                Fechar();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return movimento;
        }

        public DataSet pesquisa(String descricao)
        {
           DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from aluno where descricao like @descricao";
                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(ds);
                da.Dispose();
                return ds;
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }
    }
}

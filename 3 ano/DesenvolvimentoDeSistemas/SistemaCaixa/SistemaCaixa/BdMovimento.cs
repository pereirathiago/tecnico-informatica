using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

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

        public DataTable PreencheTabela(string descricao)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable movimento = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from movimento where descricao like @descricao";
                cmd.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(movimento);
                return movimento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}

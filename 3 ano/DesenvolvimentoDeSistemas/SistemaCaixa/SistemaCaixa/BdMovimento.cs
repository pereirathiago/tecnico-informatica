using System;
using System.Collections.Generic;
using System.Linq;
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
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into movimento (id, data, descricao, valor, tipo) values (@id, @data, @descricao,@valor, @tipo)";
                cmd.Parameters.AddWithValue("@id", movimento.Id);
                cmd.Parameters.AddWithValue("@data", movimento.Data);
                cmd.Parameters.AddWithValue("@descricao", movimento.Descricao);
                cmd.Parameters.AddWithValue("@valor", movimento.Valor);
                cmd.Parameters.AddWithValue("@tipo", movimento.Tipo);
                cmd.Connection = Connection;
                da.UpdateCommand = cmd;
                da.UpdateCommand.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

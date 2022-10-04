using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEmprestimo.bd
{
    internal class BdEmprestimos : Bd
    {
        public BdEmprestimos()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "emprestimos";
        }

        public DataTable PreencheComboBoxEquipamentos()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable equipamentos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select id, nome from equipamentos";
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(equipamentos);
                return equipamentos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable PreencheTabelaEmprstimos(string cpf)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where idCliente like @cpf";
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(emprestimos);
                return emprestimos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
    }
}

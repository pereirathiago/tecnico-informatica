using MySql.Data.MySqlClient;
using SistemaSalario.vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSalario.bd
{
    internal class BdFuncionario : Bd
    {
        public BdFuncionario()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "salarios";
        }
        public DataTable PreencheTabela(string nome)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable funcionario = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from funcionario where nome like @nome";
                cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(funcionario);
                return funcionario;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void inserir(Funcionario funcionario)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into funcionario (matricula, nome, vt, dep14, depir, salario) values (@matricula, @nome, @vt, @dep14, @depir, @salario)";
                cmd.Parameters.AddWithValue("@matricula", funcionario.Matricula);
                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@vt", funcionario.Vt);
                cmd.Parameters.AddWithValue("@dep14", funcionario.Dep14);
                cmd.Parameters.AddWithValue("@depir", funcionario.Depir);
                cmd.Parameters.AddWithValue("@salario", funcionario.Salario);
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

    }
}

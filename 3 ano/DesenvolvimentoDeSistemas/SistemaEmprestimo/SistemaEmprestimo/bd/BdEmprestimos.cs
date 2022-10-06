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

        private DataTable PreencheTabelaEmprstimos(string cpf)
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

        public Emprestimos localiza(string cpf)
        {
            Emprestimos emprestimos = new Emprestimos();
            emprestimos.IdCliente = cpf;
            return emprestimos;
        }

        public DataTable calculaNovaTabela(string cpf)
        {
            DataTable emprestimo = new DataTable();
            emprestimo.Columns.Add("Código", typeof(int));
            emprestimo.Columns.Add("CPF", typeof(System.String));
            emprestimo.Columns.Add("Código Produto", typeof(int));
            emprestimo.Columns.Add("Nome", typeof(System.String));
            emprestimo.Columns.Add("Produto", typeof(System.String));
            emprestimo.Columns.Add("Data emprestimo", typeof(System.DateTime));
            emprestimo.Columns.Add("Data Prevista", typeof(System.DateTime));
            emprestimo.Columns.Add("Data Entrega", typeof(System.DateTime));
            emprestimo.Columns.Add("Entregue", typeof(int));
            object[] obj = new object[9];
            foreach (DataRow dr in PreencheTabelaEmprstimos(cpf).Rows)
            {
                obj[0] = dr.ItemArray[0];
                obj[1] = dr.ItemArray[1];
                obj[2] = dr.ItemArray[2];
                obj[3] = null;
                obj[4] = null;
                obj[5] = dr.ItemArray[3];
                obj[6] = dr.ItemArray[4];
                obj[7] = dr.ItemArray[5];
                obj[8] = dr.ItemArray[6];

                emprestimo.Rows.Add(obj);
            }
            return emprestimo;
        }

        public void realizarEmprestimo(Emprestimos emprestimos)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into emprestimo (id, idCliente, idEquipamento, dataEmprestimo, dataPrevista, dataEntrega, entregue) " +
                    "values (@id, @idCliente, @idEquipamento, @dataEmprestimo, @dataPrevista, @dataEntrega, @entregue)";
                cmd.Parameters.AddWithValue("@id", emprestimos.Id);
                cmd.Parameters.AddWithValue("@idCliente", emprestimos.IdCliente);
                cmd.Parameters.AddWithValue("@idEquipamento", emprestimos.IdEquipamento);
                cmd.Parameters.AddWithValue("@dataEmprestimo", emprestimos.DataEmprestimo);
                cmd.Parameters.AddWithValue("@dataPrevista", emprestimos.DataPrevista);
                cmd.Parameters.AddWithValue("@dataEntrega", emprestimos.DataEntregue);
                cmd.Parameters.AddWithValue("@entregue", emprestimos.IsEntregue);
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

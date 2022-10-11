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

        public DataTable PreencheTabelaEmprstimos(string cpf, int? produto)
        {
            if(produto == 0) produto = null;
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where idCliente like @cpf and idEquipamento like @produto";
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                cmd.Parameters.AddWithValue("@produto", "%" + produto + "%");
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

        public bool VerificaEquipamentos()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable qtd = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM equipamentos";
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

        public Emprestimos localiza(string cpf)
        {
            Emprestimos emprestimos = new Emprestimos();
            emprestimos.IdCliente = cpf;
            return emprestimos;
        }

        public DataTable calculaNovaTabela(string cpf, int produto, Func<string, int?, DataTable> function)
        {
            DataTable emprestimo = new DataTable();
            emprestimo.Columns.Add("Código", typeof(int));
            emprestimo.Columns.Add("CPF", typeof(System.String));
            emprestimo.Columns.Add("Código Produto", typeof(int));
            emprestimo.Columns.Add("Nome", typeof(System.String));
            emprestimo.Columns.Add("Produto", typeof(System.String));
            emprestimo.Columns.Add("Data emprestimo", typeof(System.DateTime));
            emprestimo.Columns.Add("Data Prevista", typeof(System.DateTime));
            emprestimo.Columns.Add("Data Entrega", typeof(System.String));
            emprestimo.Columns.Add("Entregue", typeof(System.String));
            object[] obj = new object[9];
            foreach (DataRow dr in function(cpf, produto).Rows)
            {
                obj[0] = dr.ItemArray[0];
                obj[1] = dr.ItemArray[1];
                obj[2] = dr.ItemArray[2];
                foreach (DataRow dr2 in localizaNome(dr.ItemArray[1].ToString()).Rows)
                {
                    obj[3] = dr2.ItemArray[0];
                }
                foreach (DataRow dr2 in localizaProduto(Convert.ToInt32(dr.ItemArray[2])).Rows)
                {
                    obj[4] = dr2.ItemArray[0];
                }
                obj[5] = dr.ItemArray[3];
                obj[6] = dr.ItemArray[4];
                obj[7] = dr.ItemArray[5].ToString() == "" ? "Não devolvido" : Convert.ToDateTime(dr.ItemArray[5]).ToString("dd/MM/yyyy");
                obj[8] = dr.ItemArray[6].ToString() == "True" ? "Sim" : "Não";
                emprestimo.Rows.Add(obj);
            }
            return emprestimo;
        }

        private DataTable localizaNome(string cpf)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable cliente = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nome from clientes where cpf like @cpf";
                cmd.Parameters.AddWithValue("@cpf", "%" + cpf + "%");
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(cliente);
                return cliente;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        private DataTable localizaProduto(int id)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable equipamento = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select nome from equipamentos where id like @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(equipamento);
                return equipamento;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
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
    
        public DataTable localizaNoPrazo(string cpf, int? produto)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where dataEmprestimo <= dataPrevista";
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

        public DataTable localizaAtrazados(string cpf, int? produto)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where dataEmprestimo >= dataPrevista";
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

        public DataTable localizaDevolvidosNoPrazo(string cpf, int? produto)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where dataEntrega <= dataPrevista and entregue = 1";
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

        public DataTable localizaDevolvidosDepoisDoPrazo(string cpf, int? produto)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable emprestimos = new DataTable();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emprestimo where dataEntrega >= dataPrevista and entregue = 1";
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

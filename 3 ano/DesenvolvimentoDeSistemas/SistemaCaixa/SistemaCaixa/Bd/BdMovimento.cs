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

        public DataTable PreencheTabelaDatas(DateTime dataInicio, DateTime dataFinal)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable movimento = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from movimento where data between DATE(@dataInicio) and Date(@dataFinal)";
                if(verificaDatas(dataInicio, dataFinal))
                {
                    cmd.Parameters.AddWithValue("@dataInicio", dataInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dataFinal", dataFinal.ToString("yyyy-MM-dd"));
                }
                else
                {
                    MessageBox.Show("Data inicial: " + dataFinal.ToString("dd/MM/yyyy") + "\nData final: " + dataInicio.ToString("dd/MM/yyyy"));
                    cmd.Parameters.AddWithValue("@dataInicio", dataFinal.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@dataFinal", dataInicio.ToString("yyyy-MM-dd"));
                }
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

        public double SaldoInicial(DateTime dataInicio)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable dataInicial = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select valor from saldo where data = DATE(@dataInicio)";
                cmd.Parameters.AddWithValue("@dataInicio", dataInicio.AddDays(-1).ToString("yyyy-MM-dd"));
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(dataInicial);
                if (dataInicial.Rows.Count > 0)
                    return Convert.ToDouble(dataInicial.Rows[0].ItemArray[0].ToString());
                else
                    return 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        public double SaldoFinal(DateTime dataFinal)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable dataInicial = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select valor from saldo where data <= DATE(@dataFinal) order by data DESC limit 1";
                cmd.Parameters.AddWithValue("@dataFinal", dataFinal.ToString("yyyy-MM-dd"));
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(dataInicial);
                return Convert.ToDouble(dataInicial.Rows[0].ItemArray[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        bool verificaDatas(DateTime dataInicio, DateTime dataFinal)
        {
            if(dataInicio > dataFinal)
            {
                MessageBox.Show("A data final deve ser depois da inicial");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

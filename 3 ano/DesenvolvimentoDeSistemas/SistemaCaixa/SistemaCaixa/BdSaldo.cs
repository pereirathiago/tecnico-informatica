using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SistemaCaixa
{
    class BdSaldo : Bd
    {
        Double _saldoIni;

        public double SaldoIni { get => _saldoIni; set => _saldoIni = value; }

        public BdSaldo()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "caixa";
        }

        public DataTable PreencheTabela()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable saldo = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from saldo";
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(saldo);
                return saldo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void inserir(Movimento movimento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                string sql = AdicionarValorDiaAnter(movimento);
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@id", movimento.Id);
                cmd.Parameters.AddWithValue("@data", movimento.Data);
                cmd.Parameters.AddWithValue("@valor", movimento.Valor);
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

        public void atualiza(Movimento movimento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                string sql = VerificaEntradaSaida(movimento);
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@data", movimento.Data.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@valor", movimento.Valor);
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

        public void salva(Movimento movimento)
        {
            if (!VerificaDataBd(movimento))
            {
                inserir(movimento);
            }
            else
            {
                atualiza(movimento);
            }
        }

        public bool VerificaDataBd(Movimento movimento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable qtd = new DataTable();
            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM saldo WHERE data = DATE(@data)";
                cmd.Parameters.AddWithValue("@data", movimento.Data.ToString("yyyy-MM-dd"));
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(qtd);
                Fechar();
                if (qtd.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public string VerificaEntradaSaida(Movimento movimento)
        {
            if(movimento.Tipo == "S")
            {
                string sql = "update saldo set valor = valor - @valor where data = DATE(@data)";
                return sql;
            } 
            if(movimento.Tipo == "E")
            {
                string sql = "update saldo set valor = valor + @valor where data = DATE(@data)";
                return sql;
            }
            return "";
        }

        public string AdicionarValorDiaAnter(Movimento movimento)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            DataTable qtd = new DataTable();

            try
            {
                Abrir();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select valor from saldo where data = DATE(@data)";
                cmd.Parameters.AddWithValue("@data", movimento.Data.AddDays(-1).ToString("yyyy-MM-dd"));
                cmd.Connection = Connection;
                da.SelectCommand = cmd;
                da.Fill(qtd);
                Fechar();
                if(qtd.Rows.Count <= 0)
                {
                    // não tem dia anterior
                    string sql = "insert into saldo (id, data, valor) values (@id, @data, @valor)";
                    return sql;
                } else
                {
                    // tem dia anterior
                    string sql = "insert into saldo (id, data, valor) values (@id, @data, "+qtd.Rows[0].ItemArray[0]+ "+ @valor)";
                    return sql;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }
    }
}

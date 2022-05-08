using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;
using SistemaSalario.vo;

namespace SistemaSalario.bd
{
    internal class BdTabela : Bd
    {
        public BdTabela()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "salarios";
        }
        public Tabela PreencheTabela()
        {
            MySqlDataReader dr = null;
            MySqlCommand cmd = new MySqlCommand();
            Tabela tabela = new Tabela();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from tabela";
                cmd.Connection = Connection;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    tabela.Tinss1 = dr.GetDouble("tinss1");
                    tabela.Tinss2 = dr.GetDouble("tinss2");
                    tabela.Tinss3 = dr.GetDouble("tinss3");
                    tabela.Tinss4 = dr.GetDouble("tinss4");
                    tabela.Ainss1 = dr.GetDouble("ainss1");
                    tabela.Ainss2 = dr.GetDouble("ainss2");
                    tabela.Ainss3 = dr.GetDouble("ainss3");
                    tabela.Ainss4 = dr.GetDouble("ainss4");
                    tabela.Tsf = dr.GetDouble("tsf");
                    tabela.Vsf = dr.GetDouble("vsf");
                    tabela.Tirrf1 = dr.GetDouble("tirrf1");
                    tabela.Tirrf2 = dr.GetDouble("tirrf2");
                    tabela.Tirrf3 = dr.GetDouble("tirrf3");
                    tabela.Tirrf4 = dr.GetDouble("tirrf4");
                    tabela.Airrf2 = dr.GetDouble("airrf2");
                    tabela.Airrf3 = dr.GetDouble("airrf3");
                    tabela.Airrf4 = dr.GetDouble("airrf4");
                    tabela.Airrf5 = dr.GetDouble("airrf5");
                    tabela.Dirrf2 = dr.GetDouble("dirrf2");
                    tabela.Dirrf3 = dr.GetDouble("dirrf3");
                    tabela.Dirrf4 = dr.GetDouble("dirrf4");
                    tabela.Dirrf5 = dr.GetDouble("dirrf5");
                    tabela.Dedpdep = dr.GetDouble("dedpdep");
                }
                cmd.Dispose();
                Fechar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return tabela;
        }

        public void atualizaINSS(Tabela tabela)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tabela set tinss1=@tinss1, tinss2=@tinss2, tinss3=@tinss3, tinss4=@tinss4, ainss1=@ainss1, ainss2=@ainss2, ainss3=@ainss3, ainss4=@ainss4";
                cmd.Parameters.AddWithValue("@tinss1", tabela.Tinss1);
                cmd.Parameters.AddWithValue("@tinss2", tabela.Tinss2);
                cmd.Parameters.AddWithValue("@tinss3", tabela.Tinss3);
                cmd.Parameters.AddWithValue("@tinss4", tabela.Tinss4);
                cmd.Parameters.AddWithValue("@ainss1", tabela.Ainss1);
                cmd.Parameters.AddWithValue("@ainss2", tabela.Ainss2);
                cmd.Parameters.AddWithValue("@ainss3", tabela.Ainss3);
                cmd.Parameters.AddWithValue("@ainss4", tabela.Ainss4);
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

        public void atualizaSalarioF(Tabela tabela)
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update tabela set tsf=@tsf, vsf=@vsf";
                cmd.Parameters.AddWithValue("@tsf", tabela.Tsf);
                cmd.Parameters.AddWithValue("@vsf", tabela.Vsf);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void inserir()
        {
            MySqlDataAdapter da = new MySqlDataAdapter();
            MySqlCommand cmd = new MySqlCommand();
            try
            {
                Abrir();
                cmd.CommandType = System.Data.CommandType.Text;
                //cmd.CommandText = "insert into movimento (id, data, descricao, valor, tipo) values (" + id 
            } 
            catch (Exception ex)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSalario.bd
{
    internal class BdFuncionario : Bd
    {
        public BdFuncionario()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "folhaPagamento";
        }
    }
}

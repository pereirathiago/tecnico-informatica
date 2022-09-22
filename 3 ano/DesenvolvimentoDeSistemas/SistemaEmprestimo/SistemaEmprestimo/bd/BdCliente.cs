using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimo.bd
{
    internal class BdCliente : Bd
    {
        public BdCliente()
        {
            User = "root";
            Servidor = "localhost";
            Senha = "vertrigo";
            bd = "emprestimos";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.vo
{
    internal class Funcionario
    {
        private int _id;
        private string _username;
        private string _nome;
        private string _senha;
        private int _funcao;

        public int Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Senha { get => _senha; set => _senha = value; }
        public int Funcao { get => _funcao; set => _funcao = value; }
    }
}

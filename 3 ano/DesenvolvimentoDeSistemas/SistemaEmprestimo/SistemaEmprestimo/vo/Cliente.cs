using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimo.vo
{
    internal class Cliente
    {
        private string _cpf;
        private string _nome;
        private DateTime _dataNasc;
        private string _telefone;
        private string _endereco;

        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public DateTime DataNasc { get => _dataNasc; set => _dataNasc = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Endereco { get => _endereco; set => _endereco = value; }
    }
}

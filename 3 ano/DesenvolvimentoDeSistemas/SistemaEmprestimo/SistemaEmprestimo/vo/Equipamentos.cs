using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimo.vo
{
    internal class Equipamentos
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private string _marca;
        private string _voltagem;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public string Voltagem { get => _voltagem; set => _voltagem = value; }
    }
}

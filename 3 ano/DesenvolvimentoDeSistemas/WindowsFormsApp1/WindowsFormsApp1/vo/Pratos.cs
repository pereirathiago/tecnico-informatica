using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.vo
{
    internal class Pratos
    {
        private int _id;
        private string _nome;
        private string _descricao;
        private double _preco;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public double Preco { get => _preco; set => _preco = value; }
    }
}

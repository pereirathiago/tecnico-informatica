using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCaixa
{
    internal class Movimento
    {
        private int _id;
        private DateTime _data;
        private string _descricao;
        private double _valor;
        private string _tipo;

        public int Id { get => _id; set => _id = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Tipo { get => _tipo; set => _tipo = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}

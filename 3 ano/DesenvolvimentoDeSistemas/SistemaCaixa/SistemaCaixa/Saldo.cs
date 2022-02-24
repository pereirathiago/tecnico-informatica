using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCaixa
{
    internal class Saldo
    {
        private int _id;
        private DateTime _data;
        private double _valor;

        public int Id { get => _id; set => _id = value; }
        public DateTime Data { get => _data; set => _data = value; }
        public double Valor { get => _valor; set => _valor = value; }
    }
}

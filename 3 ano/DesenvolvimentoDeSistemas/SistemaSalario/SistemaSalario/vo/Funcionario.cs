using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSalario.vo
{
    internal class Funcionario
    {
        private int _id;
        private string _nome;
        private int _nFilhos;
        private int _nDepIR;
        private string _valeTransporte;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public int NFilhos { get => _nFilhos; set => _nFilhos = value; }
        public int NDepIR { get => _nDepIR; set => _nDepIR = value; }
        public string ValeTransporte { get => _valeTransporte; set => _valeTransporte = value; }
    }
}

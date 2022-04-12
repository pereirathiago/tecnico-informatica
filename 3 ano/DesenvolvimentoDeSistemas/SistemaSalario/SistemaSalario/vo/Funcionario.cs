using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaSalario.vo
{
    internal class Funcionario
    {
        private int _matricula;
        private string _nome;
        private string _vt;
        private int _dep14;
        private int _depir;
        private double _salario;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Vt { get => _vt; set => _vt = value; }
        public int Dep14 { get => _dep14; set => _dep14 = value; }
        public int Depir { get => _depir; set => _depir = value; }
        public double Salario { get => _salario; set => _salario = value; }
    }
}

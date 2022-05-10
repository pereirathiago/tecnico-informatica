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
        private double _sf;
        private double _inss;
        private double _vvt;
        private double _irrf;
        private double _salliq;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Vt { get => _vt; set => _vt = value; }
        public int Dep14 { get => _dep14; set => _dep14 = value; }
        public int Depir { get => _depir; set => _depir = value; }
        public double Salario { get => _salario; set => _salario = value; }
        public double Sf { get => _sf; set => _sf = value; }
        public double Inss { get => _inss; set => _inss = value; }
        public double Vvt { get => _vvt; set => _vvt = value; }
        public double Irrf { get => _irrf; set => _irrf = value; }
        public double Salliq { get => _salliq; set => _salliq = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimo.vo
{
    internal class Emprestimos
    {
        private int _id;
        private string _idCliente;
        private int _idEquipamento;
        private string _nome;
        private string _produto;
        private DateTime _dataEmprestimo;
        private DateTime _dataPrevista;
        private DateTime? _dataEntregue;
        private bool _isEntregue;

        public int Id { get => _id; set => _id = value; }
        public string IdCliente { get => _idCliente; set => _idCliente = value; }
        public int IdEquipamento { get => _idEquipamento; set => _idEquipamento = value; }
        public DateTime DataEmprestimo { get => _dataEmprestimo; set => _dataEmprestimo = value; }
        public DateTime DataPrevista { get => _dataPrevista; set => _dataPrevista = value; }
        public DateTime? DataEntregue { get => _dataEntregue; set => _dataEntregue = value; }
        public bool IsEntregue { get => _isEntregue; set => _isEntregue = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Produto { get => _produto; set => _produto = value; }
    }
}

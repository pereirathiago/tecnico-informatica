using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurante_cozinha.vo
{
    internal class Pedido
    {
        private int _id;
        private int _idPrato;
        private string _nome_pedido;
        private string _mesa;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public int IdPrato { get => _idPrato; set => _idPrato = value; }
        public string Nome_pedido { get => _nome_pedido; set => _nome_pedido = value; }
        public string Mesa { get => _mesa; set => _mesa = value; }
        public string Status { get => _status; set => _status = value; }
    }
}

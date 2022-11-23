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
        private string _nome;
        private string _descricao;
        private string _mesa;
        private string _status;

        public int Id { get => _id; set => _id = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public string Mesa { get => _mesa; set => _mesa = value; }
        public string Status { get => _status; set => _status = value; }
    }
}

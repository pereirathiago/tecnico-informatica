class Pedidos {
  int id = 0;
  int idPrato = 0;
  String? mesa;
  String? nomePedido;
  String? status;

  Pedidos(
    this.mesa,
    this.nomePedido,
    this.status,
    this.idPrato,
  );

  Pedidos.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    idPrato = json['idPrato'];
    mesa = json['mesa'];
    nomePedido = json['nome_pedido'];
    status = json['status'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "idPrato": idPrato,
      "mesa": mesa,
      "nome_pedido": nomePedido,
      "status": status,
    };
  }
}

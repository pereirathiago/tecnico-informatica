class Pedidos {
  int id = 0;
  int idPrato = 0;
  String? mesa;
  String? nomePedido;

  Pedidos(
    this.me sa,
    this.nomePedido,
    this.idPrato,
  );

  Pedidos.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    idPrato = json['idPrato'];
    mesa = json['mesa'];
    nomePedido = json['nomePedido'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "idPrato": idPrato,
      "mesa": mesa,
      "nomePedido": nomePedido,
    };
  }
}

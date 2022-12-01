import 'dart:ffi';

class Prato {
  int id = 0;
  String? nome;
  String? descricao;
  int preco = 0;

  Prato(
    this.nome,
    this.descricao,
    this.preco,
  );

  Prato.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    nome = json['nome'];
    descricao = json['descricao'];
    preco = json['preco'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "nome": nome,
      "descricao": descricao,
      "preco": preco,
    };
  }
}

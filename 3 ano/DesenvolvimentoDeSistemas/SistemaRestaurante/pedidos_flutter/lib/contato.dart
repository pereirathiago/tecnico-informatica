class Contato {
  int id = 0;
  String? nome;
  String? telefone;
  String? email;

  Contato(
    this.nome,
    this.email,
    this.telefone,
  );

  Contato.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    nome = json['nome'];
    telefone = json['telefone'];
    email = json['email'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "nome": nome,
      "email": email,
      "telefone": telefone,
    };
  }
}

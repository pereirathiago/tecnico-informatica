class Usuario {
  int id = 0;
  String? user;
  String? nome;
  String? senha;
  int? funcao;

  Usuario(
    this.user,
    this.nome,
    this.senha,
    this.funcao,
  );

  Usuario.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    user = json['user'];
    nome = json['nome'];
    senha = json['senha'];
    funcao = json['funcao'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "user": user,
      "nome": nome,
      "senha": senha,
      "funcao": funcao,
    };
  }
}

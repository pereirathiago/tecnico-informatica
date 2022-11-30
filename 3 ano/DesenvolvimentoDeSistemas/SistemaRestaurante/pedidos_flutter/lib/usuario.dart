class Usuario {
  int id = 0;
  String? username;
  String? senha;

  Usuario(
    this.username,
    this.senha,
  );

  Usuario.fromJSON(Map<String, dynamic> json) {
    id = json['id'];
    username = json['username'];
    senha = json['senha'];
  }

  Map<String, dynamic> toJson() {
    return <String, dynamic>{
      "id": id,
      "username": username,
      "senha": senha,
    };
  }
}

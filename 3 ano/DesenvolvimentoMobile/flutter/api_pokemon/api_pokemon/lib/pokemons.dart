class Pokemons {
  String? nome;
  String? url;

  Pokemons(
    this.nome,
    this.url,
  );

  Pokemons.fromJSON(Map<String, dynamic> json) {
    nome = json['name'];
    url = json['url'];
  }
}

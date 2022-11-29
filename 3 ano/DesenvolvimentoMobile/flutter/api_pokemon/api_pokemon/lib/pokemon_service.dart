import 'package:api_pokemon/pokemon.dart';
import 'package:http/http.dart' as http;
import 'package:api_pokemon/pokemons.dart';
import 'dart:convert';

class PokemonService {
  static const url = "https://pokeapi.co/api/v2/pokemon";

  static Future<List<Pokemons>> listaPokemon() async {
    try {
      List<Pokemons> listaPokemon = [];
      final response = await http.get(Uri.parse('$url/?limit=151'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        for (var item in decodeJson['results']) {
          listaPokemon.add(Pokemons.fromJSON(item));
        }
        //decodeJson.forEach((item) => listaPokemon.add(Pokemon.fromJSON(item)));
        return listaPokemon;
      } else {
        throw Exception("Erro ao carregar pokemon 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar pokemon 2 ");
    }
  }
}

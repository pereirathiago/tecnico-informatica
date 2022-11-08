import 'package:http/http.dart' as http;
import 'package:cliente_api_flutter/contato.dart';
import 'dart:convert';

class ContatoService {
  static const url = "https://iessa.edu.br:8181/crudws/contato";
  static Future<int> insere(Contato contato) async {
    try {
      final response = await http.post(
        Uri.parse(url),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: jsonEncode(contato),
      );
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar inserir " + e.toString());
    }
  }

  static Future<int> atualiza(Contato contato) async {
    try {
      int id = contato.id;
      final response = await http.put(
        Uri.parse("$url/$id"),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: jsonEncode(contato),
      );
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar atualizar");
    }
  }

  static Future<int> exclui(int id) async {
    try {
      final response = await http.delete(Uri.parse('$url/$id'));
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao processar excluir");
    }
  }

  static Future<List<Contato>> listaContatos() async {
    try {
      List<Contato> listaContato = [];
      final response = await http.get(Uri.parse(url));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        decodeJson.forEach((item) => listaContato.add(Contato.fromJSON(item)));
        return listaContato;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2" + e.toString());
    }
  }

  static Future<Contato> contato(int id) async {
    try {
      Contato contato = Contato("", "", "");
      final response = await http.get(Uri.parse('$url/$id'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        contato = Contato.fromJSON(decodeJson);
        return contato;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2");
    }
  }
}

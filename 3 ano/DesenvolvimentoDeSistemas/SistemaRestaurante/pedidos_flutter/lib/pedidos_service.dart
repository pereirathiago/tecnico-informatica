import 'package:http/http.dart' as http;
import 'package:cliente_api_flutter/usuario.dart';
import 'dart:convert';

class UsuarioService {
  static const url = "http://localhost:3030";
  
  static Future<Usuario> usuario(String username) async {
    try {
      Usuario usuario = Usuario("", "", "", 0);
      final response = await http.get(Uri.parse('$url/user/$username'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        usuario = Usuario.fromJSON(decodeJson);
        return usuario;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2");
    }
  }
  
  static Future<Usuario> loginUsuario(Usuario usuario) async {
    try {
      Usuario usuario = Usuario("", "", "", 0);
      final response = await http.post(Uri.parse('$url/user/login'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        usuario = Usuario.fromJSON(decodeJson);
        return usuario;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao realizar login " + e.toString());
    }
  }
}

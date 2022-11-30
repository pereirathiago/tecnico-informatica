import 'package:http/http.dart' as http;
import 'package:cliente_api_flutter/usuario.dart';
import 'dart:convert';

class PedidoService {
  static const url = "http://localhost:3030";

  static Future<int> login(Usuario usuario) async {
    try {
      print('user: ${usuario.username} pass: ${usuario.senha}');
      final response = await http.post(
        Uri.parse('$url/user/login'),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        }, 
        body: jsonEncode(usuario),
      );
      print('Response status: ${response.statusCode}');
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar inserir " + e.toString());
    }
  }
}

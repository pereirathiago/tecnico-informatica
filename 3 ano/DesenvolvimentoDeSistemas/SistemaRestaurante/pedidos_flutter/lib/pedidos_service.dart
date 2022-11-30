import 'package:cliente_api_flutter/pedidos.dart';
import 'package:http/http.dart' as http;
import 'package:cliente_api_flutter/usuario.dart';
import 'dart:convert';

class PedidoService {
  static const url = "http://localhost:3030";

  static Future<int> login(Usuario usuario) async {
    try {
      final response = await http.post(
        Uri.parse('$url/user/login'),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: jsonEncode(usuario),
      );
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar inserir " + e.toString());
    }
  }

  static Future<List<Pedidos>> listaPedidosEmEspera() async {
    try {
      List<Pedidos> listaPedidosEspera = [];
      final response = await http.get(Uri.parse('$url/pedidos/'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        decodeJson.forEach((item) => listaPedidosEspera.add(Pedidos.fromJSON(item)));
        return listaPedidosEspera;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2 " + e.toString());
    }
  }
}

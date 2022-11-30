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
      final response = await http.get(Uri.parse('$url/pedidosEmEspera/'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        decodeJson
            .forEach((item) => listaPedidosEspera.add(Pedidos.fromJSON(item)));
        return listaPedidosEspera;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2 " + e.toString());
    }
  }

  static Future<List<Pedidos>> listaPedidosEmAndamento() async {
    try {
      List<Pedidos> listaPedidosEspera = [];
      final response = await http.get(Uri.parse('$url/pedidosEmAndamento/'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        decodeJson
            .forEach((item) => listaPedidosEspera.add(Pedidos.fromJSON(item)));
        return listaPedidosEspera;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2 " + e.toString());
    }
  }

  static Future<List<Pedidos>> listaPedidosPronto() async {
    try {
      List<Pedidos> listaPedidosEspera = [];
      final response = await http.get(Uri.parse('$url/pedidosPronto/'));
      if (response.statusCode == 200) {
        var decodeJson = jsonDecode(response.body);
        decodeJson
            .forEach((item) => listaPedidosEspera.add(Pedidos.fromJSON(item)));
        return listaPedidosEspera;
      } else {
        throw Exception("Erro ao carregar dados 1");
      }
    } catch (e) {
      throw Exception("Erro ao carregar dados 2 " + e.toString());
    }
  }

  static Future<int> atualiza(Pedidos pedido) async {
    try {
      int id = pedido.id;
      final response = await http.put(
        Uri.parse("$url/pedido/$id"),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: jsonEncode(pedido),
      );
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar alteração");
    }
  }

  static Future<int> insere(Pedidos pedido) async {
    try {
      String? mesa = pedido.mesa;
      final response = await http.post(
        Uri.parse("$url/pedido/$mesa"),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        },
        body: jsonEncode(pedido),
      );
      return response.statusCode == 200 ? 0 : 1;
    } catch (e) {
      throw Exception("Erro ao carregar inserir " + e.toString());
    }
  }
}

import 'package:cliente_api_flutter/pedidos_service.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/usuario.dart';
import 'package:cliente_api_flutter/dev_http_overrides.dart';

void main() {
  HttpOverrides.global = DevHttpOverrides();
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Pedidos Restaurante',
      theme: ThemeData(
        primarySwatch: Colors.green,
      ),
      home: const MyPedidosTelaPage(),
    );
  }
}

class MyPedidosTelaPage extends StatefulWidget {
  const MyPedidosTelaPage({
    Key? key,
  }) : super(key: key);

  @override
  State<MyPedidosTelaPage> createState() => _MyPedidosTelaPageState();
}

class _MyPedidosTelaPageState extends State<MyPedidosTelaPage> {
  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pedidos Restaurante'),
      ),
      body: Text('uau quantos pedidos'),
    );
  }
}

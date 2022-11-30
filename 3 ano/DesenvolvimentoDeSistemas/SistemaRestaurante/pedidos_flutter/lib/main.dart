import 'package:cliente_api_flutter/pedidos.dart';
import 'package:cliente_api_flutter/menu.dart';
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
      home: const MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({
    Key? key,
  }) : super(key: key);

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  Usuario usuario = Usuario("", "");

  @override
  void initState() {
    super.initState();
  }

  final TextEditingController _nomeController = TextEditingController();
  final TextEditingController _senhaController = TextEditingController();

  void telaToUser() {
    usuario = Usuario(_nomeController.text, _senhaController.text);
  }

  Future<void> loginUser() async {
    telaToUser();
    int i = await PedidoService.login(usuario);
    if (i == 0) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
        content: Text('Login realizado com sucesso!'),
      ));
      Navigator.of(context).push(
        MaterialPageRoute(
          builder: (context) => const Menu(),
        ),
      );
    } else {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
        content: Text('Login incorreto!'),
      ));
    }
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Login'),
        ),
        body: Center(
            child: Padding(
                padding: const EdgeInsets.only(left: 32.0, right: 32.0),
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    TextFormField(
                      decoration: const InputDecoration(
                        labelText: "Digite o usuário",
                      ),
                      controller: _nomeController,
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 16.0),
                      child: TextFormField(
                        obscureText: true,
                        decoration: const InputDecoration(
                          labelText: "Digite a senha",
                        ),
                        controller: _senhaController,
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 24.0),
                      child: ElevatedButton(
                        onPressed: loginUser,
                        child: const Text(
                          'Fazer Login',
                        ),
                      ),
                    ),
                  ],
                ))));
  }
}

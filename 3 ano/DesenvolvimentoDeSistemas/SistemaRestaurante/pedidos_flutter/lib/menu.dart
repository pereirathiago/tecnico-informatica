import 'package:cliente_api_flutter/em_espera.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/dev_http_overrides.dart';

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Pedidos Restaurante',
      theme: ThemeData(
        primarySwatch: Colors.green,
      ),
      home: const Menu(),
    );
  }
}

class Menu extends StatefulWidget {
  const Menu({
    Key? key,
  }) : super(key: key);

  @override
  State<Menu> createState() => _MenuState();
}

class _MenuState extends State<Menu> {
  @override
  void initState() {
    super.initState();
  }

  final TextEditingController _buscaController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    void _abrirEmEspera() {
      Navigator.push(context,
         MaterialPageRoute(builder: (context) => const EmEspera()));
    }

    void _abrirEmAndamento() {
      //Navigator.push(context,
      //   MaterialPageRoute(builder: (context) => const TelaEmpresa()));
      print("andamento aberto");
    }

    void _abrirPronto() {
      //Navigator.push(context,
      //   MaterialPageRoute(builder: (context) => const TelaEmpresa()));
      print("pronto aberto");
    }

    return Scaffold(
        backgroundColor: Colors.white,
        appBar: AppBar(
          title: const Text("Menu"),
          backgroundColor: Colors.green,
        ),
        body: Container(
            padding: const EdgeInsets.all(16),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.center,
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  children: [
                    TextFormField(
                      decoration: const InputDecoration(
                        labelText: "Digite a mesa",
                      ),
                      controller: _buscaController,
                    ),
                    const SizedBox(
                      height: 100,
                    ),
                    Row(
                      mainAxisAlignment: MainAxisAlignment.center,
                      children: [
                        ElevatedButton(
                          onPressed: _abrirEmEspera,
                          child: const Text("Em Espera"),
                        ),
                        const SizedBox(
                          width: 10,
                        ),
                        ElevatedButton(
                          onPressed: _abrirEmAndamento,
                          child: const Text("Em Andamento"),
                        ),
                        const SizedBox(
                          width: 10,
                        ),
                        ElevatedButton(
                          onPressed: _abrirPronto,
                          child: const Text("Pronto"),
                        ),
                      ],
                    ),
                  ],
                )
              ],
            )));
  }
}

import 'package:cliente_api_flutter/em_espera.dart';
import 'package:cliente_api_flutter/pedidos.dart';
import 'package:cliente_api_flutter/pedidos_service.dart';
import 'package:cliente_api_flutter/pronto.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/dev_http_overrides.dart';

import 'em_andamento.dart';

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
  Pedidos pedido = Pedidos("", "", "", 0);

  List<Map<String, dynamic>> _pratos = [];
  static List<String> list = ["Selecione o prato"];
  String _produto = "";

  String dropdownValue = list.first;
  void _listaPratos() async {
    list = ["Selecione o prato"];
    _pratos = [];
    final data = await PedidoService.listaPratos();
    setState(() {
      for (var p in data) {
        _pratos.add(<String, dynamic>{
          "id": p.id,
          "nome": p.nome,
          "descricao": p.descricao,
          "preco": p.preco,
        });
        list.add(p.nome.toString());
      }
    });
  }

  @override
  void initState() {
    super.initState();
    _listaPratos();
  }

  final TextEditingController _mesaController = TextEditingController();

  @override
  Widget build(BuildContext context) {
    void _abrirEmEspera() {
      Navigator.push(
          context, MaterialPageRoute(builder: (context) => const EmEspera()));
    }

    void _abrirEmAndamento() {
      Navigator.push(context,
          MaterialPageRoute(builder: (context) => const EmAndamento()));
    }

    void _abrirPronto() {
      Navigator.push(
          context, MaterialPageRoute(builder: (context) => const Pronto()));
    }

    void telaToPedido() {
      pedido = Pedidos(
        _mesaController.text,
        _produto,
        "Em espera",
        _pratos[list.indexOf(_produto) - 1]["id"],
      );
    }

    Future<void> _inserirPedido() async {
      telaToPedido();
      if (_mesaController.text == "") {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(
            content: Text("Preencha o campo mesa"),
          ),
        );
      } else if (_produto == "Selecione o prato") {
        ScaffoldMessenger.of(context).showSnackBar(
          const SnackBar(
            content: Text("Selecione um prato"),
          ),
        );
      } else {
        int i = await PedidoService.insere(pedido);
        if (i == 0) {
          ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
            content: Text('Novo pedido inserido com sucesso!'),
          ));
        } else {
          ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
            content: Text('Não foi possível pedir!'),
          ));
        }

      }
    }

    void _showForm() async {
      showModalBottomSheet(
          context: context,
          elevation: 5,
          isScrollControlled: true,
          builder: (_) => Container(
                padding: EdgeInsets.only(
                  top: 15,
                  left: 15,
                  right: 15,
                  bottom: MediaQuery.of(context).viewInsets.bottom + 120,
                ),
                child: Column(
                  mainAxisSize: MainAxisSize.min,
                  crossAxisAlignment: CrossAxisAlignment.end,
                  children: [
                    TextField(
                      controller: _mesaController,
                      decoration: const InputDecoration(hintText: 'Mesa'),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    DropdownButtonFormField<String>(
                      value: dropdownValue,
                      icon: const Icon(Icons.arrow_downward),
                      elevation: 16,
                      isExpanded: true,
                      onChanged: (String? value) {
                        setState(() {
                          dropdownValue = value!;
                          _produto = dropdownValue;
                        });
                      },
                      items: list.map<DropdownMenuItem<String>>((String value) {
                        return DropdownMenuItem<String>(
                          value: value,
                          child: Text(value),
                        );
                      }).toList(),
                    ),
                    const SizedBox(
                      height: 20,
                    ),
                    ElevatedButton(
                      onPressed: () async {
                        await _inserirPedido();
                        _mesaController.text = '';

                        Navigator.of(context).pop();
                      },
                      child: Text('Fazer pedido'),
                    )
                  ],
                ),
              ));
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
                  // TextFormField(
                  //   decoration: const InputDecoration(
                  //     labelText: "Digite a mesa",
                  //   ),
                  //   controller: _buscaController,
                  // ),
                  // const SizedBox(
                  //   height: 100,
                  // ),
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
          )),
      floatingActionButton: FloatingActionButton(
        child: const Icon(Icons.add),
        onPressed: () => _showForm(),
      ),
    );
  }
}

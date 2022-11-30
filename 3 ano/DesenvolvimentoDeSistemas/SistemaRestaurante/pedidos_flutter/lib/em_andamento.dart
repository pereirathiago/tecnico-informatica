import 'package:cliente_api_flutter/pedidos.dart';
import 'package:cliente_api_flutter/pedidos_service.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/dev_http_overrides.dart';

class EmAndamento extends StatefulWidget {
  const EmAndamento({super.key});

  @override
  State<EmAndamento> createState() => _EmAndamentoState();
}

class _EmAndamentoState extends State<EmAndamento> {
  List<Map<String, dynamic>> _pedidos = [];
  Pedidos pedido = Pedidos("", "", "", 0);
  bool _carregando = true;
  void _listaContatos() async {
    _pedidos = [];
    final data = await PedidoService.listaPedidosEmAndamento();
    setState(() {
      for (var e in data) {
        _pedidos.add(<String, dynamic>{
          "id": e.id,
          "idPrato": e.idPrato,
          "nomePedido": e.nomePedido,
          "mesa": e.mesa,
          "status": e.status,
        });
      }
      _carregando = false;
    });
  }

  @override
  void initState() {
    super.initState();
    _listaContatos();
  }

  void telaToContato() {
    pedido = Pedidos("", "", "", 0);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pedidos em andamento'),
      ),
      body: _carregando
          ? const Center(
              child: CircularProgressIndicator(),
            )
          : ListView.builder(
              itemCount: _pedidos.length,
              itemBuilder: (context, index) => Card(
                color: Colors.green[200],
                margin: const EdgeInsets.all(15),
                child: ListTile(
                    title: Text('Nome do prato: ' + _pedidos[index]['nomePedido']),
                    subtitle: Text('Mesa: ' + _pedidos[index]['mesa']),
                    trailing: SizedBox(
                      width: 40,
                      child: Row(
                        children: [
                          IconButton(
                            icon: const Icon(Icons.cancel),
                            onPressed: () => {}
                          ),
                        ],
                      ),
                    )),
              ),
            ),
    );
  }
}

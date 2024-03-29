import 'package:cliente_api_flutter/pedidos.dart';
import 'package:cliente_api_flutter/pedidos_service.dart';
import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/dev_http_overrides.dart';

class EmEspera extends StatefulWidget {
  const EmEspera({super.key});

  @override
  State<EmEspera> createState() => _EmEsperaState();
}

class _EmEsperaState extends State<EmEspera> {
  List<Map<String, dynamic>> _pedidos = [];
  Pedidos pedido = Pedidos("", "", "", 0);
  bool _carregando = true;
  void _listaContatos() async {
    _pedidos = [];
    final data = await PedidoService.listaPedidosEmEspera();
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

  void telaToContato(index) {
    pedido = Pedidos(
      _pedidos[index]['mesa'],
      _pedidos[index]['nomePedido'],
      _pedidos[index]['status'],
      _pedidos[index]['idPrato'],
    );
  }

  Future<void> _atualizaPedido(int index) async {
    telaToContato(index);
    pedido.id = _pedidos[index]['id'];
    pedido.status = "Cancelado";
    int i = await PedidoService.atualiza(pedido);
    if (i == 0) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
        content: Text('Pedido cancelado com sucesso!'),
      ));
    } else {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(
        content: Text('Não foi possível cancelar!'),
      ));
    }
    _listaContatos();
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pedidos em espera'),
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
                    title:
                        Text('Nome do prato: ' + _pedidos[index]['nomePedido']),
                    subtitle: Text('Mesa: ' + _pedidos[index]['mesa']),
                    trailing: SizedBox(
                      width: 40,
                      child: Row(
                        children: [
                          IconButton(
                              icon: const Icon(Icons.cancel),
                              onPressed: () => {_atualizaPedido(index)}),
                        ],
                      ),
                    )),
              ),
            ),
    );
  }
}

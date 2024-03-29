import 'package:flutter/material.dart';
import 'dart:io';
import 'package:cliente_api_flutter/contato.dart';
import 'package:cliente_api_flutter/contato_service.dart';
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
      title: 'Cadastro de Pessoas',
      theme: ThemeData(
        primarySwatch: Colors.red,
      ),
      home: const MyHomePage(),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key,}) : super(key: key);

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  List<Map<String, dynamic>> _contatos = [];
  Contato contato = Contato("", "", "");
  bool _carregando = true;

  void _listaContatos() async {
    _contatos = [];
    final data = await ContatoService.listaContatos();
    setState(() {
      for(var e in data){
        _contatos.add(<String, dynamic>{
          "id": e.id,
          "nome": e.nome,
          "email": e.email,
          "telefone": e.telefone,
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

  final TextEditingController _nomeController = TextEditingController();
  final TextEditingController _emailController = TextEditingController();
  final TextEditingController _telefoneController = TextEditingController();

  void _showForm(int? id) async{
    if(id != null){
      final existente = _contatos.firstWhere((element) => element["id"] == id);
      _nomeController.text = existente["nome"];
      _emailController.text = existente["email"];
      _telefoneController.text = existente["telefone"];
    }

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
              controller: _nomeController,
              decoration: const InputDecoration(
                labelText: "Nome",
              ),
            ),
            const SizedBox(height: 10),
            TextField(
              controller: _emailController,
              decoration: const InputDecoration(
                labelText: "Email",
              ),
            ),
            TextField(
              controller: _telefoneController,
              decoration: const InputDecoration(hintText: 'Telefone'),
            ),
            const SizedBox(height: 20),
            ElevatedButton(
              onPressed: () async {
                if(id == null){
                  await _insereContato();
                }
                if(id!=null){
                  await _atualizaContato(id);
                }
                _nomeController.text = '';
                _emailController.text = '';
                _telefoneController.text = '';

                Navigator.of(context).pop();
              },
              child: Text(id==null ? "Salvar" : "Atualizar"),
            )
          ]
        )
      )
    );
  }

  void telaToContato(){
    contato = Contato( _nomeController.text, _emailController.text, _telefoneController.text);
  }

  Future<void> _insereContato() async {
    telaToContato();
    int i = await ContatoService.insere(contato);
    if(i==0){
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Contato incluído com sucesso!'),));
    } else {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Não foi possível incluir!'),));
    }
    _listaContatos();
  }

  Future<void> _atualizaContato(int id) async {
    telaToContato();
    contato.id = id;
    int i = await ContatoService.atualiza(contato);
    if (i == 0) {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Contato alterado com sucesso!'),));
    } else {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Não foi possível alterar!'),));
    }
    _listaContatos();
  }

  void _excluirContato(int id) async{
    int i = await ContatoService.exclui(id);
    if(i == 0){
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Contato excluído com sucesso!'),));
    } else {
      ScaffoldMessenger.of(context).showSnackBar(const SnackBar(content: Text('Não foi possível excluir!'),));
    }
    _listaContatos();
  }

  @override
  Widget build(BuildContext context) {
   return Scaffold(
      appBar: AppBar(
        title: const Text('Cadastro de Pessoas'),
      ),
      body: _carregando ?
        const Center(child: CircularProgressIndicator(),) 
        :
        ListView.builder(
          itemCount: _contatos.length,
          itemBuilder: (context, index) => Card(
            color: Colors.red[200],
            margin: const EdgeInsets.all(15),
            child: ListTile(
              title: Text(_contatos[index]['nome']),
              subtitle: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                Text(_contatos[index]['email']),
                Text(_contatos[index]['telefone']),
              ],),
              trailing: SizedBox(
                width: 100,
                child: Row(
                  children: [
                    IconButton(
                      icon: const Icon(Icons.edit),
                      onPressed: () => _showForm(_contatos[index]['id']),),
                    IconButton(
                      icon: const Icon(Icons.delete),
                      onPressed: () =>
                      _excluirContato(_contatos[index]['id']),
                      ),
                    ],
                  ),
                )),
            
            )
          ),
          floatingActionButton: FloatingActionButton(
            child: const Icon(Icons.add),
            onPressed: () => _showForm(null),
          ),
    );
  }
}

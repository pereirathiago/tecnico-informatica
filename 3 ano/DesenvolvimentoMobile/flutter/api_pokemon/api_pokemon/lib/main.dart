import 'package:flutter/material.dart';
import 'dart:io';
import 'package:api_pokemon/pokemons.dart';
import 'package:api_pokemon/pokemon_service.dart';
import 'package:api_pokemon/dev_http_overrides.dart';

void main() {
  HttpOverrides.global = DevHttpOverrides();
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Pokemon',
      theme: ThemeData(
        primarySwatch: Colors.red,
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
  List<Map<String, dynamic>> _pokemons = [];
  Pokemons pokemons = Pokemons("", "");
  bool _carregando = true;

  void _listaPokemon() async {
    _pokemons = [];
    final data = await PokemonService.listaPokemon();
    setState(() {
      for (var e in data) {
        _pokemons.add(<String, dynamic>{
          "id": data.indexOf(e)+1,
          "nome": e.nome,
          "url": e.url,
        });
      }
      _carregando = false;
    });
  }

  @override
  void initState() {
    super.initState();
    _listaPokemon();
  }

  void _showForm(int id, String nome) async{

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
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Text(
              "Nome: $nome",
              textAlign: TextAlign.center,
              style: const TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
              ),
            ),

            Text(
              "Número na pokedex: $id",
              textAlign: TextAlign.center,
              style: const TextStyle(
                fontSize: 20,
                fontWeight: FontWeight.bold,
              ),
            ),

            const SizedBox(height: 15),
            
            Image.network('https://cdn.traction.one/pokedex/pokemon/${id}.png'),

            const SizedBox(height: 0),
          ]
        )
      )
    );
  }


  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Pokemon'),
      ),
      body: _carregando
          ? const Center(
              child: CircularProgressIndicator(),
            )
          : ListView.builder(
              itemCount: _pokemons.length,
              itemBuilder: (context, index) => Card(
                    color: Colors.red[200],
                    margin: const EdgeInsets.all(15),
                    child: ListTile(
                        title: Text(_pokemons[index]['nome']),
                        subtitle: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            Text('Numero na pokedex: ${_pokemons[index]['id']}'),
                          ],
                        ),
                        trailing: SizedBox(
                          width: 50,
                          child: Row(
                            children: [
                              IconButton(
                                icon: const Icon(
                                  Icons.remove_red_eye,
                                ),
                                onPressed: () => _showForm(_pokemons[index]['id'], _pokemons[index]['nome']),),
                              
                            ],
                          ),
                        )),
                  )),
    );
  }
}

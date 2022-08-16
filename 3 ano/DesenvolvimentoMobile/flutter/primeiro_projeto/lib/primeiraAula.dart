import 'package:flutter/material.dart';

class PrimeiraAula extends StatefulWidget {
  const PrimeiraAula({Key? key}) : super(key: key);

  @override
  State<PrimeiraAula> createState() => _PrimeiraAulaState();
}

class _PrimeiraAulaState extends State<PrimeiraAula> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Olá mundo'),
      ),
      body: Container(
        color: Colors.red,
        height: double.infinity,
        width: double.infinity,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            const Text(
              "Texto",
              style: TextStyle(
                color: Colors.lightBlueAccent,
                fontSize: 48,
                fontWeight: FontWeight.bold,
                fontStyle: FontStyle.italic,
                decoration: TextDecoration.none,
              ),
            ),
            Image.asset(
              "castle.png",
              height: 200,
              width: 200,
            ),
            const Text(
              "Outro texto",
            ),
          ],
        ),
      ),
      drawer: Container(
        color: Colors.yellow,
      ),
      floatingActionButton: FloatingActionButton(
        onPressed: () {},
        child: const Icon(Icons.ac_unit),
      ),
    );
  }
}
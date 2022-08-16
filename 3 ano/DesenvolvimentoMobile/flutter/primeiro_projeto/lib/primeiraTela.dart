import 'package:flutter/material.dart';

class PrimeiraTela extends StatefulWidget {
  const PrimeiraTela({Key? key}) : super(key: key);

  @override
  State<PrimeiraTela> createState() => _PrimeiraTelaState();
}

class _PrimeiraTelaState extends State<PrimeiraTela> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: const Text('Titulo'),
        ),
        body: Container(
          height: double.infinity,
          width: double.infinity,
          child: Column(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            crossAxisAlignment: CrossAxisAlignment.center,
            children: [
              const Text(
                "Titulo",
                style: TextStyle(
                  fontSize: 48,
                  fontWeight: FontWeight.bold,
                  decoration: TextDecoration.none,
                ),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Image.asset(
                    "castle.png",
                    height: 150,
                    width: 150,
                  ),
                  Image.asset(
                    "castle.png",
                    height: 150,
                    width: 150,
                  ),
                  Image.asset(
                    "castle.png",
                    height: 150,
                    width: 150,
                  ),
                ],
              ),
              const Text(
                "Titulo 2",
                style: TextStyle(
                  fontSize: 48,
                  fontWeight: FontWeight.bold,
                  decoration: TextDecoration.none,
                ),
              ),
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                crossAxisAlignment: CrossAxisAlignment.center,
                children: [
                  Image.asset(
                    "castle.png",
                    height: 200,
                    width: 200,
                  ),
                  Image.asset(
                    "castle.png",
                    height: 200,
                    width: 200,
                  ),
                ],
              )
            ],
          ),
        ));
  }
}

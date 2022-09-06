import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      theme: ThemeData(
        primarySwatch: Colors.green,
      ),
      home: const MyHomePage(title: 'App empresa'),
    );
  }
}

class MyHomePage extends StatefulWidget {
  const MyHomePage({Key? key, required this.title}) : super(key: key);
  final String title;

  @override
  State<MyHomePage> createState() => _MyHomePageState();
}

class _MyHomePageState extends State<MyHomePage> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        title: const Text('Spotify'),
      ),
      body: Container(
        color: const Color.fromARGB(255, 201, 201, 201),
        height: double.infinity,
        width: double.infinity,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.center,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
          const Text(
            "Ouvido recentemente ",
            style: TextStyle(
              color: Colors.black,
              fontSize: 24,
              decoration: TextDecoration.none,
              fontWeight: FontWeight.bold,
            ),
          ),
          Row(
            mainAxisAlignment: MainAxisAlignment.spaceEvenly,
            children: [
              Column(
                children: [
                  Image.asset(
                  "Alejandro.png",
                  height: 100,
                ),
                const Text(
                  "Alejandro",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    decoration: TextDecoration.none,
                  ),
                ),
              ],
              ),
              Column(
                
                children: [
                  Image.asset(
                  "cowboys.jpg",
                  height: 100,
                ),
                const Text(
                  "cowboys don't cry",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    decoration: TextDecoration.none,
                  ),
                ),
              ],
              ),
              Column(
                
                children: [
                  Image.asset(
                  "camaro.jpg",
                  height: 100,
                ),
                const Text(
                  "Camaro Amarelo",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 18,
                    fontWeight: FontWeight.bold,
                    decoration: TextDecoration.none,
                  ),
                ),
              ],
              ),
            ],
          )
        ]),
      ),
      drawer: Container(
        color: Colors.white,
        height: double.infinity,
        width: double.infinity,
        child: Column(
          mainAxisAlignment: MainAxisAlignment.spaceAround,
          crossAxisAlignment: CrossAxisAlignment.center,
          children: [
            Column(
              crossAxisAlignment: CrossAxisAlignment.center,
              children: [
                Image.asset(
                  "logo.png",
                  height: 60,
                ),
                const Text(
                  "Spotify",
                  style: TextStyle(
                    color: Color(0xff1DB954),
                    fontSize: 32,
                    fontWeight: FontWeight.bold,
                    decoration: TextDecoration.none,
                  ),
                ),
              ],
            ),
            Column(
              mainAxisAlignment: MainAxisAlignment.spaceAround,
              children: const [
                Text(
                  "R. Sen. Pinheiro Machado, 189 - Centro, Ponta Grossa - PR ",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 14,
                    decoration: TextDecoration.none,
                  ),
                ),
                Text(
                  "(42) 32240301",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 14,
                    decoration: TextDecoration.none,
                  ),
                ),
                Text(
                  "Desenvolvido por Thiago Pereira",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 12,
                    decoration: TextDecoration.none,
                  ),
                ),
              ],
            )
          ],
        ),
      ),
    );
  }
}

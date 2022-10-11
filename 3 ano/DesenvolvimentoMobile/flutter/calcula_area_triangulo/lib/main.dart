import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  // This widget is the root of your application.
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Flutter Demo',
      theme: ThemeData(
        primarySwatch: Colors.blue,
      ),
      home: const MyHomePage(title: 'Calculadora área do triangulo'),
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
  double _h = 0, _b = 0, _a = 0;
  final _tH = TextEditingController();
  final _tB = TextEditingController();

  void _calcularArea() {
    setState(() {
      _h = double.parse(_tH.text);
      _b = double.parse(_tB.text);
      _a = (_h * _b) / 2;
    });
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
        appBar: AppBar(
          title: Text(widget.title),
        ),
        body: Center(
          child: Padding(
            padding: const EdgeInsets.only(left: 32.0, right: 32.0),
            child: Column(
            mainAxisAlignment: MainAxisAlignment.center,
              children: [
                TextFormField(
                  decoration: const InputDecoration(
                    labelText: "Digite a altura",
                  ),
                  controller: _tH,
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 16.0),
                  child: TextFormField(
                    decoration: const InputDecoration(
                      labelText: "Digite a base",
                    ),
                    controller: _tB,
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 24.0),
                  child: ElevatedButton(
                    onPressed: _calcularArea,
                    child: const Text(
                      'Calcular área',
                    ),
                  ),
                ),
                Padding(
                  padding: const EdgeInsets.only(top: 16.0),
                  child: Text(
                    "A área do triangulo é $_a",
                  )
                ),
              ],
            ) 
          )         
        )
    );
  }
}

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
        child: ListView(
          children: [
            Image.asset(
              'logo.png',
              width: 200,
            ),
            Image.asset(
              'alejandro.png',
              width: 200,
            ),
            Image.asset(
              'camaro.png',
              width: 200,
            ),
            Image.asset(
              'cowboys.jpg',
              width: 200,
            ),
            Image.asset(
              'logo.png',
              width: 200,
            ),
            Image.asset(
              'alejandro.png',
              width: 200,
            ),
            Image.asset(
              'camaro.png',
              width: 200,
            ),
            Image.asset(
              'cowboys.jpg',
              width: 200,
            ),
          ],
        ),
      )
      );
  }
}

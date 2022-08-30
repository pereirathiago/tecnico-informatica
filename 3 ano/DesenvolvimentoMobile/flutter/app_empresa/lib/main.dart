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
        primarySwatch: Colors.blue,
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
        title: const Text('App empresa'),
      ),
      body: Container(
        color: Colors.black,
        height: double.infinity,
        width: double.infinity,
        child: Column(children: []),
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
              mainAxisAlignment: MainAxisAlignment.spaceEvenly,
              children: const [
                Text(
                  "texto",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 24,
                    decoration: TextDecoration.none,
                  ),
                ),
                Text(
                  "texto",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 24,
                    decoration: TextDecoration.none,
                  ),
                ),
                Text(
                  "texto",
                  style: TextStyle(
                    color: Colors.black,
                    fontSize: 24,
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

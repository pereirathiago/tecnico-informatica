import 'package:flutter/material.dart';

void main() {
  runApp(const MyApp());
}

class MyApp extends StatelessWidget {
  const MyApp({Key? key}) : super(key: key);

  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      debugShowCheckedModeBanner: false,
      theme: ThemeData(primaryColor: Colors.red),
      home: home(),
    );
  }

  Widget home() {
    return Container(
      color: Colors.red,
      child: const Center(
        child: Text(
          "Texto",
          style: TextStyle(
            color: Colors.lightBlueAccent,
            fontSize: 48,
            fontWeight: FontWeight.bold,
            fontStyle: FontStyle.italic,
            decoration: TextDecoration.none,
          ),
        ),
      ),
    );
  }
}

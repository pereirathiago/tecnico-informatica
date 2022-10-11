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
      home: const MyHomePage(title: 'Login'),
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
  String _login = "", _user = "", _password = "";
  final _tUser = TextEditingController();
  final _tPassword = TextEditingController();

  void _fazerLogin() {
    setState(() {
      _user = _tUser.text;
      _password = _tPassword.text;
      if (_user == "admin" && _password == "1234") {
        _login = "Usuário logado";
        _tUser.text = "";
        _tPassword.text = "";
      } else {
        _login = "Usuário ou senha incorretos";
      }
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
                        labelText: "Digite o usuário",
                      ),
                      controller: _tUser,
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 16.0),
                      child: TextFormField(
                        obscureText: true,
                        decoration: const InputDecoration(
                          labelText: "Digite a senha",
                        ),
                        controller: _tPassword,
                      ),
                    ),
                    Padding(
                      padding: const EdgeInsets.only(top: 24.0),
                      child: ElevatedButton(
                        onPressed: _fazerLogin,
                        child: const Text(
                          'Fazer Login',
                        ),
                      ),
                    ),
                    Padding(
                        padding: const EdgeInsets.only(top: 16.0),
                        child: Text(
                          _login,
                        )),
                  ],
                ))));
  }
}

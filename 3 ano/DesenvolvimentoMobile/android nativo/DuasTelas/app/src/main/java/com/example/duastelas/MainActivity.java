package com.example.duastelas;

import androidx.annotation.Nullable;
import androidx.appcompat.app.AppCompatActivity;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.os.PersistableBundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStreamWriter;

public class MainActivity extends AppCompatActivity {
    EditText tLogin, tSenha;
    CheckBox cSenha;
    Button bLogin;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tLogin = findViewById(R.id.tLogin);
        tSenha = findViewById(R.id.tSenha);
        bLogin = findViewById(R.id.bLogin);
        cSenha = findViewById(R.id.cSenha);

        bLogin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(tLogin.getText().toString().equals("Fulano")&&tSenha.getText().toString().equals("1234")){
                    if(cSenha.isChecked()){
                        gravarTexto(tLogin.getText().toString() + "\n" + tSenha.getText().toString());
                    } else {
                        gravarTexto("");
                    }
                    Intent i = new Intent(MainActivity.this, SegundaActivity.class);
                    i.putExtra("login",tLogin.getText().toString());
                    startActivity(i);
                } else{
                    Toast.makeText(MainActivity.this, "Login e/ou senha inválidos", Toast.LENGTH_SHORT).show();
                }
            }
        });
        String login = lerTextoLogin();
        String senha = lerTextoSenha();
        if(login!=null && senha!=null){
            cSenha.setChecked(true);
            tLogin.setText(login);
            tSenha.setText(senha);
        }
    }

    private void gravarTexto(String texto){
        try{
            OutputStreamWriter osw = new OutputStreamWriter(openFileOutput("senha.txt", Context.MODE_PRIVATE));
            osw.write(texto);
            osw.close();
        } catch (IOException e) {
            Log.v("MainActivity", e.getMessage());
        }
    }

    private String lerTextoLogin(){
        String lido = "";
        try {
            InputStream arq = openFileInput("senha.txt");
            if(arq != null){
                InputStreamReader isr = new InputStreamReader(arq);
                BufferedReader bis = new BufferedReader(isr);
                String linhalida="";
                lido = bis.readLine();
                arq.close();
            }
        }catch (IOException e){
            Log.v("MainActivity", e.getMessage());
        }
        return lido;
    }

    private String lerTextoSenha(){
        String lido = "";
        try {
            InputStream arq = openFileInput("senha.txt");
            if(arq != null){
                InputStreamReader isr = new InputStreamReader(arq);
                BufferedReader bis = new BufferedReader(isr);
                String linhalida="";
                bis.readLine();
                lido = bis.readLine();
                arq.close();
            }
        }catch (IOException e){
            Log.v("MainActivity", e.getMessage());
        }
        return lido;
    }
}
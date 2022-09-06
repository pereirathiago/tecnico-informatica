package com.example.calculaimc;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;

public class MainActivity extends AppCompatActivity {
    Button bCalcula;
    ImageView iResultado;
    EditText tAltura;
    EditText tPeso;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        bCalcula = findViewById(R.id.bCalcula);
        iResultado = findViewById(R.id.iResultado);
        tAltura = findViewById(R.id.tAltura);
        tPeso = findViewById(R.id.tPeso);

        bCalcula.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                double altura = Double.parseDouble(tAltura.getText().toString());
                double peso = Double.parseDouble(tPeso.getText().toString());
                double imc = peso / (altura * altura);
                if(imc > 26){
                    iResultado.setImageResource(R.drawable.emagrecer);
                } else
                    iResultado.setImageResource((R.drawable.saudavel));
            }
        });
    }
}
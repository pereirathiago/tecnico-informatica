package com.example.calculaidade;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {

    EditText tIdade;
    TextView tResultado;
    Button bCalcula;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tIdade =findViewById(R.id.tIdade);
        tResultado = findViewById(R.id.tResultado);
        bCalcula = findViewById(R.id.bCalcular);

        bCalcula.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int meses = Integer.parseInt(tIdade.getText().toString());
                tResultado.setText("Você já viveu " + Integer.toString(meses * 12));
            }
        });
    }
}
package com.example.idadelcalendario;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class MainActivity extends AppCompatActivity {

    EditText tData;
    TextView tResultado;
    Button bCalcula;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        tData =findViewById(R.id.tDatanasc);
        tResultado = findViewById(R.id.tResultado);
        bCalcula = findViewById(R.id.bCalcular);

        bCalcula.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Calendario c = new Calendario();
                SimpleDateFormat sdf = new SimpleDateFormat("dd/MM/yyyy");
                try {
                    c.setDatanasc(Calendar.getInstance());
                    c.getDatanasc().setTime(sdf.parse(tData.getText().toString()));
                    c.calcula();
                    tResultado.setText("Você viveu " + c.getMes()+" meses, ou " + c.getDia() + " dias, ou " + c.getHora() + " horas, ou " + c.getMinuto() + " minutos.");
                } catch (ParseException e) {
                    tResultado.setText("Erro de data");
                }
            }
        });
    }
}
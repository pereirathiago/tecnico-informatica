package com.example.dado;

import androidx.appcompat.app.AppCompatActivity;

import android.media.Image;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;

import java.util.Random;

public class MainActivity extends AppCompatActivity {
    Button bSorteia;
    ImageView iDado;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        bSorteia = findViewById(R.id.bSorteia);
        iDado = findViewById(R.id.iDado);

        bSorteia.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int sorteia = new Random().nextInt(6);
                switch (sorteia){
                    case 0:
                        iDado.setImageResource(R.drawable.dado1);
                        break;
                    case 1:
                        iDado.setImageResource(R.drawable.dado2);
                        break;
                    case 2:
                        iDado.setImageResource(R.drawable.dado3);
                        break;
                    case 3:
                        iDado.setImageResource(R.drawable.dado4);
                        break;
                    case 4:
                        iDado.setImageResource(R.drawable.dado5);
                        break;
                    case 5:
                        iDado.setImageResource(R.drawable.dado6);
                        break;
                }
            }
        });
    }
}
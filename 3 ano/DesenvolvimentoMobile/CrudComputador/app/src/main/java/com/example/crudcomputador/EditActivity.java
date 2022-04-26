package com.example.crudcomputador;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

public class EditActivity extends AppCompatActivity {
    EditText tId,tComponente, tMarca, tPreco;
    Button bSalva;
    Pc pc;
    BdPc bd;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        int id = 0;
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_edit);
        pc = new Pc();
        bd = new BdPc(getBaseContext());
        tId =findViewById(R.id.tId);
        tComponente = findViewById(R.id.tComponente);
        tMarca = findViewById(R.id.tMarca);
        tPreco = findViewById(R.id.tPreco);
        bSalva = findViewById(R.id.bSalva);
        Bundle extra = getIntent().getExtras();
        tId.setText("0");
        if (extra != null) {
            id = extra.getInt("id");
        } else {
            id = 0;
        }
        if (id == 0) {
            setTitle("Novo Cadastro");
            bSalva.setText("Insere");
        } else {
            setTitle("Alteração");
            bSalva.setText("Altera");
            pc = bd.localiza(id);
            pcToTela();
        }
        bSalva.setOnClickListener(new View.OnClickListener() { @Override
        public void onClick(View view) {
            telaToPc();
            if (pc.getId() == 0)
                bd.insere(pc);
            else
                bd.altera(pc);
            finish();
        }
        });
    }

    private void pcToTela(){
        tId.setText(Integer.toString(pc.getId()));
        tComponente.setText(pc.getComponente());
        tMarca.setText(pc.getMarca());
        tPreco.setText(Double.toString(pc.getPreco()));
    }
    private void telaToPc() {
        pc.setId(Integer.parseInt(tId.getText().toString()));
        pc.setComponente(tComponente.getText().toString());
        pc.setMarca(tMarca.getText().toString());
        pc.setPreco(Double.parseDouble(tPreco.getText().toString()));
    }
}
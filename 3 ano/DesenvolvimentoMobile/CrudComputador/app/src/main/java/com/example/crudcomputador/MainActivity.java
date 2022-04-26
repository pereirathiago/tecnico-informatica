package com.example.crudcomputador;

import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;

import android.content.DialogInterface;
import android.content.Intent;
import android.database.Cursor;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleCursorAdapter;

public class MainActivity extends AppCompatActivity {
    private ListView lista;
    private Button bNovo;
    int _id;
    BdPc bd;
    Cursor cursor;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        setTitle("Cadastro de pc");
        lista = findViewById(R.id.listView);
        bNovo = findViewById(R.id.bNovo);
        bd = new BdPc(getBaseContext());
        preencheView();
        bNovo.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent i = new Intent(MainActivity.this, EditActivity.class);
                i.putExtra("id", 0);
                startActivity(i);
            }
        });
        lista.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                cursor.moveToPosition(position);
                _id = cursor.getInt(cursor.getColumnIndexOrThrow("_id"));
                Intent intent = new Intent(MainActivity.this, EditActivity.class);
                intent.putExtra("id", _id);
                startActivity(intent);

            }
        });
        lista.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                cursor.moveToPosition(i);
                _id = cursor.getInt(cursor.getColumnIndexOrThrow("_id"));
                Pc pc = bd.localiza(_id);
                AlertDialog.Builder builder = new AlertDialog.Builder(MainActivity.this);
                builder.setMessage("Deseja realmente excluir " + pc.getComponente() + "?")
                        .setCancelable(false)
                        .setPositiveButton("Sim", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int id) {
                                bd.exclui(_id);
                                preencheView();
                            }
                        })
                        .setNegativeButton("Não", new DialogInterface.OnClickListener() {
                            public void onClick(DialogInterface dialog, int id) {
                                dialog.cancel();
                            }
                        });
                AlertDialog alert = builder.create();
                alert.show();
                return true;
            }
        });
    }
    @Override
    protected void onResume() {
        super.onResume();
        preencheView();
    }

    private void preencheView() {

        cursor = bd.pesquisa();

        String[] nomeCampos = new String[]{"_id", "componente"};
        int[] idViews = new int[]{R.id._id, R.id.componente};

        SimpleCursorAdapter adaptador = new SimpleCursorAdapter(getBaseContext(), R.layout.list_view, cursor, nomeCampos, idViews, 0);
        lista.setAdapter(adaptador);
    }
}
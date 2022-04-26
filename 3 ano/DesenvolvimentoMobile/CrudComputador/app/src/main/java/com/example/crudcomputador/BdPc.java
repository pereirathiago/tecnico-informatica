package com.example.crudcomputador;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;

public class BdPc {
    private SQLiteDatabase db;
    private Bd banco;
    public BdPc(Context context){
        banco = new Bd(context);
    }

    public String insere(Pc pc) {
        ContentValues valores;
        long resultado;
        db= banco.getWritableDatabase();
        valores = new ContentValues();
        valores.put("componente", pc.getComponente());
        valores.put("marca", pc.getMarca());
        valores.put("preco", pc.getPreco());

        resultado = db.insert("pc", null, valores);
        db.close();
        if(resultado == -1)
            return "Erro ao inserir registro";
        else
            return "Registro Inserido com sucesso";
    }
    public void altera(Pc pc){
        ContentValues valores;
        String where;
        db = banco.getWritableDatabase();
        where = "_id=" + pc.getId();
        valores = new ContentValues();
        valores.put("componente", pc.getComponente());
        valores.put("marca", pc.getMarca());
        valores.put("preco", pc.getPreco());
        db.update("pc",valores,where,null);
        db.close();
    }
    public void exclui(int id){
        String where = "_id=" + id;
        db = banco.getReadableDatabase();
        db.delete("pc",where,null);
        db.close();
    }
    public Pc localiza(int id){
        Cursor cursor;
        Pc pc=new Pc();
        String[] campos = {"_id","componente","marca", "preco"};
        String where = "_id=" + id;
        db = banco.getReadableDatabase();
        cursor = db.query("pc",campos,where, null, null, null, null, null);
        if(cursor!=null){
            cursor.moveToFirst();
            pc.setId(cursor.getInt(cursor.getColumnIndexOrThrow("_id")));
            pc.setComponente(cursor.getString(cursor.getColumnIndexOrThrow("componente")));
            pc.setMarca(cursor.getString(cursor.getColumnIndexOrThrow("marca")));
            pc.setPreco(cursor.getDouble(cursor.getColumnIndexOrThrow("preco")));
        }
        db.close();
        return pc;
    }
    public Cursor pesquisa(){
        Cursor cursor;
        String[] campos = {"_id","componente"};
        db = banco.getReadableDatabase();
        cursor = db.query("pc", campos, null, null, null, null, null, null);
        if(cursor!=null){
            cursor.moveToFirst();
        }
        db.close(); return cursor;
    }
}

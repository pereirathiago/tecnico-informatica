package com.example.crudcomputador;

import android.content.Context;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class Bd extends SQLiteOpenHelper {
    public Bd(Context context){
        super(context, "pc.db", null, 1);
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        String sql = "CREATE TABLE pc (" +
                "_id integer primary key autoincrement," +
                "componente text," +
                "marca text," +
                "preco double" +
                ")";
        db.execSQL(sql);
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int i, int i1) {

    }
}

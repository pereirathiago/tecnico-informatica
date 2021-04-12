/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package bd;

import java.sql.*;

/**
 *
 * @author Thiago
 */
public class Bd {

    private static Connection con = null;
    private static String driver = "com.mysql.jdbc.Driver";
    private static String url = "jdbc:mysql://localhost/usuario";
    private static String usuario = "root";
    private static String senha = "vertrigo";

    public static Connection getCon() {
        try {
            if (con == null || con.isClosed() || !con.isValid(1000)) {
                Class.forName(driver);
                con = DriverManager.getConnection(getUrl(), getUsuario(), getSenha());
            }
        } catch (Exception e) {
            System.out.println(" erro na conexao\n" + e.getMessage());
        }
        return con;
    }

    /**
     * @param aCon the con to set
     */
    public static void setCon(Connection aCon) {
        con = aCon;
    }

    /**
     * @return the drive
     */
    public static String getDrive() {
        return driver;
    }

    /**
     * @param aDrive the drive to set
     */
    public static void setDrive(String aDrive) {
        driver = aDrive;
    }

    /**
     * @return the url
     */
    public static String getUrl() {
        return url;
    }

    /**
     * @param aUrl the url to set
     */
    public static void setUrl(String aUrl) {
        url = aUrl;
    }

    /**
     * @return the usuario
     */
    public static String getUsuario() {
        return usuario;
    }

    /**
     * @param aUsuario the usuario to set
     */
    public static void setUsuario(String aUsuario) {
        usuario = aUsuario;
    }

    /**
     * @return the senha
     */
    public static String getSenha() {
        return senha;
    }

    /**
     * @param aSenha the senha to set
     */
    public static void setSenha(String aSenha) {
        senha = aSenha;
    }
}

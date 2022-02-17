/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

/**
 *
 * @author Thiago
 */
public class Ponto {
    private double x;
    private double y;
    private boolean pu;
    public Ponto(double x, double y, boolean pu){
        this.x=x;
        this.y=y;
        this.pu=pu;
    }
    public Ponto(){}

    /**
     * @return the x
     */
    public double getX() {
        return x;
    }

    /**
     * @param x the x to set
     */
    public void setX(double x) {
        this.x = x;
    }

    /**
     * @return the y
     */
    public double getY() {
        return y;
    }

    /**
     * @param y the y to set
     */
    public void setY(double y) {
        this.y = y;
    }

    /**
     * @return the pu
     */
    public boolean isPu() {
        return pu;
    }

    /**
     * @param pu the pu to set
     */
    public void setPu(boolean pu) {
        this.pu = pu;
    }
}

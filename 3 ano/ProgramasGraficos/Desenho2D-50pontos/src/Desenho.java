
import java.awt.Dimension;
import java.awt.Graphics;
import java.util.Vector;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
/**
 *
 * @author Thiago
 */
public class Desenho {

    private double xwmax, xwmin, ywmax, ywmin, xvmax, xvmin, yvmax, yvmin;
    private double xmax, ymax, xcoord, ycoord, xd, yd, mx, my;
    Vector desenho = new Vector();

    public void setMundo(double x1, double y1, double x2, double y2) {
        xwmax = x2;
        ywmax = y2;
        xwmin = y1;
        ywmin = y1;
    }

    public void setDimension(Dimension d) {
        xmax = d.width;
        ymax = d.height;
    }

    public double getMouseX() {
        return mx;
    }

    public double getMouseY() {
        return my;
    }

    public void setMouse(int x, int y) {
        mx = (((x - xvmin) / ((xvmax - xvmin) / (xwmax - xwmin))) + xwmin) / xmax;
        my = (((y - yvmin) / ((yvmax - yvmin) / (ywmax - ywmin))) + ywmin) / ymax;
    }

    public void setViewPort(double x1, double y1, double x2, double y2) {
        xvmax = x2;
        yvmax = y2;
        xvmin = x1;
        yvmin = y1;
    }

    private void mapCoord(double x, double y) {
        double xv = (((x - xwmin) * ((xvmax - xvmin) / (xwmax - xwmin))) + xvmin);
        double yv = (((y - ywmin) * ((yvmax - yvmin) / (ywmax - ywmin))) + yvmin);
        xd = xv * xmax;
        yd = yv * ymax;
    }

    private void linhaAte(Graphics g, double x, double y) {
        double xi, yi;
        mapCoord(xcoord, ycoord);
        xi = xd;
        yi = yd;
        mapCoord(x, y);
        g.drawLine((int) xi, (int) yi, (int) xd, (int) yd);
        xcoord = x;
        ycoord = y;
    }

    private void movaPara(Graphics g, double x, double y, boolean pu) {
        if (pu) {
            xcoord = x;
            ycoord = y;
        } else {
            linhaAte(g, x, y);
        }
    }

    public void desenha(Graphics g) {
        Ponto p;
        for (int i = 0; i < desenho.size(); i++) {
            p = (Ponto) desenho.get(i);
            movaPara(g, p.getX(), p.getY(), p.isPu());
        }
    }

    public void nome() {
        // T
        desenho.addElement(new Ponto(3, 9, true));
        desenho.addElement(new Ponto(1, 9, false));
        desenho.addElement(new Ponto(1, 10, false));
        desenho.addElement(new Ponto(1.8, 10, false));
        desenho.addElement(new Ponto(1.8, 13, false));
        desenho.addElement(new Ponto(2.3, 13, false));
        desenho.addElement(new Ponto(2.3, 10, false));
        desenho.addElement(new Ponto(3, 10, false));
        desenho.addElement(new Ponto(3, 9, false));
        // H
        desenho.addElement(new Ponto(3.5, 9, true));
        desenho.addElement(new Ponto(3.5, 13, false));
        desenho.addElement(new Ponto(4, 13, false));
        desenho.addElement(new Ponto(4, 11.6, false));
        desenho.addElement(new Ponto(4.5, 11.6, false));
        desenho.addElement(new Ponto(4.5, 13, false));
        desenho.addElement(new Ponto(5, 13, false));
        desenho.addElement(new Ponto(5, 9, false));
        desenho.addElement(new Ponto(4.5, 9, false));
        desenho.addElement(new Ponto(4.5, 10.5, false));
        desenho.addElement(new Ponto(4, 10.5, false));
        desenho.addElement(new Ponto(4, 9, false));
        desenho.addElement(new Ponto(3.5, 9, false));
        // I
        desenho.addElement(new Ponto(5.5, 9, true));
        desenho.addElement(new Ponto(5.5, 13, false));
        desenho.addElement(new Ponto(6, 13, false));
        desenho.addElement(new Ponto(6, 9, false));
        desenho.addElement(new Ponto(5.5, 9, false));
        // A
        desenho.addElement(new Ponto(6.5, 9, true));
        desenho.addElement(new Ponto(6.5, 13, false));
        desenho.addElement(new Ponto(7, 13, false));
        desenho.addElement(new Ponto(7, 11.6, false));
        desenho.addElement(new Ponto(7.5, 11.6, false));
        desenho.addElement(new Ponto(7.5, 13, false));
        desenho.addElement(new Ponto(8, 13, false));
        desenho.addElement(new Ponto(8, 9, false));
        desenho.addElement(new Ponto(6.5, 9, false));
        // meio do A
        desenho.addElement(new Ponto(7, 10, true));
        desenho.addElement(new Ponto(7, 10.8, false));
        desenho.addElement(new Ponto(7.5, 10.8, false));
        desenho.addElement(new Ponto(7.5, 10, false));
        desenho.addElement(new Ponto(7, 10, false));
        // G
        desenho.addElement(new Ponto(8.5, 9, true));
        desenho.addElement(new Ponto(8.5, 13, false));
        desenho.addElement(new Ponto(10, 13, false));
        desenho.addElement(new Ponto(10, 11, false));
        desenho.addElement(new Ponto(9.2, 11, false));
        desenho.addElement(new Ponto(9.2, 11.7, false));
        desenho.addElement(new Ponto(9.6, 11.7, false));
        desenho.addElement(new Ponto(9.6, 12.35, false));
        desenho.addElement(new Ponto(9, 12.35, false));
        desenho.addElement(new Ponto(9, 9.8, false));
        desenho.addElement(new Ponto(10, 9.8, false));
        desenho.addElement(new Ponto(10, 9, false));
        desenho.addElement(new Ponto(8.5, 9, false));
        // O
        desenho.addElement(new Ponto(10.5, 9, true));
        desenho.addElement(new Ponto(10.5, 13, false));
        desenho.addElement(new Ponto(12, 13, false));
        desenho.addElement(new Ponto(12, 9, false));
        desenho.addElement(new Ponto(10.5, 9, false));
        // parte de dentro O
        desenho.addElement(new Ponto(11, 10, true));
        desenho.addElement(new Ponto(11, 12, false));
        desenho.addElement(new Ponto(11.5, 12, false));
        desenho.addElement(new Ponto(11.5, 10, false));
        desenho.addElement(new Ponto(11, 10, false));
    }

    public void translada(double dx, double dy) {
        Ponto p;
        for (int i = 0; i < desenho.size(); i++) {
            p = (Ponto) desenho.get(i);
            p.setX(p.getX() + dx);
            p.setY(p.getY() + dy);
            desenho.set(i, p);
        }
    }

    public void rotaciona(double ang) {
        Ponto p;
        for (int i = 0; i < desenho.size(); i++) {
            p = (Ponto) desenho.get(i);
            double xx = p.getX();
            double yy = p.getY();
            p.setX(xx * Math.cos(ang) + yy * (-Math.sin(ang)));
            p.setY(xx * Math.sin(ang) + yy * Math.cos(ang));
            desenho.set(i, p);
        }
    }

    public void deforma(boolean maior) {
        Ponto p;
        for (int i = 0; i < desenho.size(); i++) {
            if (maior) {
                p = (Ponto) desenho.get(i);
                p.setX(((p.getX() - mx) * 0.1) + p.getX());
                p.setY(((p.getY() - my) * 0.1) + p.getY());
                desenho.set(i, p);
            } else {
                p = (Ponto) desenho.get(i);
                p.setX(p.getX() - ((p.getX() - mx) * 0.1));
                p.setY(p.getY() - ((p.getY() - my) * 0.1));
                desenho.set(i, p);
            }
        }
    }
}

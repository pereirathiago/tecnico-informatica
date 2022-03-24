
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

    public void cenario() {
        // cabeça
        arco(3.42, 10.28, .8, 1.2, 8.3);
        desenho.addElement(new Ponto(3.42, 11.1, true));
        desenho.addElement(new Ponto(3.42, 11.35, false));
        // corpo
        desenho.addElement(new Ponto(2.8, 11.35, false));
        desenho.addElement(new Ponto(2.8, 13.5, false));
        desenho.addElement(new Ponto(4.04, 13.5, false));
        desenho.addElement(new Ponto(4.04, 11.35, false));
        desenho.addElement(new Ponto(2.8, 11.35, false));
        // bracos
        desenho.addElement(new Ponto(1.9, 12.5, false));
        desenho.addElement(new Ponto(4.04, 11.35, true));
        desenho.addElement(new Ponto(4.8, 12.8, false));
        // pernas
        desenho.addElement(new Ponto(3.1, 13.5, true));
        desenho.addElement(new Ponto(3.1, 14.7, false));
        desenho.addElement(new Ponto(3.7, 13.5, true));
        desenho.addElement(new Ponto(3.7, 14.7, false));

        // sol
        arco(.5, 0.5, 2.8, 1.2, 8.3);

        // terra
        desenho.addElement(new Ponto(0, 14.7, true));
        desenho.addElement(new Ponto(30, 14.7, false));

        // casa
        //desenho.addElement(new Ponto(10, 14, true)); // linha de baixo
        //desenho.addElement(new Ponto(25, 14, false)); // linha de baixo
        desenho.addElement(new Ponto(25, 14, true));
        desenho.addElement(new Ponto(25, 6, false));
        desenho.addElement(new Ponto(10, 6, false));
        desenho.addElement(new Ponto(10, 14, false));
        // casa telhado
        desenho.addElement(new Ponto(10, 6, true));
        desenho.addElement(new Ponto(17, 2, false));
        desenho.addElement(new Ponto(25, 6, false));
        // casa porta
        desenho.addElement(new Ponto(12, 14, true));
        desenho.addElement(new Ponto(12, 8.5, false));
        desenho.addElement(new Ponto(15, 8.5, false));
        desenho.addElement(new Ponto(15, 14, false));
        // casa janela
        desenho.addElement(new Ponto(17, 9.4, true));
        desenho.addElement(new Ponto(22, 9.4, false));
        desenho.addElement(new Ponto(22, 12.5, false));
        //desenho.addElement(new Ponto(17, 12.5, false));
        desenho.addElement(new Ponto(17, 12.5, true));
        desenho.addElement(new Ponto(17, 9.4, false));

        // cerca
        desenho.addElement(new Ponto(8, 14.7, true));
        desenho.addElement(new Ponto(8, 12, false));
        desenho.addElement(new Ponto(8.5, 11.4, false));
        desenho.addElement(new Ponto(9, 12, false));
        desenho.addElement(new Ponto(9, 14.7, false));
        desenho.addElement(new Ponto(9, 12, true));
        desenho.addElement(new Ponto(9.5, 11.4, false));
        desenho.addElement(new Ponto(10, 12, false));
        desenho.addElement(new Ponto(10, 14.7, false));
        desenho.addElement(new Ponto(10, 12, true));
        desenho.addElement(new Ponto(10.5, 11.4, false));
        desenho.addElement(new Ponto(11, 12, false));
        desenho.addElement(new Ponto(11, 14.7, false));
        desenho.addElement(new Ponto(11, 12, true));
        desenho.addElement(new Ponto(11.5, 11.4, false));
        desenho.addElement(new Ponto(12, 12, false));
        desenho.addElement(new Ponto(12, 14.7, false));
        desenho.addElement(new Ponto(12, 12, true));
        desenho.addElement(new Ponto(12.5, 11.4, false));
        desenho.addElement(new Ponto(13, 12, false));
        desenho.addElement(new Ponto(13, 14.7, false));
        desenho.addElement(new Ponto(13, 12, true));
        desenho.addElement(new Ponto(13.5, 11.4, false));
        desenho.addElement(new Ponto(14, 12, false));
        desenho.addElement(new Ponto(14, 14.7, false));
        desenho.addElement(new Ponto(14, 12, true));
        desenho.addElement(new Ponto(14.5, 11.4, false));
        desenho.addElement(new Ponto(15, 12, false));
        desenho.addElement(new Ponto(15, 14.7, false));
        desenho.addElement(new Ponto(15, 12, true));
        desenho.addElement(new Ponto(15.5, 11.4, false));
        desenho.addElement(new Ponto(16, 12, false));
        desenho.addElement(new Ponto(16, 14.7, false));
        desenho.addElement(new Ponto(16, 12, true));
        desenho.addElement(new Ponto(16.5, 11.4, false));
        desenho.addElement(new Ponto(17, 12, false));
        desenho.addElement(new Ponto(17, 14.7, false));
        desenho.addElement(new Ponto(17, 12, true));
        desenho.addElement(new Ponto(17.5, 11.4, false));
        desenho.addElement(new Ponto(18, 12, false));
        desenho.addElement(new Ponto(18, 14.7, false));
        desenho.addElement(new Ponto(18, 12, true));
        desenho.addElement(new Ponto(18.5, 11.4, false));
        desenho.addElement(new Ponto(19, 12, false));
        desenho.addElement(new Ponto(19, 14.7, false));
        desenho.addElement(new Ponto(19, 12, true));
        desenho.addElement(new Ponto(19.5, 11.4, false));
        desenho.addElement(new Ponto(20, 12, false));
        desenho.addElement(new Ponto(20, 14.7, false));
        desenho.addElement(new Ponto(20, 12, true));
        desenho.addElement(new Ponto(20.5, 11.4, false));
        desenho.addElement(new Ponto(21, 12, false));
        desenho.addElement(new Ponto(21, 14.7, false));
        desenho.addElement(new Ponto(21, 12, true));
        desenho.addElement(new Ponto(21.5, 11.4, false));
        desenho.addElement(new Ponto(22, 12, false));
        desenho.addElement(new Ponto(22, 14.7, false));
        desenho.addElement(new Ponto(22, 12, true));
        desenho.addElement(new Ponto(22.5, 11.4, false));
        desenho.addElement(new Ponto(23, 12, false));
        desenho.addElement(new Ponto(23, 14.7, false));
        desenho.addElement(new Ponto(23, 12, true));
        desenho.addElement(new Ponto(23.5, 11.4, false));
        desenho.addElement(new Ponto(24, 12, false));
        desenho.addElement(new Ponto(24, 14.7, false));
        desenho.addElement(new Ponto(24, 12, true));
        desenho.addElement(new Ponto(24.5, 11.4, false));
        desenho.addElement(new Ponto(25, 12, false));
        desenho.addElement(new Ponto(25, 14.7, false));
        desenho.addElement(new Ponto(25, 12, true));
        desenho.addElement(new Ponto(25.5, 11.4, false));
        desenho.addElement(new Ponto(26, 12, false));
        desenho.addElement(new Ponto(26, 14.7, false));
        desenho.addElement(new Ponto(26, 12, true));
        desenho.addElement(new Ponto(26.5, 11.4, false));
        desenho.addElement(new Ponto(27, 12, false));
        desenho.addElement(new Ponto(27, 14.7, false));
        desenho.addElement(new Ponto(27, 12, true));
        desenho.addElement(new Ponto(27.5, 11.4, false));
        desenho.addElement(new Ponto(28, 12, false));
        desenho.addElement(new Ponto(28, 14.7, false));
        desenho.addElement(new Ponto(28, 12, true));
        desenho.addElement(new Ponto(28.5, 11.4, false));
        desenho.addElement(new Ponto(29, 12, false));
        desenho.addElement(new Ponto(29, 14.7, false));
        desenho.addElement(new Ponto(29, 12, true));
        desenho.addElement(new Ponto(29.5, 11.4, false));
        desenho.addElement(new Ponto(30, 12, false));
        desenho.addElement(new Ponto(30, 14.7, false));
        desenho.addElement(new Ponto(30, 12, true));
        
    }

    public void arco(double centroX, double centroY, double raio, double inicio, double fim) {
        desenho.add(new Ponto(centroX + raio * Math.cos(inicio), centroY + raio * Math.sin(inicio), true));
        for (double z = inicio; z <= fim; z += .1) {
            desenho.add(new Ponto(centroX + raio * Math.cos(z), centroY + raio * Math.sin(z), false));
        }
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

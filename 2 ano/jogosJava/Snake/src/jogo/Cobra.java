/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jogo;

import java.awt.Image;
import java.awt.Rectangle;
import javax.swing.ImageIcon;

/**
 *
 * @author 2info2021
 */
public class Cobra {
    private int altura = 20;
    private int largura = 20;
    private Image imagem = new ImageIcon(getClass().getResource("/imagens/cobra.png")).getImage().getScaledInstance(largura,altura,1);
    private double x;
    private double y;
    private int dx = 0;
    private int dy = 0;
    public Rectangle getLimites() {
        return new Rectangle((int) getX(), (int) getY(), getLargura(), getAltura());
    }
    public Cobra(double x, double y) {
        this.x = x;
        this.y = y;
    }
    public Cobra() {
        y = 0;
        x = 0;
    }
    public void mexer() {
        setX(getX() + getDx());
        setY(getY() + getDy());
    }

    /**
     * @return the altura
     */
    public int getAltura() {
        return altura;
    }

    /**
     * @param altura the altura to set
     */
    public void setAltura(int altura) {
        this.altura = altura;
    }

    /**
     * @return the largura
     */
    public int getLargura() {
        return largura;
    }

    /**
     * @param largura the largura to set
     */
    public void setLargura(int largura) {
        this.largura = largura;
    }

    /**
     * @return the imagem
     */
    public Image getImagem() {
        return imagem;
    }

    /**
     * @param imagem the imagem to set
     */
    public void setImagem(Image imagem) {
        this.imagem = imagem;
    }

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
     * @return the dx
     */
    public int getDx() {
        return dx;
    }

    /**
     * @param dx the dx to set
     */
    public void setDx(int dx) {
        this.dx = dx;
    }

    /**
     * @return the dy
     */
    public int getDy() {
        return dy;
    }

    /**
     * @param dy the dy to set
     */
    public void setDy(int dy) {
        this.dy = dy;
    }
    
}

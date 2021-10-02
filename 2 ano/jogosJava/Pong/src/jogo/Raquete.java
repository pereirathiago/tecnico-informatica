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
 * @author Thiago
 */
public class Raquete {

    private int altura = 70;
    private int largura = 20;
    private Image imagem = new ImageIcon(getClass().getResource("/imagens/raquete.png")).getImage().getScaledInstance(getLargura(), getAltura(), 1);
    private Image imagemPc = new ImageIcon(getClass().getResource("/imagens/raquetePc.png")).getImage().getScaledInstance(getLargura(), getAltura(), 1);
    private Image imagemJ2 = new ImageIcon(getClass().getResource("/imagens/raqueteJ2.png")).getImage().getScaledInstance(getLargura(), getAltura(), 1);
    private double x;
    private double y;
    private double dy = 0;

    public Rectangle getLimites() {
        return new Rectangle((int) getX(), (int) getY(), getLargura(), getAltura());
    }

    public void mexer() {
        setY(getY() + getDy());
    }

    public Raquete(double x, double y) {
        this.x = x;
        this.y = y;
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
     * @return the dy
     */
    public double getDy() {
        return dy;
    }

    /**
     * @param dy the dy to set
     */
    public void setDy(double dy) {
        this.dy = dy;
    }

    /**
     * @return the imagemPc
     */
    public Image getImagemPc() {
        return imagemPc;
    }

    /**
     * @param imagemPc the imagemPc to set
     */
    public void setImagemPc(Image imagemPc) {
        this.imagemPc = imagemPc;
    }

    /**
     * @return the imagemJ2
     */
    public Image getImagemJ2() {
        return imagemJ2;
    }

    /**
     * @param imagemJ2 the imagemJ2 to set
     */
    public void setImagemJ2(Image imagemJ2) {
        this.imagemJ2 = imagemJ2;
    }
}

package Exercicio1;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author fcsa0719
 */
public class Paralelepipedo {

    private int altura;
    private int largura;
    private int comprimento;
    private int volume;
    private int area;

    public int getAltura() {
        return altura;
    }

    public void setAltura(int altura) {
        this.altura = altura;
    }

    public int getLargura() {
        return largura;
    }

    public void setLargura(int largura) {
        this.largura = largura;
    }

    public int getComprimento() {
        return comprimento;
    }

    public void setComprimento(int comprimento) {
        this.comprimento = comprimento;
    }

    public int getVolume() {
        return volume;
    }

    public void setVolume(int volume) {
        this.volume = volume;
    }

    public int getArea() {
        return area;
    }

    public void setArea(int area) {
        this.area = area;
    }

    public void calcVolume() {
        setVolume(getLargura() * getAltura() * getComprimento());
    }

    public void calcArea() {
        int a = 2 * (getAltura() * getLargura() + getAltura() * getComprimento() + getLargura() * getComprimento());
        setArea(a);
    }

    public static void main(String[] args) {
        Paralelepipedo p = new Paralelepipedo();
        p.setAltura(5);
        p.setLargura(8);
        p.setComprimento(10);
        p.calcVolume();
        p.calcArea();
        System.out.println("vol " + p.getVolume());
        System.out.println("area " + p.getArea());
    }
}

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package pacman;

import java.awt.event.ActionListener;
import javax.swing.JPanel;
import javax.swing.Timer;

/**
 *
 * @author 2info2021
 */
public class Labirinto extends JPanel implements ActionListener {

    Ghost ghost[] = new Ghost[4];
    PacMan pacman;
    String msg = "";
    Timer t;
    int seq = 0, ponto = 0, comida = 0, tempovulneravela = 0, vida = 3, record;
    char labirinto[][];
    int altura, largura, passoX, passoY;

    public Labirinto(int largura, int altura) {
        setFocusable(true);
        setDoubleBuffered(true);
        setSize(largura, altura);
        this.altura = altura;
        this.largura = largura;
        passoX = largura / 19;
        passoY = altura / 21;
        t = new Timer(50, this);
    }

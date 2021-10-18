/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jogo;

import com.sun.glass.events.KeyEvent;
import java.awt.Image;
import java.awt.event.ActionListener;
import javax.swing.ImageIcon;
import javax.swing.JPanel;
import javax.swing.Timer;

/**
 *
 * @author 2info2021
 */
public class Campo extends JPanel implements ActionListener {
    Fruta fruta;
    Cobra cobra;
    Cobra corpo[] = new Cobra[1000];
    Cenario cenario[] = new Cenario[10];
    int tamanhoCenario = 4;
    int tamanho = 3;
    Timer t;
    Image fundo;
    int pontoJ = 0;
    int vida = 3;
    String msg = "";
    
    public Campo(int largura, final int altura) {
        setFocusable(true);
        setDoubleBuffered(true);
        setSize(largura, altura);
        fundo = new ImageIcon(getClass().getResource("/imagens/campo.png")).getImage().getScaledInstance(largura, altura,1);
        inicializa();
        repaint();
        t = new Timer(100, this);
        t.start();
        addKeyListener(new KeyAdapter()) {
            public void keyPressed(KeyEvent e) {
                int tecla = e.getKeyCode();
                if(tecla == KeyEvent.VK_UP) {
                    
                }
            }
        }
    }
}

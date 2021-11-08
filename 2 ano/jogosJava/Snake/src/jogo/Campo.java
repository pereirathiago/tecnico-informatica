/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jogo;

import java.awt.Color;
import java.awt.Font;
import java.awt.FontMetrics;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyAdapter;
import java.awt.event.KeyEvent;
import java.awt.geom.Rectangle2D;
import java.util.Random;
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
    Poder poder;
    Cobra corpo[] = new Cobra[1000];
    Cenario cenario[] = new Cenario[15];
    int tamanhoCenario = 4;
    int tamanho = 3;
    Timer t;
    Image fundo;
    int pontoJ = 0;
    int vida = 1;
    String msg = "";

    public Campo(int largura, final int altura) {
        setFocusable(true);
        setDoubleBuffered(true);
        setSize(largura, altura);
        fundo = new ImageIcon(getClass().getResource("/imagens/campo.png")).getImage().getScaledInstance(largura, altura, 1);
        inicializa();
        repaint();
        t = new Timer(100, this);
        t.start();
        addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                int tecla = e.getKeyCode();
                if (tecla == KeyEvent.VK_UP) {
                    cobra.setDy(-20);
                    cobra.setDx(0);
                }
                if (tecla == KeyEvent.VK_DOWN) {
                    cobra.setDy(20);
                    cobra.setDx(0);
                }
                if (tecla == KeyEvent.VK_RIGHT) {
                    cobra.setDy(0);
                    cobra.setDx(20);
                }
                if (tecla == KeyEvent.VK_LEFT) {
                    cobra.setDy(0);
                    cobra.setDx(-20);
                }
                if (tecla == 'P' || tecla == 'p') {
                    if (t.isRunning()) {
                        msg = "Pausa";
                        repaint();
                        t.stop();
                    } else {
                        t.restart();
                        msg = "";
                    }
                }
                if (tecla == 'r' || tecla == 'R') {
                    inicializa();
                    t.start();
                }
                if (tecla == KeyEvent.VK_SPACE && vida == 0) {
                    t.start();
                }
            }
        });
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        for (int i = tamanho - 1; i > 0; i--) {
            corpo[i].setX(corpo[i - 1].getX());
            corpo[i].setY(corpo[i - 1].getY());
        }
        corpo[0].setX(cobra.getX());
        corpo[0].setY(cobra.getY());
        cobra.mexer();
        if (verificaColisaoFruta(fruta, cobra)) {
            corpo[tamanho++] = new Cobra();
            pontoJ++;
            posicionaFruta();
        }
        if (verificaColisaoPoder(poder, cobra)) {
            if (vida == 1) {
                vida++;
                msg = "vida extra";
                posicionaPoder();
            }
        }
        if (verificaColisaoCorpo()) {
            if (vida == 1) {
                t.stop();
                pontoJ = 0;
                msg = "Game Over";
            } else {
                vida--;
                msg = "";
                cobra.setX(500);
                cobra.setY(400);
                cobra.setDx(-20);
            }
        }
        if (verificaColisaoCenario()) {
            if (vida == 1) {
                t.stop();
                pontoJ = 0;
                msg = "Game Over";
            } else {
                vida--;
                msg = "";
                cobra.setX(500);
                cobra.setY(400);
                cobra.setDx(-20);
            }
        }
        System.out.println(tamanho);
        trocaCenario();
        repaint();
    }

    private void posicionaPoder() {
        boolean ok = false;
        int x, y;
        while (!ok) {
            ok = true;
            x = new Random().nextInt(this.getWidth());
            y = new Random().nextInt(this.getHeight());
            poder = new Poder(x, y);
            if (verificaColisaoPoder(poder, cobra)) {
                ok = false;
            }
            if (verificaColisaoPoder(poder, fruta)) {
                ok = false;
            }
            for (int i = 0; i < tamanho; i++) {
                if (verificaColisaoPoder(poder, corpo[i])) {
                    ok = false;
                }
            }
            for (int i = 0; i < tamanhoCenario; i++) {
                if (verificaColisaoPoder(poder, cenario[i])) {
                    ok = false;
                }
            }
        }
    }

    private void posicionaFruta() {
        boolean ok = false;
        int x, y;
        while (!ok) {
            ok = true;
            x = new Random().nextInt(this.getWidth());
            y = new Random().nextInt(this.getHeight());
            fruta = new Fruta(x, y);
            if (verificaColisaoFruta(fruta, cobra)) {
                ok = false;
            }
            for (int i = 0; i < tamanho; i++) {
                if (verificaColisaoFruta(fruta, corpo[i])) {
                    ok = false;
                }
            }
            for (int i = 0; i < tamanhoCenario; i++) {
                if (verificaColisaoFruta(fruta, cenario[i])) {
                    ok = false;
                }

            }
        }
    }

    private void inicializa() {
        cobra = new Cobra(500, 400);
        cobra.setDx(-20);
        corpo[0] = new Cobra(520, 400);
        corpo[1] = new Cobra(540, 400);
        corpo[2] = new Cobra(560, 400);
        msg = "";
        tamanho = 3;
        cenario1();
        posicionaFruta();
        posicionaPoder();
    }

    private boolean verificaColisaoFruta(Fruta f, Cobra c) {
        if (c.getLimites().intersects(f.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoPoder(Poder p, Cobra c) {
        if (c.getLimites().intersects(p.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoFruta(Fruta f, Cenario c) {
        if (c.getLimites().intersects(f.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoPoder(Poder p, Cenario c) {
        if (c.getLimites().intersects(p.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoPoder(Poder p, Fruta f) {
        if (f.getLimites().intersects(p.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    private boolean verificaColisaoCorpo() {
        for (int i = 0; i < tamanho; i++) {
            if (cobra.getLimites().intersects(corpo[i].getLimites())) {
                return true;
            }
        }
        return false;
    }

    private boolean verificaColisaoCenario() {
        for (int i = 0; i < tamanhoCenario; i++) {
            if (cobra.getLimites().intersects(cenario[i].getLimites())) {
                return true;
            }
        }
        return false;
    }

    private void trocaCenario() {
        if (5 == pontoJ) {
            pontoJ++;
            cobra = new Cobra(500, 400);
            cobra.setDx(-20);
            corpo[0] = new Cobra(520, 400);
            corpo[1] = new Cobra(540, 400);
            corpo[2] = new Cobra(560, 400);
            corpo[3] = new Cobra(580, 400);
            corpo[4] = new Cobra(600, 400);
            corpo[5] = new Cobra(620, 400);
            corpo[6] = new Cobra(640, 400);
            corpo[7] = new Cobra(660, 400);
            tamanho = 8;
            cenario2();
        } else if (10 == pontoJ) {
            pontoJ++;
            cobra = new Cobra(500, 400);
            cobra.setDx(-20);
            corpo[0] = new Cobra(520, 400);
            corpo[1] = new Cobra(540, 400);
            corpo[2] = new Cobra(560, 400);
            corpo[3] = new Cobra(580, 400);
            corpo[4] = new Cobra(600, 400);
            corpo[5] = new Cobra(620, 400);
            corpo[6] = new Cobra(640, 400);
            corpo[7] = new Cobra(660, 400);
            corpo[8] = new Cobra(680, 400);
            corpo[9] = new Cobra(700, 400);
            corpo[10] = new Cobra(720, 400);
            corpo[11] = new Cobra(740, 400);
            corpo[12] = new Cobra(660, 400);
            tamanho = 13;
            cenario3();
        } else if (15 == pontoJ) {
            pontoJ++;
            cobra = new Cobra(500, 400);
            cobra.setDx(-20);
            corpo[0] = new Cobra(520, 400);
            corpo[1] = new Cobra(540, 400);
            corpo[2] = new Cobra(560, 400);
            corpo[3] = new Cobra(580, 400);
            corpo[4] = new Cobra(600, 400);
            corpo[5] = new Cobra(620, 400);
            corpo[6] = new Cobra(640, 400);
            corpo[7] = new Cobra(660, 400);
            corpo[8] = new Cobra(680, 400);
            corpo[9] = new Cobra(700, 400);
            corpo[10] = new Cobra(720, 400);
            corpo[11] = new Cobra(740, 400);
            corpo[12] = new Cobra(660, 400);
            corpo[13] = new Cobra(680, 400);
            corpo[14] = new Cobra(700, 400);
            corpo[15] = new Cobra(720, 400);
            corpo[16] = new Cobra(740, 400);
            corpo[17] = new Cobra(660, 400);
            tamanho = 18;
            cenario4();
        }
    }

    @Override
    public void paint(Graphics g) {
        g.drawImage(fundo, 0, 0, null);
        g.setColor(Color.WHITE);
        g.drawImage(cobra.getImagem(), (int) cobra.getX(), (int) cobra.getY(), this);
        for (int i = 0; i < tamanho; i++) {
            g.drawImage(corpo[i].getImagem(), (int) corpo[i].getX(), (int) corpo[i].getY(), this);
        }
        for (int i = 0; i < tamanhoCenario; i++) {
            g.drawImage(cenario[i].getImagem(), (int) cenario[i].getX(), (int) cenario[i].getY(), this);
        }
        g.drawImage(fruta.getImagem(), (int) fruta.getX(), (int) fruta.getY(), this);
        g.drawImage(poder.getImagem(), (int) poder.getX(), (int) poder.getY(), this);
        g.setFont(new Font("Arial", 0, 20));
        g.drawString(pontoJ + " ", this.getWidth() / 2, 50);
        Font f = new Font("Arial", Font.BOLD, 20);
        g.setFont(f);
        FontMetrics fm = g.getFontMetrics(f);
        Rectangle2D rect = fm.getStringBounds(msg, g);
        int textWidth = (int) (rect.getWidth());
        int panelWidth = this.getWidth();
        int x = (panelWidth - textWidth) / 2;
        g.drawString(msg, x, 3 * (this.getHeight() / 4));
    }

    private void cenario1() {
        // limites
        cenario[0] = new Cenario(0, 0, 25, 700);
        cenario[1] = new Cenario(0, 0, 1000, 25);
        cenario[2] = new Cenario(0, 680, 1000, 25);
        cenario[3] = new Cenario(970, 0, 25, 700);
        cenario[4] = new Cenario(200, 100, 25, 500);
        cenario[5] = new Cenario(770, 100, 25, 500);
        tamanhoCenario = 6;
    }

    private void cenario2() {
        // limites
        cenario[0] = new Cenario(0, 0, 25, 700);
        cenario[1] = new Cenario(0, 0, 1000, 25);
        cenario[2] = new Cenario(0, 680, 1000, 25);
        cenario[3] = new Cenario(970, 0, 25, 700);
        // baras do centro
        cenario[4] = new Cenario(250, 180, 500, 25);
        cenario[5] = new Cenario(250, 470, 500, 25);
        tamanhoCenario = 6;
    }

    private void cenario3() {
        // limites
        cenario[0] = new Cenario(0, 0, 25, 700);
        cenario[1] = new Cenario(0, 0, 1000, 25);
        cenario[2] = new Cenario(0, 680, 1000, 25);
        cenario[3] = new Cenario(970, 0, 25, 700);
        // baras do centro
        // x, y, larg, alt
        cenario[4] = new Cenario(270, 100, 450, 25);
        cenario[5] = new Cenario(270, 575, 450, 25);
        cenario[6] = new Cenario(200, 100, 25, 500);
        cenario[7] = new Cenario(770, 100, 25, 500);
        tamanhoCenario = 8;
    }

    private void cenario4() {
        // limites
        cenario[0] = new Cenario(0, 0, 25, 700);
        cenario[1] = new Cenario(0, 0, 1000, 25);
        cenario[2] = new Cenario(0, 680, 1000, 25);
        cenario[3] = new Cenario(970, 0, 25, 700);
        // baras do centro
        cenario[4] = new Cenario(200, 100, 150, 25);
        cenario[5] = new Cenario(200, 575, 150, 25);
        cenario[6] = new Cenario(200, 100, 25, 150);
        cenario[7] = new Cenario(200, 450, 25, 150);
        cenario[8] = new Cenario(770, 100, 25, 150);
        cenario[9] = new Cenario(770, 450, 25, 150);
        cenario[10] = new Cenario(640, 575, 150, 25);
        cenario[11] = new Cenario(640, 100, 150, 25);
        cenario[12] = new Cenario(150, 100, 25, 500);
        cenario[13] = new Cenario(820, 100, 25, 500);

        tamanhoCenario = 14;
    }
}

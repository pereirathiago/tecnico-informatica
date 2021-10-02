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
 * @author Thiago
 */
public class Campo extends JPanel implements ActionListener {

    Bola bola;
    Raquete raquetePc;
    Raquete raqueteJ;
    Timer t;
    Image fundo;
    int pontoJ = 0, pontoPc = 0;
    int jogador2 = 0;
    String msg = "";
    double proxBolaDy;

    public Campo(int largura, final int altura) {
        setFocusable(true);
        setDoubleBuffered(true);
        setSize(largura, altura);
        fundo = new ImageIcon(this.getClass().getResource("/imagens/campo.jpg")).getImage().getScaledInstance(largura, altura, 1);
        inicializa();
        t = new Timer(10, this);
        t.start();
        msg = "Aperte:  "
                + "  F1 - jogar contra o pc  "
                + "  F2 - 2 jogadores  "
                + "  P - pausa  "
                + "  R - reinicia";
        addKeyListener(new KeyAdapter() {
            public void keyPressed(KeyEvent e) {
                int tecla = e.getKeyCode();
                if (tecla == KeyEvent.VK_UP) {
                    raqueteJ.setDy(-6);
                    System.out.println(bola.getDx());
                }
                if (tecla == KeyEvent.VK_DOWN) {
                    raqueteJ.setDy(6);
                    System.out.println(bola.getDx());
                }
                if (jogador2 == 1) {
                    if (tecla == 'w' || tecla == 'W') {
                        raquetePc.setDy(-6);
                    }
                    if (tecla == 's' || tecla == 'S') {
                        raquetePc.setDy(6);
                    }
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
                if (tecla == KeyEvent.VK_SPACE && pontoJ < 5 && pontoPc < 5) {
                    msg = "";
                    t.start();
                }
                if (tecla == KeyEvent.VK_F1) {
                    jogador2 = 0;
                    repaint();
                    msg = "Habilitado jogar contrar pc - aperte R";
                    t.stop();
                }
                if (tecla == KeyEvent.VK_F2) {
                    jogador2 = 1;
                    repaint();
                    msg = "Habilitado jogador 2 - aperte R";
                    t.stop();
                }
            }

            public void keyReleased(KeyEvent e) {
                raqueteJ.setDy(0);
                raquetePc.setDy(0);
            }
        });
    }

    @Override
    public void actionPerformed(ActionEvent e) {
        bola.mexer();
        raquetePc.mexer();
        raqueteJ.mexer();
        if (raqueteJ.getY() > this.getHeight() - raqueteJ.getAltura()) {
            raqueteJ.setY(this.getHeight() - raqueteJ.getAltura());
        }
        if (raqueteJ.getY() < 0) {
            raqueteJ.setY(0);
        }
        if (verificaColisao(bola, raqueteJ)) {
            bola.setDx(-bola.getDx());
            proxBolaDy = new Random().nextDouble() * Math.signum(bola.getDy()) * 5;
            while(proxBolaDy == 0) {
                proxBolaDy = new Random().nextDouble() * Math.signum(bola.getDy()) * 5;
            }
            bola.setDy(proxBolaDy);
        }
        if (verificaColisao(bola, raquetePc)) {
            bola.setDx(-bola.getDx());
            proxBolaDy = new Random().nextDouble() * Math.signum(bola.getDy()) * 5;
            while(proxBolaDy == 0) {
                proxBolaDy = new Random().nextDouble() * Math.signum(bola.getDy()) * 5;
            }
            bola.setDy(proxBolaDy);
        }
        if (bola.getY() < 10 || bola.getY() > this.getHeight() - bola.getAltura()) {
            bola.setDy(-bola.getDy());
        }
        if (jogador2 == 0) {
            mexerPc();
        } else {
            if (raquetePc.getY() > this.getHeight() - raquetePc.getAltura()) {
                raquetePc.setY(this.getHeight() - raquetePc.getAltura());
            }
            if (raquetePc.getY() < 0) {
                raquetePc.setY(0);
            }
            if (verificaColisao(bola, raquetePc)) {
                bola.setDx(bola.getDx());
                bola.setDy(new Random().nextDouble() * Math.signum(bola.getDy()) * 5);
            }
        }
        verificaPonto();
        repaint();
    }

    private void inicializa() {
        raquetePc = new Raquete(10, this.getHeight() / 2);
        raqueteJ = new Raquete(this.getWidth() - 50, this.getHeight() / 2);
        bola = new Bola(raquetePc.getLargura() + 10, this.getHeight() / 2);
        pontoJ = 0;
        pontoPc = 0;
        msg = "";
        aumentarVeolcidade();
    }

    private void verificaPonto() {
        if (bola.getX() < 0) {
            bola.setX(raqueteJ.getX() - raqueteJ.getLargura());
            bola.setY(raqueteJ.getY());
            bola.setDy(new Random().nextDouble() * Math.signum(bola.getDy()) * 5);
            bola.setDx(-10);
            pontoJ++;
            t.stop();
            msg = "Ponto para Jogador - Espaço para continuar";
        }
        if (bola.getX() > this.getWidth()) {
            bola.setX(raquetePc.getX() + raquetePc.getLargura());
            bola.setY(raquetePc.getY());
            bola.setDy(new Random().nextDouble() * Math.signum(bola.getDy()) * 5);
            bola.setDx(10);
            pontoPc++;
            t.stop();
            msg = "Ponto para PC - Espaço para continuar";
        }
        if (pontoJ > 4) {
            msg = "Jogador Ganhou! 'R' - Reinicia o Jogo";
            t.stop();
            repaint();
        }
        if (pontoPc > 4) {
            msg = "Pc Ganhou! 'R' - Reinicia o Jogo";
            t.stop();
            repaint();
        }
    }

    private void mexerPc() {
        if (bola.getX() < this.getWidth() / 2 && bola.getDx() < 0) {
            if (Math.signum((int) (bola.getY() - raquetePc.getY())) > 0) {
                if (bola.getY() - raquetePc.getY() > raquetePc.getAltura()) {
                    raquetePc.setDy(11 * Math.signum((int) (bola.getY() - raquetePc.getY())));
                }
            } else {
                raquetePc.setDy(11 * Math.signum((int) (bola.getY() - raquetePc.getY())));
            }

        } else {
            raquetePc.setDy(0);
        }
    }

    private boolean verificaColisao(Bola b, Raquete r) {
        if (r.getLimites().intersects(b.getLimites())) {
            return true;
        } else {
            return false;
        }
    }

    public void aumentarVeolcidade() {
        int delay = 15000;
        ActionListener taskPerformer = new ActionListener() {
            public void actionPerformed(ActionEvent evt) {
                double velocidade = bola.getDx();
                if(velocidade < 30 && velocidade != -30) {
                    if(velocidade > 0) 
                        bola.setDx(velocidade + 3);
                    else
                        bola.setDx(velocidade - 3);
                }
            }
        };
        new Timer(delay, taskPerformer).start();
    }

    @Override
    public void paint(Graphics g) {
        g.drawImage(fundo, 0, 0, null);
        g.setColor(Color.WHITE);
        g.drawLine(this.getWidth() / 2, 0, this.getWidth() / 2, this.getHeight());
        g.drawImage(bola.getImagem(), (int) bola.getX(), (int) bola.getY(), this);
        if (jogador2 == 0) {
            g.drawImage(raquetePc.getImagemPc(), (int) raquetePc.getX(), (int) raquetePc.getY(), this);
        } else {
            g.drawImage(raquetePc.getImagemJ2(), (int) raquetePc.getX(), (int) raquetePc.getY(), this);
        }
        g.drawImage(raqueteJ.getImagem(), (int) raqueteJ.getX(), (int) raqueteJ.getY(), this);
        g.setFont(new Font("Arial", 0, 50));
        g.drawString(pontoPc + " ", this.getWidth() / 4, 50);
        g.drawString(pontoJ + " ", 3 * (this.getWidth() / 4), 50);
        Font f = new Font("Arial", Font.BOLD, 20);
        g.setFont(f);
        FontMetrics fm = g.getFontMetrics(f);
        Rectangle2D rect = fm.getStringBounds(msg, g);
        int textWidth = (int) (rect.getWidth());
        int panelWidth = this.getWidth();
        int x = (panelWidth - textWidth) / 2;
        g.drawString(msg, x, 3 * (this.getHeight() / 4));
    }
}

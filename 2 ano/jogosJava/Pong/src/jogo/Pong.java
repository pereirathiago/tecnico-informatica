/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package jogo;

import javax.swing.JFrame;

/**
 *
 * @author Thiago
 */
public class Pong extends JFrame{

    public Pong() {
        setTitle("Pong brabo");
        setSize(1200, 733);
        add(new Campo(1200, 733));
        setResizable(false);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
    }

    public static void main(String[] args) {
        new Pong();
    }
}

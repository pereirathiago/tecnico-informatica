
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Toolkit;
import javax.swing.JFrame;

/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
/**
 *
 * @author Thiago
 */
public class Tela extends JFrame {

    public Tela() {
        setBackground(Color.black);
        setForeground(Color.white);
        setUndecorated(true);
        Toolkit toolkit = java.awt.Toolkit.getDefaultToolkit();
        Dimension scrSize = toolkit.getScreenSize();
        setSize(scrSize.width, scrSize.height);
        add(new Painel(scrSize.width, scrSize.height, this));
        setResizable(false);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setVisible(true);
    }

    public static void main(String[] args) {
        new Tela();
    }

}

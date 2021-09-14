/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicio2;

/**
 *
 * @author fcsa0719
 */
public class Fibonacci {
    private int numAtual = 1;
    private int numAnterior = 0;
    private int num;

    public int getNumAtual() {
        return numAtual;
    }

    public void setNumAtual(int numAtual) {
        this.numAtual = numAtual;
    }

    public int getNumAnterior() {
        return numAnterior;
    }
    
    public void setNumAnterior(int numAnterior) {
        this.numAnterior = numAnterior;
    }

    public int getNum() {
        return num;
    }

    public void setNum(int num) {
        this.num = num;
    }
    public boolean estaFibonacci() {
        do {            
            if(getNum() == getNumAtual())
                return true;
            else {
                if(getNum() > getNumAtual()) 
                    setNumAtual(getNumAnterior() + getNumAtual());
                else 
                    return false;
            }
        } while (getNum() != getNumAtual());
        return false;
    }
}

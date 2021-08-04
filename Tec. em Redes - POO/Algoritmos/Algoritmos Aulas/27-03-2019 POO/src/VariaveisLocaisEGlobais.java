/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */
public class VariaveisLocaisEGlobais {
    
    public static int c=2; //Variável global do tipo inteiro
    
    public static void main(String[]args){
        int a=1, b=2; //Variéveis locais do tipo inteiro
        System.out.println("Soma: " + (a+b+c));
    }
}

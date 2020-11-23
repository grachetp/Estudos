/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */
public class PosPreIncremento {
    public static void main(String[] args) {
        int a, b=1;
        
        
        //"a" recebe o valor de "b" e depois "b" é incrementada
        a=b++; //Incremento
        
        System.out.println("Depois do primeiro incremento: ");
        System.out.println("a: " + a);
        System.out.println("b: " + b);
        
        //"b" é increntada e depois "a" recebe o valor de "b"
        a=++b;
        
        System.out.println("Depois do segundo incremento: ");
        System.out.println("a: " + a);
        System.out.println("b: " + b);
    }
}

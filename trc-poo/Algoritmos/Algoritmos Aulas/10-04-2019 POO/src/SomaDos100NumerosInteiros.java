/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */
public class SomaDos100NumerosInteiros {
    public static void main(String[] args) {
        int n, soma = 0;
        for(n=1; n<=100; n++){
            soma = soma + n;
        }
        System.out.println("Soma: " + soma);
    }
}

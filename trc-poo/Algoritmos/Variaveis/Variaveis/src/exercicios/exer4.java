/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package exercicios;
import java.util.Scanner;
/**
 *
 * @author grachet
 */
public class exer4 {
    public static void main(String[]args){
        float n;
        Scanner read = new Scanner(System.in);
        System.out.print("Digite um número real: ");
        n = read.nextFloat();
        System.out.println("O quadrado de " + n + " é " + (n*n));
    }
}

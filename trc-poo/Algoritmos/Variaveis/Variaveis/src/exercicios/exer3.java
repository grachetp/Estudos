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
public class exer3 {
    public static void main(String[]args){
        int n1, n2, n3;
        Scanner read = new Scanner(System.in);
        System.out.print("Digite um número: ");
        n1 = read.nextInt();
        System.out.print("Digite outro número: ");
        n2 = read.nextInt();
        System.out.print("Digite outro número: ");
        n3 = read.nextInt();
        System.out.println("A soma dos números é: " + (n1+n2+n3));
    }
}

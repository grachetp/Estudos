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
public class exer2 {
    public static void main(String[]args){
        float n;
        Scanner read = new Scanner(System.in);
        System.out.print("Digite um numero decimal: ");
        n = read.nextFloat();
        System.out.println("O número digitado foi: " + n);
    }
}

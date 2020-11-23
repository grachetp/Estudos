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
public class exer6 {
    public static void main(String[]args){
        Scanner read = new Scanner(System.in);
        float c, f;
        System.out.print("Digite um temperatura em °C: ");
        c = read.nextFloat();
        f = (float)(c * (9.0/5.0) + 32);
        System.out.println("°C: " + c);
        System.out.println("°F: " + f);
    }
}

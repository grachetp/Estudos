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
public class exer8 {
    public static void main(String[]args){
        int k; 
        float c;
        Scanner read = new Scanner(System.in);
        
        System.out.print("Digite a temperatura em K: ");
        k = read.nextInt();
        
        c = (float)(k - 273.15);
        
        System.out.println(k + "K em °C é: " + c);
    }
}

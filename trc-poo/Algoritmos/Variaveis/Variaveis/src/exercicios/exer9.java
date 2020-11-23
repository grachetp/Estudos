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
public class exer9 {
    public static void main(String[]args){
        float c, k;
        Scanner read = new Scanner(System.in);
        
        System.out.print("Temperatuta em °C: ");
        c = read.nextFloat();
        
        k = (float)(c + 273.15);
        
        System.out.println(c + "°C em K é: " + k);
    }
}

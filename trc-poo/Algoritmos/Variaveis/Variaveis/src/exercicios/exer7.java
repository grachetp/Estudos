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
public class exer7 {
    public static void main(String[]args){
        float f, c;
        
        Scanner read = new Scanner(System.in);
        
        System.out.print("°F: ");
        f = read.nextFloat();
        
        c = (float)(5.0*(f-32.0)/9.0);
        System.out.println("°C: " + c);
        System.out.println("°F: " + f);
        
    }
}

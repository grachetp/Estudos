
import java.util.Scanner;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */
public class AnoBissexto {
    public static void main(String[] args) {
       
        
        Scanner scan = new Scanner(System.in);
        System.out.println("digite o ano: ");
        int ano = scan.nextInt();
        
        if((ano%400==0) || (ano%4==0) && !(ano%100==0)){
            System.out.println("ano é bissexto");
        }else{
            System.out.println("ano não é bissexto");
        }
    }
    
}

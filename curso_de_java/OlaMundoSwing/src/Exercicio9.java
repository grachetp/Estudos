/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */
import java.util.Scanner;
public class Exercicio9 {
    public static void main(String[] args) {
        Scanner read = new Scanner(System.in);
        System.out.print("Digite um número inteiro: ");
        int n = read.nextInt();
        if(n > 0){
            System.out.println((n - (n+n)));
        } else if(n == 0){
            System.out.println(n);
        } 
        else{
            System.out.println((n + (-n-n)));
        }
    }
}

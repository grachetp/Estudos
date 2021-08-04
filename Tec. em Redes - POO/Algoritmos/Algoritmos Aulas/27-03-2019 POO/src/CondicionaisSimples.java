/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
import java.util.Scanner;
/**
 *
 * @author grachet
 */
public class CondicionaisSimples {
    public static void main(String[]args){
        Scanner read = new Scanner(System.in);
        int n;
        System.out.print("Digite um número inteiro: ");
        n = read.nextInt();
        if(n>0)
            System.out.println(n + " é POSITIVO");
        else if(n<0)
            System.out.println(n + " é NEGATIVO");
        else
            System.out.println(n + " é NEUTRO");
    }
}

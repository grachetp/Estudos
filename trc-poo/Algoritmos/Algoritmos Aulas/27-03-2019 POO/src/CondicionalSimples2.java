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
public class CondicionalSimples2 {
    public static void main(String[]args){
        Scanner read = new Scanner(System.in);
        int x, y;
        System.out.print("Digite um número: ");
        x = read.nextInt();
        System.out.print("Digite outro número: ");
        y = read.nextInt();
        if(x>y)
            System.out.println(x + " é maior que " + y);
        else if(x<y)
            System.out.println(y + " é maior que " + x);
        else
            System.out.println(x + " e " + y + " são valores iguais!");
    }
}

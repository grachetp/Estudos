/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author grachet
 */

//Importações
import java.util.Scanner;

public class Condicional {
    public static void main(String[]args){
        
        //Declaração de Variáveis
        int x;
        
        //Declaração de métodos
        Scanner read = new Scanner(System.in);
        
        //Entrada de Dados
        System.out.print("Digite um número: ");
        x = read.nextInt();
        
        //Condicional
        if(x%2 == 0){
            System.out.println(x + " é um número par!");
        } else{
            System.out.println(x + " é um número ímpar!");
        }
    }
}

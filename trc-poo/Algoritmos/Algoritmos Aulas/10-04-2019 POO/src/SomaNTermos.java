/*

Soma n termos, se for igual a zero quebra e responde

*/

import java.util.Scanner;

public class SomaNTermos {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        
        int soma = 0;
        int n;
        System.out.print("Digite um numero: ");
        n = scan.nextInt();
        
        while (n != 0) {            
            soma = soma + n;
            System.out.print("Escreva outro número: ");
            n = scan.nextInt();
            if (n == 0) {
                break;
            }
        }
        System.out.println("O resultado da soma dos números é: " + soma);
    }
}

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
public class Exercicio8 {
    public static void main(String[] args) {
        float m, alt, imc;
        Scanner read = new Scanner(System.in);
        System.out.print("Digite sua altura(m): ");
        alt = read.nextFloat();
        System.out.print("Digite sua massa(kg): ");
        m = read.nextFloat();
        imc = (float)(m/alt*alt);
        System.out.print("Sua condição está: ");
        if(imc < 18.5){
            System.out.print("Abaixo do peso");
        } else if((imc >= 18.6) || (imc <= 24.9)){
            System.out.print("Saudável");
        } else if((imc >= 25) | (imc <= 29.9)){
            System.out.print("Sobrepeso");
        } else if((imc >= 30) || (imc <= 34.9)){
            System.out.print("Obesidade Grau I");
        } else if((imc >= 35) || (imc <= 39.9)){
            System.out.print("Obesidade Grau II(Severa)");
        } else{
            System.out.print("Obesidade Grau III(Mórbida)");
        }
    }
}

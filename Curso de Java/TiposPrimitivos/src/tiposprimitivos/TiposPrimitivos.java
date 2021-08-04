/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tiposprimitivos;

import java.util.Scanner;

/**
 *
 * @author grachet
 */
public class TiposPrimitivos {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        Scanner scan = new Scanner(System.in);
        System.out.print("Digite o nome do aluno: ");
        String nome = scan.nextLine();
        System.out.print("Digite a nota de " + nome + ": ");
        float nota = scan.nextFloat();
        System.out.format("A nota de %s é %.2f", nome, nota);
    }
    
}

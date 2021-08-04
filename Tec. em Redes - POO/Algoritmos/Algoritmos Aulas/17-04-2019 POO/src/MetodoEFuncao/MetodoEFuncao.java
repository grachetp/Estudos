package MetodoEFuncao;

import java.util.Scanner;

public class MetodoEFuncao {

    //Variáveis Globais
    public static int x,y;
    
    //Método soma(): calcular a soma de dois valores (a+b)
    public static int soma(int a, int b){
        return a+b;
    }
    
    public static void mensagem(){
        System.out.println("O resultado da soma é: " + soma(x, y));
    }
    
    public static void main(String[] args) {
        //Método Scanner para leitura de dados
        Scanner scan = new Scanner(System.in);
        
        //Leitura de valores para usar na função soma
        System.out.print("Digite um número inteiro: ");
        x = scan.nextInt();
        
        System.out.print("Digite outro número inteiro: ");
        y = scan.nextInt();
        
        //Método Resultado
        mensagem();
    }
}

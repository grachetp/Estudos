import java.util.Scanner;
public class questão9 {
    public static void main(String[]args){
        Scanner S = new Scanner(System.in);
        
        System.out.println("Ler um número inteiro e mostrar o seu inverso");
        System.out.println("");
        System.out.println("Informe um numero positivo ou negativo");
        int n = S.nextInt();
         
        int inver = n*(-1);
        
        System.out.println("O inverso do número "+n+" é: "+inver);
 
            
        
    }
}

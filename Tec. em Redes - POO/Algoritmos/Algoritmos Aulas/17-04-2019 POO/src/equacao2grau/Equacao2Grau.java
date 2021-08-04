package equacao2grau;

import java.util.Scanner;

/**
 *
 * @author grachet
 */
public class Equacao2Grau {
    
    public static float a, b, c;
    
    public static void calculaRaizes(float a, float b, float c){
        if(a != 0){ //Se "a" é diferente de 0.
            
            float d = ((b*b)-4*a*c); //Calculo de delta
            System.out.println("");
            System.out.println("Delta: " + d);        
            
            if(d>=0){
                System.out.println("");
                float x1 = (float) (-b + Math.sqrt(d)/2*a);
                float x2 = (float) (-b - Math.sqrt(d)/2*a);
                
                System.out.println("Raizes");
                System.out.println("x1: " + x1);
                System.out.println("x2: " + x2);
                
            }else{
                System.out.println("Não existe raízes reais para delta negativo");
            }
            System.out.println("");
        }
    }
    
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        
        do{  //Faça isto 
            System.out.println("Cálculo das raízes de uma Equação do 2° Grau");
            
            System.out.print("Digite o valor de a: ");
            a = scan.nextFloat();
            
            System.out.print("Digite o valor de b: ");
            b = scan.nextFloat();
            
            System.out.print("Digite o valor de c: ");
            c = scan.nextFloat();
            
            calculaRaizes(a, b, c);
            
        }while(b != 0 || a != 0 || c != 0); //enquanto
    }
    
}

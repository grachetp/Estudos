import java.util.Scanner;
public class questao10 {
    
    public static void main (String[]args ){
       
        Scanner E = new Scanner(System.in);
        System.out.println("Converter de °C para °F");
        System.out.println("");
        
        
        System.out.println("Informe uma temperatura em °C: ");
        float C = E.nextFloat();
        
        float  F = (float) (C*1.8+32);
      
        System.out.println("A temperatura em °F é: "+F);
    }
    
}

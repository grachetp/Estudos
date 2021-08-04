import java.util.Scanner;

public class questão11 {
  public static void main(String[]args){
      Scanner S = new Scanner(System.in);
      System.out.println("Calculando media anual ");
      System.out.println("");
      System.out.println("Informe a primeira nota:");
      float n1 = S.nextFloat();
      System.out.println("");
      System.out.println("Informe a segunda nota:");
      float n2 = S.nextFloat();
      System.out.println("");
      System.out.println("Informe a terceira nota");
      float n3 = S.nextFloat();
      System.out.println("");
      float media =(n1+n2+n3)/3;
      System.out.println("sua media é: "+media);
      
      
      if(media >= 6){
          System.out.println("Você está aprovado. Não fez mais que a sua obrigação!");
          
      }else if(media < 4){
          System.out.println("Você está reprovado, estude mais!");
      }else if(media >= 4 && media <6){
          System.out.println("Você está de Exame Final. Estude!!!");
      }
  
             
      
  }  
}

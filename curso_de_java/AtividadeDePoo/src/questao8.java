import java.util.Scanner;
public class questao8 {
    
    public static void main(String[]args){
        Scanner l = new Scanner (System.in);
        System.out.println("Calculando o IMC");
        System.out.println("");
        
        System.out.println("Informe o seu nome: ");
        String nome = l.next();
        
        System.out.println("Informe seu 'peso' em Kg "+nome+":");
        float peso = l.nextFloat();
        
        System.out.println("Informe a sua altura em metros "+nome+":");
        float altura = l.nextFloat();
        
        float IMC = peso/(altura*altura);
        System.out.println("O seu IMC é: "+IMC);
        
       if (IMC < 18.6){
           System.out.println("Você está abaixo do peso, precisa comer mais :) ");
       } else if (IMC >= 18.6 && IMC <= 24.9){
           System.out.println("Você está saudável, Parabéns <3n ");
           
       }else if (IMC >= 25 && IMC <= 29.9){
           System.out.println("Você está sobrepeso, cuidado! ");
          
       }else if (IMC >= 30 && IMC <= 34.9){
        System.out.println("Você está com obesidade grau I, cuidado!");
           
        }else if (IMC >= 35 && IMC <= 39.9){
            System.out.println("Você está com obesidade grau II, tome cuidado!");
        }else if (IMC >= 40){
            System.out.println("Você está com obesidade grau III, tome cuidade e se cuide!!!");
            
    }    
                   
      } 
    } 
       

    


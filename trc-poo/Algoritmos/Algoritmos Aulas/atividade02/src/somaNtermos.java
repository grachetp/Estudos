import java.util.Scanner;
public class somaNtermos {
    public static void main(String[]args){
        int valor;
        Scanner n = new Scanner(System.in);
        System.out.println("digite um numero inteiro");
        valor = n.nextInt();
        int soma;
        soma = valor;
        System.out.println("digite outro valor");
        valor = n.nextInt();
        soma = soma+valor;
        while (valor !=0){
            System.out.println(" digite mais um valor");
            valor = n.nextInt();
            soma = soma+valor;
            System.out.println("soma:"+ soma);
                       
        }
        
                
    }
}

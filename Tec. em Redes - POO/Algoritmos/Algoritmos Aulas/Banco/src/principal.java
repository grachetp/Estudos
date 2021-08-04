import java.util.Scanner;
public class principal {
    public static void main(String[] args) {
        Scanner e = new Scanner(System.in);
        cliente d = new cliente();
        conta   i = new conta();
        String alter;
        System.out.println("Cadastro de conta");
        System.out.println("");
        System.out.println("Informe seu nome: ");
        d.nome = e.next();
        System.out.println("Informe seu CPF: ");
        d.cpf = e.next();
        System.out.println("");
        
        System.out.println("Informe o número da sua conta: ");
        i.numero = e.nextInt();
        System.out.println("Agora informe a sua senha: ");
        i.senha = e.nextInt();
        System.out.println("Deseja fazer um depósito inicial?[s/n] ");
        alter = e.next();
        if("s".equals(alter) || "S".equals(alter)){
            System.out.println("Quanto deseja depositar? ");
            i.saldo = e.nextFloat();
            
        }
        
      
        
      
    }   
}

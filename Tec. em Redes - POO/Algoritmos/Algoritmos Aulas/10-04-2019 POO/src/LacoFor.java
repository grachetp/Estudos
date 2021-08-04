public class LacoFor {
    public static void main(String[] args) {
        int n;
        
        for(n=1; n<=100; n++){ //Incrementa no laço for
            System.out.println(n); //escreve n
            if(n % 2 == 0)
                System.out.println(n);
        }
    }
}

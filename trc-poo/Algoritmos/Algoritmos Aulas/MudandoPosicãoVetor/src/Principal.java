
public class Principal {
    public static void main(String[] args) {
        Pessoa[] vetor = new Pessoa[100];
        
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa();
        Pessoa p3 = new Pessoa();
        Pessoa p4 = new Pessoa();
        Pessoa p5 = new Pessoa();
        Pessoa p6 = new Pessoa();
        
        p1.nome = "Edina";
        p1.idade = 18;
        
        p2.nome = "Nicolas";
        p2.idade = 17;
        
        p3.nome = "Sarah";
        p3.idade = 16;
        
        p4.nome = "Marina";
        p4.idade = 15;
        
        p5.nome = "Intrometido";
        p5.idade = 19;
        
        p6.nome = "Grachet";
        p6.idade = 12;
        
        vetor[0] = p1;
        vetor[1] = p2;
        vetor[2] = p3;
        vetor[3] = p4;
        vetor[4] = p5;
        vetor[5] = p6;
        
        for(int i=0; i<6; i++){
            System.out.println("Nome: "+vetor[i].nome+ "---idade"+vetor[i].idade );
        }
        //reetirando algo do vetor 
        for(int i = 4; i <6; i++){
            vetor[i]= vetor[i+1];
            if (vetor[i] == vetor[4]){
                vetor[4]= p6;
                p5.nome = p6.nome;
                p5.idade = p6.idade;
            }
        }
        System.out.println("--------------------");
        for(int i = 0; i <5; i++){
            System.out.println("Nome: "+vetor[i].nome+ "---idade"+vetor[i].idade );
        }
        
        //trocando posições 3º com 5º 
        vetor [2] = p5;
        vetor [4] = p3; 
        System.out.println("--------------------");
        for(int i = 0; i <=4; i++){
            System.out.println("Nome: "+vetor[i].nome+ "---idade"+vetor[i].idade );
        }
    }
}
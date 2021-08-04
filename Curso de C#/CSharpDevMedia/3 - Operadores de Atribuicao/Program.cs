using System;

namespace _3___Operadores_de_Atribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Pré-Incremento:\n");

            //int x = 0;
            //Console.WriteLine("x = " + x);

            //Console.WriteLine("\n++x +20 = \n");
            //Console.WriteLine(++x + 20 + "\n");

            //Console.WriteLine("\nPós-Incremento:\n");
            //x = 0;

            //Console.WriteLine("\nx++ +20 = \n");
            //Console.WriteLine(x++ + 20 + "\n");


            //Console.WriteLine("\nPré-Decremento:\n");
            //x = 0;

            //Console.WriteLine("x = " + x);

            //Console.WriteLine("\n--x +20 = \n");
            //Console.WriteLine(--x + 20 + "\n");

            //Console.WriteLine("\nPós-Decremento:\n");
            //x = 0;

            //Console.WriteLine("\nx-- +20 = \n");
            //Console.WriteLine(x-- + 20 + "\n");

            //Console.ReadKey();

            ////int a = 5, b = 10, c = 15, d = 20; // declaramos quatro variáveis do tipo int
            ////Console.WriteLine(a + d); // operação de soma
            ////Console.WriteLine(c - a); // operação de subtração
            ////Console.WriteLine(b * c); // operação de multiplicação
            ////Console.WriteLine(d / b); // operação de divisão
            ////Console.WriteLine(c % b); // operação de módulo (resto de divisão)
            ////Console.ReadKey();


            //int a = 10, b = 25, c = 50, d = 100; // declaramos quatro variáveis de tipo int

            //Console.WriteLine(a == d); // avaliamos a igualdade entre a e d
            //Console.WriteLine(b != c);  // avaliamos a desigualdade entre b e c
            //Console.WriteLine(a > b); // avaliamos se a é maior que b
            //Console.WriteLine(c < d);  // avaliamos se c é menor que d
            //Console.WriteLine(c >= a); // avaliamos se c é maior ou igual que a
            //Console.WriteLine(d <= b); // avaliamos se d é menor ou igual que b

            //Console.ReadKey();

            //int x1 = 5, y = 10; // declaradas duas variáveis de tipo int

            //Console.WriteLine(x1 < y ? "sim" : "não"); // expressão x < y é avaliada
            //                                          // se for verdadeira exibe "sim"
            //                                          // se não for verdadeira exibe "não"
            //Console.ReadKey();

            //int numero_1 = 17;
            //int numero_2 = 2;
            //var resultado = (float)numero_1/numero_2;

            //Console.WriteLine(resultado == 8.5);

            //string mascote_nome = "Felix";
            //int mascote_idade = mascote_nome.Length;

            int a = 10, b = 20, c = 30, d = 40;

            Console.WriteLine(c<d);
            
            Console.WriteLine(a>5 || (a>d));
            Console.WriteLine(c>a*2&&b==20);
            Console.WriteLine(b>a || b>c);
            Console.WriteLine(a+c == d);
        }
    }
}

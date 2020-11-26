using System;

namespace Atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Altura = 1.81f;
            pessoa.Nome = "Pedro Grachet";
            pessoa.DataNascimento = DateTime.Parse("17/04/2001");


            pessoa.ImprimirDados();

            Console.WriteLine($"Você tem {pessoa.CalcularIdade()} anos!");

            Console.ReadKey();
        }
    }
}

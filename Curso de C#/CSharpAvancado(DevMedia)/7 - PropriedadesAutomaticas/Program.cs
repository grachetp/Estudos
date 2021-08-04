
using System;

namespace _7___PropriedadesAutomaticas
{
    public class Funcionario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public Funcionario()
        {
            Codigo = 0;
            Nome = "Sem Nome";
            Salario = 0;
        }
        public Funcionario(int codigo, string nome, double salario)
        {
            Codigo = codigo;
            Nome = nome;
            Salario = salario;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario(
            123,
            "Pedro Grachet",
            2400.00);

            Console.ReadLine();
        }
    }
}

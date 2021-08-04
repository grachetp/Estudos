using System;
using System.Collections.Generic;

namespace _8___ObjectsInitializers
{
    public class Filme
    {
        public string Nome;
        public int Ano;
    }
    public class Ator
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public List<Filme> Filmes { get; set; }
        //public Ator(int codigo, string nome, string filme)
        //{
        //    Codigo = codigo;
        //    Nome = nome;
        //    Filme = filme;
        //}
        //public Ator(string nome)
        //{
        //    Nome = nome;
        //}
        //public Ator(int codigo)
        //{
        //    Codigo = codigo;
        //}
        //public Ator()
        //{

        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ator a = new Ator()
            {
                Codigo = 10,
                Filmes = new List<Filme>() { 
                    new Filme() { Nome = "Gambito da Rainha" , Ano = 2019},
                    new Filme() { Nome = "Rainha do Sul", Ano = 2020},
                    new Filme() { Nome = "Hunter x Hunter", Ano = 2011}
                },
                Nome = "Michael"
            };


            Console.WriteLine(a.Codigo);
            Console.WriteLine(a.Nome);
            foreach (Filme item in a.Filmes)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}

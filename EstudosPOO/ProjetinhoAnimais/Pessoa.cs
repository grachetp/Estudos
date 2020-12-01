using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetinhoAnimais
{
    public class Pessoa : Mamifero
    {
        public void Acordar()
        {
            Console.WriteLine("Acordar!");
        }

        public void Dormir()
        {
            Console.WriteLine("Dormir");
        }

        public abstract void Comer()
        {

        }
        public void Comer()
        {

        }
    }
}

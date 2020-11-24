using System;
using System.Collections.Generic;
using System.Text;

namespace TestesUnitariosMOQ
{
    class Program
    {
        public static void main(string[] args)
        {
            Carro c1 = new Carro();
            Console.WriteLine(c1);
        }

        public interface Veiculo
        {
            void ligar();
            void desligar();
            void info();
        }

        public interface Combate
        {
            void Disparar();
        }

        class Carro
        {
            public Carro()
            {
                Console.WriteLine("Criei o Carro!");
            }
        }

    }
}

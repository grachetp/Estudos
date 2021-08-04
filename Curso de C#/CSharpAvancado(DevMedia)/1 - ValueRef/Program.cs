using System;

namespace _1___ValueRef
{
    public class PosicaoClass
    {
        public int X;
        public int Y;
    }

    class Program
    { 
        public static void Dobrar(ref int valor)
        {
            valor *= 2;
        }

        public static void Dobrar(PosicaoClass pos)
        {
            pos.X *= 2;
            pos.Y *= 2;
        }

        static void Main(string[] args)
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;

            Dobrar(pos1);
            Dobrar(pos2);

            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
        }

        private static void DobrarValue()
        {
            int x = 10;
            Dobrar(ref x); //passando valueType para ser tratado como ReferenceType
            Console.WriteLine(x);
        }

        private static void RefTypeInt()
        {
            PosicaoClass pos1 = new PosicaoClass();
            pos1.X = 10;
            pos1.Y = 20;

            PosicaoClass pos2 = new PosicaoClass();
            pos2.X = 30;
            pos2.Y = 40;

            pos2 = pos1; //Apontando ambos para a mesma posição de memória
            pos2.X = 50;

            Console.WriteLine(pos1.X);
            Console.WriteLine(pos1.Y);
            Console.WriteLine(pos2.X);
            Console.WriteLine(pos2.Y);
        }

        private static void ValueTypeInt()
        {
            int x = 10;
            int y = 20;
            y = x; //cópia
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}

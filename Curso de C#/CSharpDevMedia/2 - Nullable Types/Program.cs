using System;

namespace _2___Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int? x = null;

            //if (x != null)
            //{
            //    Console.WriteLine("x possui um valor inteiro"); 
            //}
            //else
            //{
            //    Console.WriteLine("x possui um valor nulo");
            //}

            //Condição Ternária
            Console.WriteLine("O valor de x é " + ((x!=null) ? "um inteiro" : "nulo"));
        }
    }
}

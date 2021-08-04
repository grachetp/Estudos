using System;

namespace _2___ValueRef
{
    public class Cliente : Object //Reference Type
    {
        public int Codigo;
        public string Nome;
        public string Telefone;

        public override string ToString()
        {
            return $"Código: {Codigo}\nNome: {Nome}\nTel: {Telefone}";
        }
    }
    class Program
    {
        public static void MostrarValueTypes()
        {
            int x = 10;
            string s = "Pedro";
            bool b = false;

            Console.WriteLine(x);
            Console.WriteLine(s);
            Console.WriteLine(b);
        }
        static void Main(string[] args)
        {
            Cliente cliente1 = new Cliente();
            cliente1.Codigo = 123;
            cliente1.Nome = "Pedro Grachet";
            cliente1.Telefone = "(66) 9 9725-3456";

            //Cliente cliente2 = cliente1; //aponta para a mesma posição de memoria 'cliente1'
            Cliente cliente2 = new Cliente();

            cliente2.Nome = "João Pedro";

            Console.WriteLine(cliente1);
            Console.WriteLine(cliente2);

            if (cliente1.Equals(cliente2))
            {
                Console.WriteLine("Cliente1 e Cliente2 são os mesmos objetos");
            }
            else
            {
                Console.WriteLine("Cliente1 e Cliente2 são objetos diferentes");
            }

            //Console.WriteLine(cliente.Codigo);
            //Console.WriteLine(cliente.Nome);
            //Console.WriteLine(cliente.Telefone);   
        }
    }
}

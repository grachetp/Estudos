using System;

namespace Generic
{
    public class Pilha<T>
    {
        int pos = 0;
        T[] itens = new T[100];
        public void Push(T item)
        {
            itens[pos] = item;
            pos++;
        }
        public T Pop()
        {
            pos--;
            return itens[pos];
        }
    }

    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Pilha<string>();
            var p2 = new Pilha<int>();
            var p3 = new Pilha<Cliente>();
        }
    }
}

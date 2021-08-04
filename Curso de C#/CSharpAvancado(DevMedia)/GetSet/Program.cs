using System;

namespace GetSet
{

    public class Conta
    {
        private string _cliente;
        private double _valor;

        public Conta(string nomeCliente)
        {
            _cliente = nomeCliente;
            _valor = 0;
        }

        public void Sacar(double valor)
        {
            _valor -= valor; 
        }
        
        public void Depositar(double valor)
        {
            _valor += valor;
        }

        public double getValor()
        {
            return _valor;
        }

        public string getCliente()
        {
            return _cliente;
        }

        public void setCliente(string cliente)
        {
            _cliente = cliente;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta("Pedro Grachet");
            c.Depositar(1000);
            c.Sacar(500);
            Console.WriteLine($"Saldo na data: {c.getValor()}" );
            Console.ReadLine();
        }
    }
}

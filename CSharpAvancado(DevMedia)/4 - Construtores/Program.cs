using System;

namespace _4___Construtores
{
    public class Contato
    {
        public string Tipo;
        public string Descricao;
    }
    public class Cliente
    {
        public int Codigo;
        public string Nome;
        public Contato Contato;

        //Padrão
        public Cliente()
        {
            this.Codigo = 123;
            this.Nome = "Pedro Grachet";
            this.Contato = new Contato();
        }

        //Overloads
        public Cliente(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = "Pedro Grachet";
            this.Contato = new Contato();
        }

        public override string ToString()
        {
            return $"Código: {Codigo} - Nome: {Nome}";
        }
    }

    public class ClienteVIP: Cliente
    {
        public int Tempo;
        public ClienteVIP(int codigo, string nome)
            :base(codigo, nome) //Chamando construtor da classe base
        {
            this.Tempo = 10;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente cli = new Cliente();
            //cli.Codigo = 123;
            //cli.Nome = "Pedro Grachet";
            //cli.Contato.Tipo = "Telefone";
            //cli.Contato.Descricao = "9999999999";

            Cliente cli1 = new ClienteVIP(123, "Pedro");
        }
    }
}

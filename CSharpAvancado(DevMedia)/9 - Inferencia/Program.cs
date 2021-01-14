using System;

namespace _9___Inferencia
{
    public class Connection
    {
        public string ConnectionString;
        public void Conectar()
        {
            Console.WriteLine("Conectando...");
        }
        public void Fechar()
        {
            Console.WriteLine("Fechando Conexão...");
        }
    }
    
    public static class Fabrica
    {
        public static Connection CriarConnection()
        {
            return new Connection();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic con = Fabrica.CriarConnection();
            con.Conectar();
            con.Fechar();
        }
    }
}

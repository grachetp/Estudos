using System;

namespace _6___Propriedades
{
    public class MensalidadeNegativaException : Exception
    {
        public MensalidadeNegativaException(string message)
            :base(message)
        {

        }
    }

    public enum TipoAluno
    {
        Regular, Especial
    }
    public class Aluno
    {
        private int matricula;
        private string nome;
        private double mensalidade;
        private TipoAluno tipo;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Nome { get => nome; set => nome = value; }
        public double Mensalidade { get => mensalidade; set => mensalidade = value; }
        public TipoAluno Tipo { get => tipo; set => tipo = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.Matricula = 123;
            a.Nome = "Pedro";
            a.Mensalidade = 688;
            a.Tipo = TipoAluno.Regular;

            Console.ReadLine();
        }
    }
}

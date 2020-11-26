using System;

namespace Atividade2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("Pedro Grachet", "17/04/2001", 1.75f);
            Pessoa p1 = new Pessoa("Maria Grachet", "17/04/2001", 1.75f);
            Pessoa p2 = new Pessoa("Joana Grachet", "17/04/2001", 1.75f);
            Pessoa p3 = new Pessoa("Eduarda Grachet", "17/04/2001", 1.75f);
            Pessoa p4 = new Pessoa("Pedrão Grachet", "17/04/2001", 1.75f);

            Agenda a = new Agenda();
            a.ArmazenarPessoa(p);
            a.ArmazenarPessoa(p1);
            a.ArmazenarPessoa(p2);
            a.ArmazenarPessoa(p3);
            a.ArmazenarPessoa(p4);


            a.RemoverPessoa("Maria Grachet");

        }
    }
}

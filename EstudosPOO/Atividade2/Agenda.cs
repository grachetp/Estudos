using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade2
{
    public class Agenda
    {
        private List<Pessoa> pessoas;
        public void ArmazenarPessoa(Pessoa p)
        {
            pessoas.Add(p);
        }

        public Agenda()
        {
            pessoas = new List<Pessoa>();
        }

        public void RemoverPessoa(string nome)
        {
            //Implementar pesquisa do usuario e depois remover da lista
            Console.WriteLine($"Pessoa encontrada em: {pessoas.Find(p => p.Nome == nome)}");
        }

        public int BuscarPessoa(string nome)
        {
            //implementar
            return 0;
        }

        public void ImprimirAgenda()
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine($"Nome: {pessoa.Nome}\nAltura: {pessoa.Altura}\nIdade: {pessoa.CalcularIdade()}");
            }
        }

        public void ImprimirPessoa()
        {
            //Implementar
        }

    }
}

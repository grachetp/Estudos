using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade1
{
    public class Pessoa
    {
        private string nome;
        private DateTime dataNascimento;
        private float altura;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }

        public float Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"Seu nome é: {nome}");
            Console.WriteLine($"Você nasceu em: {dataNascimento.Year}");
            Console.WriteLine($"Sua altura é: {altura}");
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }
}

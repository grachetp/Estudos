using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Executando 5 Projeto");

      char primeiraLetra = 'a';
      Console.WriteLine(primeiraLetra);

      primeiraLetra = (char)65;
      Console.WriteLine(primeiraLetra);

      primeiraLetra = (char)(primeiraLetra + 1);
      Console.WriteLine(primeiraLetra);

      string titulo = "Alura Cursos de Tecnologia - " + 2020;
      Console.WriteLine(titulo);

      string cursosProgramacao = "- .Net\n" +
        " - Java\n" +
        " - JavaScript\n" +
        " - C#\n";
      Console.WriteLine(cursosProgramacao);

      Console.ReadLine();
    }
  }
}

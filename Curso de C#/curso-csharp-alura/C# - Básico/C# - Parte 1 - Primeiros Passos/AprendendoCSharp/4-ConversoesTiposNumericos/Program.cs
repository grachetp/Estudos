using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesTiposNumericos
{
  class Program{
    static void Main(string[] args)
    {
      Console.WriteLine("Executando o projeto 4 - Conversões");

      double salario = 1200.50;

      int salarioEmInteiro = (int)salario;

      Console.WriteLine(salario);
      Console.WriteLine(salarioEmInteiro);
      Console.ReadLine();
    }
  }
}

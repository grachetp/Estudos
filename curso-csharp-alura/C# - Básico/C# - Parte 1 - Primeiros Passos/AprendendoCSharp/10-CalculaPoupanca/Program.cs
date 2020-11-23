using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Executando projeto 10 - Calcula Poupanca");

      double valorInvestido = 1000;
      int contMes = 1;

      while (contMes <= 12)
      {
        valorInvestido = valorInvestido + (valorInvestido * 0.0036);
        Console.WriteLine("Após " + contMes + " meses, você tera R$ " + valorInvestido);
      }
      

      Console.ReadLine();
    }
  }
}

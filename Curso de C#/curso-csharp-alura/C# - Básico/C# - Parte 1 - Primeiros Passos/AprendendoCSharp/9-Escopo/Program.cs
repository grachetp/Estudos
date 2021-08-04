using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Projeto 9 - Escopo");

      int idadeJoao = 16;
      bool acompanhado = true;
      string msg = "";


      if (acompanhado == true)
      {
        msg = "João está acompanhado";
      }
      else
      {
        msg = "João não está acompanhado";
      }

      if ((idadeJoao >= 18 && acompanhado == true))
      {
        Console.WriteLine("Pode entrar.");
        Console.WriteLine(msg);
      }
      else
      {
        Console.WriteLine("Não pode entrar.");
      }


      Console.ReadLine();
    }
  }
}

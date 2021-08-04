using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Projeto 7 - Condicionais");

      int idadeJoao = 16;
      int quantidadeDePessoas = 2;

      if(idadeJoao >= 18)
      {
        Console.WriteLine("João possuí mais de 18 anos de idade. Pode entrar.");
      }
      else
      {
        if(quantidadeDePessoas >= 2)
        {
          Console.WriteLine("João não possui mais de 18 anos, mas esta acompanhado. Pode entrar");
        }
        else
        {
          Console.WriteLine("João nao possui mais de 18 anos, não pode entrar.");
        }
        
      }


      Console.ReadLine();
    }
  }
}

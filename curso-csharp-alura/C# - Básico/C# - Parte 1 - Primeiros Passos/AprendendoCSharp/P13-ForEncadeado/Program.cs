using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P13_ForEncadeado
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Projeto 13");


      //Uma forma diferente de fazer 
      for(int i=0; i<10; i++)
      {
        for(int j=0; j<10; j++)
        {
          Console.Write("*");
          if(j >= i)
          {
            break;
          }
        }
        Console.WriteLine();
      }

      for (int i = 0; i < 10; i++)
      {
        for (int j = 0; j<=i ; j++)
        {
          Console.Write("*");
        }
        Console.WriteLine();
      }

      Console.ReadLine();
    }
  }
}

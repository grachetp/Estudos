using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Executando projeto 2 - Criando Variáveis");
      int idade = 13;
      Console.WriteLine(idade);
      
      idade = 10 + 3;
      Console.WriteLine(idade);

      idade = 10 - 3;
      Console.WriteLine(idade);

      idade = 10 * 3;
      Console.WriteLine(idade);

      idade = 10 / 3;
      Console.WriteLine(idade);

      idade = 10 % 3;
      Console.WriteLine(idade);

      Console.WriteLine("Digite alguma tecla para finalizar o programa");
      Console.ReadLine();
    }
  }
}

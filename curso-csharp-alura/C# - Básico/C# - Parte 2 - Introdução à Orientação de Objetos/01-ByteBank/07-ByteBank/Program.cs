using System;

namespace _07_ByteBank {
  class Program {
    static void Main(string[] args) {
      ContaCorrente conta = new ContaCorrente(867, 6584655);
      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

      Console.WriteLine(conta.Agencia);
      Console.WriteLine(conta.Numero);

      ContaCorrente contaDaGabriela = new ContaCorrente(315, 65435);
      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

      Console.ReadLine();
    }
  }
}

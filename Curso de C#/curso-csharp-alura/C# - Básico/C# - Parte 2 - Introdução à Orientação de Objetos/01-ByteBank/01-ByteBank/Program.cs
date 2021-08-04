using System;

namespace _01_ByteBank {
  class Program {
    static void Main(string[] args) {
      ContaCorrente contaDaGabriela = new ContaCorrente();

      contaDaGabriela.titular = "Gabriela da Oliveira da Silva";
      contaDaGabriela.agencia = 863;
      contaDaGabriela.numero = 863452;
      contaDaGabriela.saldo = 100.65;

      Console.WriteLine("Titular: " + contaDaGabriela.titular);
      Console.WriteLine("Agência: " + contaDaGabriela.agencia);
      Console.WriteLine("Número: " + contaDaGabriela.numero);
      Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

      Console.ReadLine();
    }
  }
}

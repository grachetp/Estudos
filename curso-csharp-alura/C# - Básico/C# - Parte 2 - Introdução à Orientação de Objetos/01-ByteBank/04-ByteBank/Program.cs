using System;

namespace _04_ByteBank {
  class Program {
    static void Main(string[] args) {
      ContaCorrente contaDoBruno = new ContaCorrente();

      contaDoBruno.titular = "Bruno da Silva";
      Console.WriteLine(contaDoBruno.saldo);
      bool resultadoSaque = contaDoBruno.Sacar(50);
      Console.WriteLine(contaDoBruno.saldo);
      Console.WriteLine(resultadoSaque);

      contaDoBruno.Depositar(500);
      Console.WriteLine(contaDoBruno.saldo);

      ContaCorrente contaDaGabriela = new ContaCorrente();

      contaDaGabriela.titular = "Gabriela";


      Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
      Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

      contaDoBruno.Transferir(200, contaDoBruno);

      Console.WriteLine("Saldo do Bruno: " + contaDoBruno.saldo);
      Console.WriteLine("Saldo do Gabriela: " + contaDaGabriela.saldo);

      Console.ReadLine();
    }
  }
}

using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;
using System;

namespace ByteBank.SistemaAgencia {
  class Program {
    static void Main(string[] args) {
      ContaCorrente conta = new ContaCorrente(847, 666996);
      Funcionario funcionario = null;

      FuncionarioAutenticavel carlos = null;

      carlos.Autenticar("dasdasda");

      Console.WriteLine(conta.Numero);



      Console.ReadLine();
    }
  }
}

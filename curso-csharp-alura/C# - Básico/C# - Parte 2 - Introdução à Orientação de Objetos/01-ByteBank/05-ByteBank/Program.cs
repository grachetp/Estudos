using System;

namespace _05_ByteBank {
  class Program {
    static void Main(string[] args) {

      //Cliente gabriela = new Cliente();
      //gabriela.nome = "Gabriela da Silva";
      //gabriela.profissao = "Desenvolvedora C#";
      //gabriela.cpf = "434.562.645-23";

      ContaCorrente conta = new ContaCorrente();
      //conta.titular = gabriela;
      //conta.titular = new Cliente();

      
      conta.saldo = 500;
      conta.numero = 3456;
      conta.agencia = 4545;

      //Console.WriteLine(conta.titular.nome);

      if(conta.titular == null) {
        Console.WriteLine("A referencia desse objeto é nula");
      }
      

      Console.ReadLine();




    }
  }
}

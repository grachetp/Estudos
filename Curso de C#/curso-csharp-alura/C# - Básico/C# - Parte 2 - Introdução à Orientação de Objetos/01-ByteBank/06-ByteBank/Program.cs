﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank {
  class Program {
    static void Main(string[] args) {
      ContaCorrente conta = new ContaCorrente();
      Cliente cliente = new Cliente();

      cliente.Nome = "Grachet";
      cliente.CPF = "051.963.241-94";
      cliente.Profissao = "Zé Ruelinhha";

      conta.Titular = cliente;
      conta.Saldo = 1260;

      Console.WriteLine(conta.Titular.Nome);
      Console.WriteLine(conta.Saldo);

      Console.ReadLine();
    }
  }
}

using System;
using System.Security.Policy;
using System.Text.RegularExpressions;
using ByteBank.Modelos;
using Humanizer;


namespace ByteBank.SistemaAgencia {
  class Program {
    static void Main(string[] args) {

      ListaDeClientes

      Console.ReadLine();
    }

    static void TestaIndexadoresEGetters() {
      //SomarVarios(0, 1, 1, 2, 3, 5, 8, 12 );


      ListaDeContaCorrente lista = new ListaDeContaCorrente();

      ContaCorrente contaDoGui = new ContaCorrente(111, 22222);

      ContaCorrente[] contas = new ContaCorrente[]{
        new ContaCorrente(123, 3333),
        new ContaCorrente(123, 3333),
        contaDoGui
      };

      lista.AdicionarVarios(
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui,
        contaDoGui
       );

      for (int i = 0; i < lista.Tamanho; i++) {
        ContaCorrente itemAtual = lista.GetItemNoIndice(i);
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
      }

      lista.Remover(contaDoGui);

      for (int i = 0; i < lista.Tamanho; i++) {
        ContaCorrente itemAtual = lista.GetItemNoIndice(i);
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
      }
    }

    
    static void TestaArrayDeContaCorrente() {
      ContaCorrente[] contas = new ContaCorrente[]{
        new ContaCorrente(123, 3333),
        new ContaCorrente(123, 3334),
        new ContaCorrente(123, 3335)
      };

      for (int i = 0; i < contas.Length; i++) {
        ContaCorrente contaAtual = contas[i];
        Console.WriteLine($"Conta {i} {contaAtual.Numero}");
      }
    }

    static void SomarVarios(params int[] numeros) {
      int soma = 0;
      foreach(int numero in numeros) {
        soma += numero;
      }
      Console.WriteLine($"A soma é: {soma}");
    }
  }
}

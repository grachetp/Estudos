using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Comparadores;
using ByteBank.SistemaAgencia.Extensoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;

namespace ByteBank.SistemaAgencia {
  class Program {
    static void Main(string[] args) {

      var contas = new List<ContaCorrente>() {
        new ContaCorrente(10, 111),
        new ContaCorrente(9, 922),
        new ContaCorrente(8, 33),
        null, null,
        new ContaCorrente(6, 23),
        new ContaCorrente(5, 4),
        new ContaCorrente(4, 123),
        new ContaCorrente(3, 822),
        new ContaCorrente(2, 91)
      };


      Console.WriteLine("RELOU UOIUDIII!");

      //contas.Sort(); ~~> Chama a implementação dada em IComparable

      //contas.Sort(new ComparadorContaCorrentePorAgencia());

      //IEnumerable<ContaCorrente> contasNaoNulas = contas.Where(conta => conta != null);

      var contaOrdenadas = contas
        .Where(conta => conta != null)
        .OrderBy(conta => conta.Numero);


      foreach (var conta in contaOrdenadas) {
          Console.WriteLine($"Conta número {conta.Numero}, ag. {conta.Agencia}");
      }

      Console.ReadLine();


      
      var nomes = new List<string>() {
        "Pedro", "Luan", "Jackson", "Yasmin"
      };

      nomes.Sort();

      foreach (var nome in nomes) {
        Console.WriteLine(nome);
      }


      var idades = new List<int>();

      idades.Add(5);
      idades.Add(6);
      idades.Add(7);
      idades.Add(8);
      idades.Add(9);
      idades.Add(10);

      idades.AdicionarVarios(42, 21, 33);

      idades.Sort();

      for(int i = 0; i < idades.Count; i++) {
        Console.WriteLine(idades[i]);
      }

      Console.ReadLine();
    }




    static void TestaListaDeObjects() {
      ListaDeObjects listaDeIdade = new ListaDeObjects();

      listaDeIdade.Adicionar(10);
      listaDeIdade.Adicionar(20);
      listaDeIdade.Adicionar(30);
      listaDeIdade.Adicionar(40);
      listaDeIdade.AdicionarVarios(10, 23, 43, 54, 32, 43, 43, 55);

      for (int i = 0; i < listaDeIdade.Tamanho; i++) {
        int idade = (int)listaDeIdade[i];
        Console.WriteLine($"Idade no indice {i}: {idade}");
      }

    }

    static int SomarVarios(params int[] numeros) {
      int acumulador = 0;
      foreach (int numero in numeros) {
        acumulador += numero;
      }
      return acumulador;
    }


    static void TestaListaDeContaCorrente() {
      //ListaDeContaCorrente lista = new ListaDeContaCorrente();
      ListaDeContaCorrente lista = new ListaDeContaCorrente();

      ContaCorrente contaDoGui = new ContaCorrente(11111, 1111111);

      ContaCorrente[] contas = new ContaCorrente[]
      {
                contaDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679754)
      };

      lista.AdicionarVarios(contas);

      lista.AdicionarVarios(
          contaDoGui,
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787),
          new ContaCorrente(874, 5679787)
      );

      for (int i = 0; i < lista.Tamanho; i++) {
        ContaCorrente itemAtual = lista[i];
        Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
      }
    }



    static void TestaArrayDeContaCorrente() {
      ContaCorrente[] contas = new ContaCorrente[]
          {
                    new ContaCorrente(874, 5679787),
                    new ContaCorrente(874, 4456668),
                    new ContaCorrente(874, 7781438)
          };

      for (int indice = 0; indice < contas.Length; indice++) {
        ContaCorrente contaAtual = contas[indice];
        Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
      }
    }

    static void TestaArrayInt() {
      // ARRAY de inteiros, com 5 posições!
      int[] idades = null;
      idades = new int[3];

      idades[0] = 15;
      idades[1] = 28;
      idades[2] = 35;
      //idades[3] = 50;
      //idades[4] = 28;
      //idades[5] = 60;

      Console.WriteLine(idades.Length);

      int acumulador = 0;
      for (int indice = 0; indice < idades.Length; indice++) {
        int idade = idades[indice];

        Console.WriteLine($"Acessando o array idades no índice {indice}");
        Console.WriteLine($"Valor de idades[{indice}] = {idade}");

        acumulador += idade;
      }

      int media = acumulador / idades.Length;
      Console.WriteLine($"Média de idades = {media}");
    }

  }
}

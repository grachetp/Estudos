using System;
using System.IO;

namespace ByteBankImportacaoExportacao {
  partial class Program {
    static void Main(string[] args) {


      File.AppendAllText("testandoClasseFile.txt", "Pedro da Silva\n");
      File.AppendAllText("testandoClasseFile.txt", "Pedro da Silva\n");
      File.AppendAllText("testandoClasseFile.txt", "roger da Silva\n");
      File.AppendAllText("testandoClasseFile.txt", "Graxa da Silva\n");

      Console.WriteLine("Arquivo com a classe file criado");
      Console.ReadLine();

      var bytesArquivo = File.ReadAllBytes("contas.txt");
      Console.WriteLine($"Arquivo xontas.txt possui {bytesArquivo.Length/1000} KBytes");
      
      Console.ReadLine();
      var linhas = File.ReadAllLines("contas.txt");

      Console.WriteLine(linhas.Length);

      foreach (var linha in linhas) {
        Console.WriteLine(linha);
      }

      Console.ReadLine();

      Console.Write("Digite o seu nome: ");
      var nome = Console.ReadLine();
      Console.WriteLine(nome);

      //using (var fs = new FileStream("testaTipos.txt", FileMode.Create))
      //using (var escritor = new StreamWriter(fs)) {
      //  escritor.WriteLine(true);
      //  escritor.WriteLine(false);
      //  escritor.WriteLine(12312312312);
      //}

      //TestaEscrita();
      Console.WriteLine("Aplicação finalizada. . .");


      Console.ReadLine();
    }
  }
}

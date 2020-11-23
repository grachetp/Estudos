using System;
using System.IO;

namespace ByteBank {
  class Program {
    static void Main(string[] args) {

      try {
        CarregarContas();
      }
      catch(Exception) {
        Console.WriteLine("Catch no método MAIN");
      }
      Console.WriteLine("Execução Finalizada! Tecle enter para sair");
      Console.ReadLine();
    }

    private static void CarregarContas() {

      using (LeitorDeArquivos leitor = new LeitorDeArquivos("teste.txt")) {

        //IDisposable
        leitor.LerProximaLinha();
      }


      //----------------------------------------------------------

      /*LeitorDeArquivos leitor = null;
      try {
        leitor = new LeitorDeArquivos("contas.txt");
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
        leitor.LerProximaLinha();
      }
      finally {
        Console.WriteLine("Executando o Finally");
        if(leitor != null) {
          leitor.Fechar();
        }
      }*/
    }

    private static void TestaInnerException() {
      try {
        ContaCorrente conta1 = new ContaCorrente(225, 2556);
        ContaCorrente conta2 = new ContaCorrente(225, 2557);

        //conta1.Transferir(100000, conta2);
        conta1.Sacar(5000);

      }
      catch (OperacaoFinanceiraException e) {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);

        /*Console.WriteLine("Informações da INNER EXCEPTION(exceção interna): ");
        Console.WriteLine(e.InnerException.Message);
        Console.WriteLine(e.InnerException.StackTrace);*/

      }
    }

    private static void Metodo() {
      TestaDivisao(0);
    }

    private static void TestaDivisao(int divisor) {
        int resultado = Dividir(10, divisor);
        Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
    }

    private static int Dividir(int numero, int divisor) {

      try {
        return numero / divisor;
      }
      catch (DivideByZeroException) {
        Console.WriteLine("Excesão com numero=" + numero + " e divisor" + divisor);
        throw;
      }

      
    }
  }
}
//using ByteBankImportacaoExportacao.Modelos;
//using System;
//using System.IO;
//using System.Text;

//namespace ByteBankImportacaoExportacao {
//  partial class Program {
//    //lidandoComFileStreamDiretamente();

//    var enderecoDoArquivo = "contas.txt";

//      using(var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
//      using (var leitor = new StreamReader(fluxoDoArquivo)) {
//        //Enquanto não chegou no fim do fluxo de arquivo, escreve cada linha
//        while (!leitor.EndOfStream) {
//          var linha = leitor.ReadLine();

//  var contaCorrente = ConverterStringParaContaCorrente(linha);

//  var msg = $"Titular: {contaCorrente.Titular.Nome}" +
//    $"\nNúmero: {contaCorrente.Numero}\n" +
//    $"Agência: {contaCorrente.Agencia}\n" +
//    $"Saldo: R${contaCorrente.Saldo}\n";

//  Console.WriteLine(msg);
//        }
//      }
//static ContaCorrente ConverterStringParaContaCorrente(string linha) {

//  var campos = linha.Split(',');
//  var agencia = campos[0];
//  var numero = campos[1];
//  var saldo = campos[2].Replace('.', ',');
//  var nome = campos[3];

//  var agenciaComoInt = int.Parse(agencia);
//  var numeroComoInt = int.Parse(numero);
//  var saldoComoDouble = double.Parse(saldo);
//  //var titular = new Cliente();
//  //titular.Nome = nome;

//  //var resultado = new ContaCorrente(agenciaComoInt, numeroComoInt);
//  //resultado.Depositar(saldoComoDouble);
//  //resultado.Titular = titular;

//  //return resultado;
//}

//  }
//}
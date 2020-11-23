using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankImportacaoExportacao {
  partial class Program {
    static void EscritaBinaria() {
      using (var fs = new FileStream("contacorrente.txt", FileMode.Create))
      using (var escritor = new BinaryWriter(fs)) {
        escritor.Write(456); //Número da Agencia
        escritor.Write(4444440); //Número da Conta
        escritor.Write(4500.55);
        escritor.Write("Gustavo Braga");
      }  
    }

    static void LeituraBinaria() {
      using (var fs = new FileStream("contacorrente.txt", FileMode.Open))
      using (var leitor = new BinaryReader(fs)) {
        var agencia = leitor.ReadInt32();
        var numeroConta = leitor.ReadInt32();
        var saldo = leitor.ReadDouble();
        var titular = leitor.ReadString();

        Console.WriteLine($"{agencia}/{numeroConta} {titular} {saldo}");

      }
    }
  }
}

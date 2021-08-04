using System.ComponentModel;
using System.IO;
using System.Text;

namespace ByteBankImportacaoExportacao {
  partial class Program {
    static void CriarArquivo() {
      var caminhoNovoArquivo = "contasExportadas.csv";

      using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create)) {
        var contaComoString = "465,78945,7711.32,Pedro Grachet";

        var encoding = Encoding.UTF8;
        var bytes = encoding.GetBytes(contaComoString);

        
        fluxoDeArquivo.Write(bytes, 0, bytes.Length);
      }

    }

    static void CriarArquivoComWriter() {
      var caminhoNovoArquivo = "ContasExportadas.csv";
      using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.CreateNew))
      using(var escritor = new StreamWriter(fluxoDeArquivo, Encoding.UTF8)) {
        escritor.Write("456,222,550.49, Pedro Grachet");
      }
    }
  }
}
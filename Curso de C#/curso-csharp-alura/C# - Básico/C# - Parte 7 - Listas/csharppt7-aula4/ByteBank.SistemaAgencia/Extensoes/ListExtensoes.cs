using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes {
  public static class ListExtensoes {

    public static void AdicionarVarios<T>(this List<T> lista, params T[] itens) {
      foreach (T item in itens) {
        lista.Add(item);
      }
    }

    public static void TesteGenerico<T2>(this string texto) {
      string pedro = "Pedro";
    }

    


    static void Teste() {
      List<int> idades = new List<int>();

      idades.Add(14);
      idades.Add(14);
      idades.Add(14);

      //pedro.TesteGenerico<int>();
      idades.AdicionarVarios(15, 32, 44, 115);

      //ListExtensoes<int>.AdicionarVarios(idades, 22, 22, 22, 22, 22, 22, 22);

      List<string> nomes = new List<string>();

      nomes.Add("Guiljermer");

      //ListExtensoes<string>.AdicionarVarios(nomes, "Pedro", "Grachet", "Feijao");

    }
  }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
  public class ExtratorValorDeArgumentosURL {

    public string URL { get; }
    private readonly string _argumentos;
    
    public ExtratorValorDeArgumentosURL(string url) {
      if (string.IsNullOrEmpty(url)) {
        throw new ArgumentException("O argumento URL não pode ser nulo ou vazio", nameof(url));
      }

      int indiceInterrogação = url.IndexOf('?');
      _argumentos = url.Substring(indiceInterrogação + 1);

      URL = url;
      
    }
    //moedaOrigem=real&moedaDestino=dolar
    public string GetValor(string nomeParametro) {
      nomeParametro = nomeParametro.ToUpper();
      string argumentoCaixaAlta = _argumentos.ToUpper();

      
      string termo = nomeParametro + '=';
      int indiceTermo = argumentoCaixaAlta.IndexOf(termo);

      string resultado = _argumentos.Substring(indiceTermo + termo.Length);
      int indiceEComercial = resultado.IndexOf('&');

      if(indiceEComercial == -1) {
        return resultado;
      }

      return resultado.Remove(indiceEComercial);
      //int indiceParametro = _argumentos.IndexOf();
    }
  }
}

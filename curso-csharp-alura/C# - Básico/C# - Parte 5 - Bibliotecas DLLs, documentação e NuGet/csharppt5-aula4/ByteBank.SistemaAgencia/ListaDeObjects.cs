using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia {
  public class ListaDeObjects {
    private Object[] _itens;
    private int _proximaPosicao;

    public int Tamanho {
      get {
        return _proximaPosicao;
      }
    }

    public ListaDeObject(int capacidadeInicial = 5) {
      _itens = new object[capacidadeInicial];
      _proximaPosicao = 0;
    }


    public void Adicionar(object item) {
      VerificarCapacidade(_proximaPosicao + 1);
      //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
      _itens[_proximaPosicao] = item;
      _proximaPosicao++;
    }

    //Puxa todos os parametros passados na função na classe principal
    public void AdicionarVarios(params object[] itens) {
      foreach (object item in itens) {
        Adicionar(item);
      }
    }


    public object GetItemNoIndice(int indice) {
      if (indice < 0 || indice >= _proximaPosicao) {
        throw new ArgumentOutOfRangeException(nameof(indice));
      }
      return _itens[indice];

    }

    public void Remover(object item) {
      int indiceItem = -1;

      for (int i = 0; i < _proximaPosicao - 1; i++) {
        if (_itens[i].Equals(item)) {
          indiceItem = i;
          break;
        }
      }

      for (int i = indiceItem; i < _proximaPosicao; i++) {
        _itens[i] = _itens[i + 1];
      }
      _proximaPosicao--;
      _itens[_proximaPosicao] = null;
    }

    private void VerificarCapacidade(int tamanhoNecessario) {
      if (_itens.Length >= tamanhoNecessario) {
        return;
      }

      int novoTamanho = _itens.Length * 2;
      if (novoTamanho < tamanhoNecessario) {
        novoTamanho = tamanhoNecessario;
      }

      //Console.WriteLine("Aumentando a capacidade da lista!");

      Object[] novoArray = new Object[novoTamanho];

      for (int i = 0; i < _itens.Length; i++) {
        novoArray[i] = _itens[i];
        //Console.WriteLine(".");
      }

      _itens = novoArray;
    }

    //Indexador
    public Object this[int indice] {
      get {
        return GetItemNoIndice(indice);
      }
    }
  }
}

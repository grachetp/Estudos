using System;
using System.Collections.Generic;
using System.Text;

namespace TestesUnitariosMOQ
{
  public class CadastrarProdutos : ICadastrarProdutos
  {
    public Produto Cadastrar(Produto prod)
    {
      
      if (prod == null)
      {
        return null;
      }
      else
      {
        Console.WriteLine($"Cadastrando o Produto {prod.Nome} - {prod.Preco}");
        prod.Id = 1;
        return prod;
      }
    }
  }
}
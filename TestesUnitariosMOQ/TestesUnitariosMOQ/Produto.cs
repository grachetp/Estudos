using System;
using System.Collections.Generic;
using System.Text;

namespace TestesUnitariosMOQ
{
  public class Produto
  {
    public int Id { get; set; }
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
      Nome = nome;
      Preco = preco;
    }
  }
}

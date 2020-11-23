using System;
using System.Collections.Generic;
using System.Text;

namespace TestesUnitariosMOQ
{
  public class TesteTeste
  {

    private ICadastrarProdutos _cadastrarProduto;
    public TesteTeste(ICadastrarProdutos cadastrarProduto)
    {
      _cadastrarProduto = cadastrarProduto;
    }

    public bool CadastraProduto(Produto prod)
    {      
      var produtoCadastrado = _cadastrarProduto.Cadastrar(prod);
      if (produtoCadastrado != null)
      {
        return true;
      }
      return false;
    }
  }
}

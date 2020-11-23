using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestesUnitariosMOQ
{
  public class CadastrarProdutoTest
  {
    private CadastrarProdutos _cadastrarProdutos;
    public CadastrarProdutoTest()
    {
      _cadastrarProdutos = new CadastrarProdutos();
    }

    [Fact]
    public void CadastrarProduto_Sucesso()
    {
      var produto = new Produto("Coca Cola 3L", 10.00);
      var cadastrar = _cadastrarProdutos.Cadastrar(produto);
      Assert.True(cadastrar.Id != 0);
    }
    
    [Fact]
    public void CadastrarProduto_Falha()
    {
      var cadastrar = _cadastrarProdutos.Cadastrar(null);
      Assert.True(cadastrar == null);

    }
  }
}

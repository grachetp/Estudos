using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestesUnitariosMOQ
{
  public class TesteTesteTest
  {
    private TesteTeste _testeteste;
    private readonly Mock<ICadastrarProdutos> _cadastrarProdutos;
    public TesteTesteTest()
    {
      _cadastrarProdutos = new Mock<ICadastrarProdutos>();
      _testeteste = new TesteTeste(_cadastrarProdutos.Object);
    }

    [Fact]
    public void CadastrarProduto_Sucesso()
    {
      var prod = new Produto("Fanta Laranja", 5.00);      

      _cadastrarProdutos.Setup(cadastro => cadastro.Cadastrar(prod)).Returns(prod);

      var result = _testeteste.CadastraProduto(prod);

      Assert.True(result == true);
    }

    [Fact]
    public void CadastrarProduto_Erro()
    {
      var prod = new Produto("Fanta Laranja", 5.00);

      _cadastrarProdutos.Setup(cadastro => cadastro.Cadastrar(null)).Returns(prod);

      var result = _testeteste.CadastraProduto(prod);

      Assert.True(result == false);
    }
  }
}

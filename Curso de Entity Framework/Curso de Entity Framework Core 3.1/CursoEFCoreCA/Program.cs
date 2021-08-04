using CursoEFCore.Entidades;
using CursoEFCore.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;

namespace CursoEFCore
{
  class Program
  {
    static void Main(string[] args)
    {
      //using var db = new Data.ApplicationContext();
      ////db.Database.Migrate();
      //var existe = db.Database.GetPendingMigrations().Any();
      //if (existe)
      //{
      //  //Regra de Negócio Aqui
      //}
      InserirDados();
    }
    private static void InserirDados()
    {
      var produto = new Produto
      {
        Descricao = "Produto Teste",
        CodigoBarras = "123123123123",
        Valor = 10m,
        TipoProduto = TipoProduto.MercadoriaParaRevenda,
        Ativo = true
      };

      var cliente = new Cliente
      {
        Nome = "Pedro Grachet",
        CEP = "74870552",
        Cidade = "Rondonópolis",
        Estado = "MT",
        Telefone = "6699976991"
      };

      using var db = new Data.ApplicationContext();
      //Formas de Adicionar Instancia
      //db.Produtos.Add(produto);
      //db.Set<Produto>().Add(produto);
      //db.Entry(produto).State = EntityState.Added;
      //db.Add(produto);

      db.AddRange(produto, cliente);

      var registro = db.SaveChanges();

      Console.WriteLine($"Total de registro(s): {registro}");


    }
  }
}

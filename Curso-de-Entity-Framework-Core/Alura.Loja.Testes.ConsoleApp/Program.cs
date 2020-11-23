using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Alura.Loja.Testes.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      var cliente = new Cliente();
      cliente.Nome = "Pedro Grachet";
      cliente.EnderecoEntrega = new Endereco()
      {
        Numero = 184,
        Logradouro = "Rua Cezar Oscar Velho",
        Complemento = "Ao Lado da Escola",
        Bairro = "Res. Farias",
        Cidade = "Rondonópolis"
      };

      using (var context = new LojaContext())
      {
        var serviceProvider = context.GetInfrastructure<IServiceProvider>();
        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        loggerFactory.AddProvider(SqlLoggerProvider.Create());

        context.Clientes.Add(cliente);
        ExibeEntries(context.ChangeTracker.Entries());

        context.SaveChanges();
        ExibeEntries(context.ChangeTracker.Entries());
      }
    }

    private static void MuitoParaMuitos()
    {
      var p1 = new Produto() { Nome = "Suco de Laranja", Categoria = "Bebidas", PrecoUnitario = 8.77, Unidade = "Litros" };
      var p2 = new Produto() { Nome = "Café", Categoria = "Bebidas", PrecoUnitario = 1.50, Unidade = "Gramas" };
      var p3 = new Produto() { Nome = "Macarraão", Categoria = "Alimentos", PrecoUnitario = 3.75, Unidade = "Pacote" };

      var promocaoDePascoa = new Promocao();
      promocaoDePascoa.Descricao = "Páscoa Feliz";
      promocaoDePascoa.DataInicio = DateTime.Now;
      promocaoDePascoa.DataTermino = DateTime.Now.AddMonths(3);

      promocaoDePascoa.IncluiProduto(p1);
      promocaoDePascoa.IncluiProduto(p2);
      promocaoDePascoa.IncluiProduto(p3);

      using (var context = new LojaContext())
      {
        //codigo para criar o SQL no console.
        var serviceProvider = context.GetInfrastructure<IServiceProvider>();
        var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
        loggerFactory.AddProvider(SqlLoggerProvider.Create());

        //context.Promocoes.Add(promocaoDePascoa);

        var promocao = context.Promocoes.Find(1);
        context.Promocoes.Remove(promocao);

        ExibeEntries(context.ChangeTracker.Entries());
        context.SaveChanges();
      }
    }

    private static void ExibeEntries(IEnumerable<EntityEntry> entries)
    {
      Console.WriteLine("============================");
      foreach (var e in entries)
      {
        Console.WriteLine(e.Entity.ToString() + " - " + e.State);
      }
    }
  }
}

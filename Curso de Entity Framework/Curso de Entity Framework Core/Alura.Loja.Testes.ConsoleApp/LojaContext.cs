using Microsoft.EntityFrameworkCore;

namespace Alura.Loja.Testes.ConsoleApp
{
  public class LojaContext : DbContext
  {

    //propriedade DbSet para o tipo , nome da tabela
    //public DbSet<TipoClasse> NomeTabela {get; set;}
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Compra> Compras { get; set; }
    public DbSet<Promocao> Promocoes { get; set; }
    public DbSet<Cliente> Clientes { get; set; }

    //Sobrescrever método para fazer chave composta
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder
        .Entity<PromocaoProduto>()
        .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId });
      base.OnModelCreating(modelBuilder);


      //Renomear uma determinada tabela
      modelBuilder
        .Entity<Endereco>()
        .ToTable("Enderecos");
      

      //Criar propiedade oculta
      modelBuilder
        .Entity<Endereco>()
        .Property<int>("ClienteId"); //ShadowProperty

      //Definir chave primaria
      modelBuilder
        .Entity<Endereco>()
        .HasKey("ClienteId");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=GRACHET-PC;Database=LojaDB;User Id=sa;Password=graxinha;");
    }
  }
}
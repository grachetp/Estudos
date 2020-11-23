using CursoEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CursoEFCore.Data
{
  public class ApplicationContext : DbContext
  {
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer("Server=localhost;Database=CursoEFCore;Trusted_Connection=True");
      //optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Database=CursoEFCore;Trusted_Connection=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      //modelBuilder.ApplyConfiguration(new ClienteConfiguration()); Forma de Adicionar classe por classe manualmente
      modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationContext).Assembly);
    }
  }
}
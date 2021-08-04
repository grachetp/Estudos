using CursoEFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Configurations
{
  public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
  {
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
      builder.ToTable("Produtos");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.CodigoBarras).HasColumnType("VARCHAR(14)").IsRequired();
      builder.Property(p => p.Descricao).HasColumnType("CHAR(60)");
      builder.Property(p => p.Valor).IsRequired();
      builder.Property(p => p.TipoProduto).HasConversion<string>();
      //p.Property(p => p.TipoProduto).HasConversion<itn>();  GRAVAR EM INTEITO OU STRING OS ENUM NO BANCO DE DADOS
    }
  }
}
using CursoEFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CursoEFCore.Configurations
{
  public class PedidoItemConfiguration : IEntityTypeConfiguration<PedidoItem>
  {
    public void Configure(EntityTypeBuilder<PedidoItem> builder)
    {
      builder.ToTable("PedidoItens");
      builder.HasKey(p => p.Id);
      builder.Property(p => p.Quantidade).HasDefaultValue(1).IsRequired();
      builder.Property(p => p.Valor).IsRequired();
      builder.Property(p => p.Desconto).HasDefaultValue(0.0).IsRequired();
    }
  }
}
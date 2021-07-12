using Meus_produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meus_produtos.Infra.Data.Mappings
{
    public class ProdutoMapping
    {
        public ProdutoMapping(EntityTypeBuilder<Produto> entity)
        {
            entity.ToTable(name: "Produto")
                .HasKey(p => p.Id);

            
            entity.Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

            entity.Property(p => p.Valor)
                .HasColumnName("Valor")
                .HasColumnType("decimal")
                .HasPrecision(8, 2)
                .IsRequired();

            entity.Property(p => p.Status)
                .HasColumnName("Status")
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}

using Meus_produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Meus_produtos.Infra.Data.Mappings
{
    public class UsuarioMapping
    {
        public  UsuarioMapping(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable(name: "Usuario")
                .HasKey(p => p.Id);

            entity.HasIndex(p => p.Email)
                .IsUnique();
            
            entity.Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("int")
                .IsRequired();

            entity.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(p => p.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar")
                .HasMaxLength(72)
                .IsRequired();

            entity.Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

        }
    }
}

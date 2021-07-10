using Meus_produtos.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meus_produtos.Infra.Data.Mappings
{
    public class UsuarioMapping
    {
        public  UsuarioMapping(EntityTypeBuilder<Usuario> entity)
        {
            entity.ToTable(name:"Usuario")
                .HasAlternateKey(p=> p.Email);

            entity.Property(p => p.Id)
                .HasColumnName("Id")
                .HasColumnType("decimal")
                .IsRequired();

            entity.Property(p => p.Nome)
                .HasColumnName("Nome")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(p => p.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar")
                .HasMaxLength(20)
                .IsRequired();

            entity.Property(p => p.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar")
                .HasMaxLength(80)
                .IsRequired();

        }
    }
}

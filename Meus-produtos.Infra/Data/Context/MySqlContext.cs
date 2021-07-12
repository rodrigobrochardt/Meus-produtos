using Meus_produtos.Domain.Entities;
using Meus_produtos.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Meus_produtos.Infra.Data.Context
{
    public class MySqlContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder.UseMySql(@"server=localhost; port=3306; database=meusprodutos; user=root; password=root123",
                ServerVersion.AutoDetect(@"server=localhost; port=3306; database=meusprodutos; user=root; password=root123"));

        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Produto> Produtos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            new UsuarioMapping(modelBuilder.Entity<Usuario>());
            new ProdutoMapping(modelBuilder.Entity<Produto>());

        }
    }
}

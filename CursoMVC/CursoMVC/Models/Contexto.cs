using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Contexto: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=localhost\SQLEXPRESS;Database=CursoMVC;Trusted_Connection=True");
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using TesteAutoGlassPersistencia.Model;

namespace TesteAutoGlassPersistencia.Padrao
{
    public class TesteDbContext : DbContext
    {
        public TesteDbContext(DbContextOptions<TesteDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }
    }
}

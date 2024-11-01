using Microsoft.EntityFrameworkCore;
using APIBotas.Models;

namespace APIBotas.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<APIBotas.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<APIBotas.Models.Compra> Compra { get; set; } = default!;
        public DbSet<APIBotas.Models.Doce> Doce { get; set; } = default!;
        public DbSet<APIBotas.Models.Produto> Produto { get; set; } = default!;
    }
}
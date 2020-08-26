using Microsoft.EntityFrameworkCore;
using ProAgilAPI.Model;

namespace ProAgilAPI.Data
{
    public class DataContext : DbContext
    {
        readonly DbContextOptions options;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Evento> Eventos { get; set; }
    }
}

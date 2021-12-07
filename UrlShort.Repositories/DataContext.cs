using Microsoft.EntityFrameworkCore;
using UrlShort.Domain.Models;

namespace UrlShort.Repositories
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<UrlEntity> UrlEntities { get; set; }
    }
}
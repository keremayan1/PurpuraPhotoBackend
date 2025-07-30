using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Context
{
    public class SQLContext : DbContext
    {
        public DbSet<AlbumStatus> AlbumStatus { get; set; }
        public DbSet<Album> Album { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=192.168.1.104,1433;Initial Catalog=PurpuraPhoto;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=C.ilme.124;Trust Server Certificate=True");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}

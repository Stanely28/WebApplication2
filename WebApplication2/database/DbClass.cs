using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using WebApplication2.Models;

namespace WebApplication2.database
{
    public class DbClass :DbContext
    {
        public DbClass(DbContextOptions<DbClass>options):base(options)
        {
    }
        public DbSet<Catorgory> Catorgory { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catorgory>().HasData(
                new Catorgory { Id = 1, Name = "Stanely", DisplayOrder = 1 },
                 new Catorgory { Id = 2, Name = "nf", DisplayOrder = 2 },
                 new Catorgory { Id = 3, Name = "67", DisplayOrder = 3 }
                );
        }
    }
}

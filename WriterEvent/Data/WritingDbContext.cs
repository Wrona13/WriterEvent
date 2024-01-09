using Azure;
using Microsoft.EntityFrameworkCore;
using WriterEvent.Models.Domain;
using WriterEvent.Tables.Domain;

namespace WriterEvent.Data
{
    public class WritingDbContext : DbContext
    {
        public WritingDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Story> Story { get; set; }
        public DbSet<Ship> Ships { get; set; }

        public DbSet<Warning> Warnings { get; set; }
    }
}

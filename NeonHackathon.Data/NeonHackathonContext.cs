using Microsoft.EntityFrameworkCore;
using NeonHackathon.Domain.Entities;

namespace NeonHackathon.Data
{
    public class NeonHackathonContext : DbContext
    {
        public DbSet<Comment> Comment { get; set;}
        public NeonHackathonContext(DbContextOptions<NeonHackathonContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

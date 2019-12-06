using Microsoft.EntityFrameworkCore;

namespace NeonHackathon.Data
{
    public class NeonHackathonContext : DbContext
    {
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

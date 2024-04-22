using golf_scorecard.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace golf_scorecard.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Hole> Hole { get; set; }
        public DbSet<SlopeRating> SlopeRating { get; set; }
        public DbSet<Tee> Tee { get; set; }
    }
}

using golf_scorecard.Models;
using Microsoft.EntityFrameworkCore;

namespace golf_scorecard.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Course> Course { get; set; }
        public DbSet<Gender> Gender { get; set; }
        public DbSet<Hole> Hole { get; set; }
        public DbSet<SlopeRating> SlopeRating { get; set; }
        public DbSet<Tee> Tee { get; set; }
    }
}

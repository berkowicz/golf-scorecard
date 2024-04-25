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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tee>().HasData(new Tee[] {
                    new Tee{Id = 1, Type = "Yellow"},
                    new Tee{Id = 2, Type = "Red"}
            });

            modelBuilder.Entity<Gender>().HasData(new Gender[] {
                    new Gender{Id = 1, Type = "Man"},
                    new Gender{Id = 2, Type = "Woman"}
            });

            modelBuilder.Entity<Course>().HasData(new Course[] {
                    new Course{Id = 1, Name = "Nacka GK"}
            });

            modelBuilder.Entity<Hole>().HasData(new Hole[] {
                    new Hole{Id = 1, CourseRefId = 1, Number = 1, Par = 4, HoleIndex = 10},
                    new Hole{Id = 2, CourseRefId = 1, Number = 2, Par = 3, HoleIndex = 6},
                    new Hole{Id = 3, CourseRefId = 1, Number = 3, Par = 5, HoleIndex = 14},
                    new Hole{Id = 4, CourseRefId = 1, Number = 4, Par = 4, HoleIndex = 4},
                    new Hole{Id = 5, CourseRefId = 1, Number = 5, Par = 5, HoleIndex = 8},
                    new Hole{Id = 6, CourseRefId = 1, Number = 6, Par = 3, HoleIndex = 18},
                    new Hole{Id = 7, CourseRefId = 1, Number = 7, Par = 4, HoleIndex = 2},
                    new Hole{Id = 8, CourseRefId = 1, Number = 8, Par = 4, HoleIndex = 16},
                    new Hole{Id = 9, CourseRefId = 1, Number = 9, Par = 3, HoleIndex = 12},
                    new Hole{Id = 10, CourseRefId = 1, Number = 10, Par = 4, HoleIndex = 11},
                    new Hole{Id = 11, CourseRefId = 1, Number = 11, Par = 5, HoleIndex = 13},
                    new Hole{Id = 12, CourseRefId = 1, Number = 12, Par = 4, HoleIndex = 3},
                    new Hole{Id = 13, CourseRefId = 1, Number = 13, Par = 3, HoleIndex = 9},
                    new Hole{Id = 14, CourseRefId = 1, Number = 14, Par = 4, HoleIndex = 1},
                    new Hole{Id = 15, CourseRefId = 1, Number = 15, Par = 4, HoleIndex = 17},
                    new Hole{Id = 16, CourseRefId = 1, Number = 16, Par = 3, HoleIndex = 15},
                    new Hole{Id = 17, CourseRefId = 1, Number = 17, Par = 5, HoleIndex = 5},
                    new Hole{Id = 18, CourseRefId = 1, Number = 18, Par = 4, HoleIndex = 7},
            });

            modelBuilder.Entity<SlopeRating>().HasData(new SlopeRating[] {
                    new SlopeRating{Id = 1, Info = "Nacka Yellow Man",
                        CourseRefId = 1, GenderRefId = 1, TeeRefId = 1,
                        CR = 69f, Slope = 124f, ScratchValue = -2f},

                    new SlopeRating{Id = 2, Info = "Nacka Red Man",
                        CourseRefId = 1, GenderRefId = 1, TeeRefId = 2,
                        CR = 65.3f, Slope = 117f, ScratchValue = -5.7f},

                    new SlopeRating{Id = 3, Info = "Nacka Yellow Woman",
                        CourseRefId = 1, GenderRefId =2, TeeRefId = 1,
                        CR = 74.5f, Slope = 131f, ScratchValue = 3.5f},

                    new SlopeRating{Id = 4, Info = "Nacka Red Woman",
                        CourseRefId = 1, GenderRefId = 2, TeeRefId = 2,
                        CR = 70f, Slope = 122f, ScratchValue = -1f}
            });
        }
    }


}

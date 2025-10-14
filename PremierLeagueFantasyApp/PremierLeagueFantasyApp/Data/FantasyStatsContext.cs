using Microsoft.EntityFrameworkCore;
using PremierLeagueFantasyApp.Models; // Import the Player model

namespace PremierLeagueFantasyApp.Data
{
    /// <summary>
    /// The database context class, which manages the connection and model-to-table mapping.
    /// It inherits from DbContext and is configured in Program.cs.
    /// </summary>
    public class FantasyStatsContext : DbContext
    {
        // Constructor for dependency injection. 
        // This is where the database connection options are passed in.
        public FantasyStatsContext(DbContextOptions<FantasyStatsContext> options)
            : base(options)
        {
        }

        // DbSet property maps the Player model to a database table named 'Players'.
        public DbSet<Player> Players { get; set; }

        /// <summary>
        /// Used to configure the models, including seeding initial data.
        /// The data provided here will be inserted into the database when the migration runs.
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(entity =>
            {
                // Explicitly configure precision/scale for the Price decimal property.
                // Change (5,2) to whatever precision/scale you need — e.g. (4,1) if you only need one decimal place.
                entity.Property(p => p.Price).HasPrecision(5, 2);

                // Seed data (unchanged)
                entity.HasData(
                    new Player { Id = 1, Name = "Haaland", Team = "MCI", Position = "Forward", Goals = 27, Assists = 5, CleanSheets = 0, TotalPoints = 250, Price = 14.0m },
                    new Player { Id = 2, Name = "Salah", Team = "LIV", Position = "Midfielder", Goals = 18, Assists = 12, CleanSheets = 0, TotalPoints = 230, Price = 13.0m },
                    new Player { Id = 3, Name = "Trippier", Team = "NEW", Position = "Defender", Goals = 1, Assists = 10, CleanSheets = 15, TotalPoints = 200, Price = 6.5m },
                    new Player { Id = 4, Name = "Saka", Team = "ARS", Position = "Midfielder", Goals = 14, Assists = 10, CleanSheets = 0, TotalPoints = 210, Price = 9.0m }
                );
            });
        }
    }
}


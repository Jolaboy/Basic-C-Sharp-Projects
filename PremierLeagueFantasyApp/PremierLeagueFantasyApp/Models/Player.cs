using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PremierLeagueFantasyApp.Models
{
    /// <summary>
    /// Represents a single Premier League player and their fantasy football statistics.
    /// This model is the basis for the database table (Code-First approach).
    /// </summary>
    public class Player
    {
        // Primary Key (EF Core automatically sets this as Identity/Primary Key)
        [Key]
        public int Id { get; set; }

        // Player identification details
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string Team { get; set; }

        public required string Position { get; set; }

        // Core Fantasy Football Stats
        public required int Goals { get; set; }
        public required int Assists { get; set; }
        public required int CleanSheets { get; set; } // Relevant for defenders/goalkeepers
        public int TotalPoints { get; set; }

        // Set precision using attribute (EF Core 6+ supports this)
        [Precision(5, 2)]
        public decimal Price { get; set; } // Player price in fantasy units (e.g., millions)
    }
}

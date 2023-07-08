using Microsoft.EntityFrameworkCore;

namespace FitnessTracker.Data
{
    public class FitnessTrackerContext : DbContext
    {
        public FitnessTrackerContext(DbContextOptions<FitnessTrackerContext> options)
            : base(options)
        {
        }

        // Add DbSet properties for your models
        public DbSet<FitnessEntry> FitnessEntries { get; set; }
    }
}

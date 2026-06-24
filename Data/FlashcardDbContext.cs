using Flashcard.Models;
using Microsoft.EntityFrameworkCore;

namespace Flashcard.Data
{
    public class FlashcardDbContext : DbContext
    {
        public DbSet<HskLevel> HskLevels { get; set; }
        public DbSet<Word> Words { get; set; }

        public FlashcardDbContext(DbContextOptions<FlashcardDbContext> options) : base(options)
        {

        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}

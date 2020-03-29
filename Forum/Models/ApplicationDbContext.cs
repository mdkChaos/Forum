using Microsoft.EntityFrameworkCore;

namespace Forum.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Theme> Themes { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}

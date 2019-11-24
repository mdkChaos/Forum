using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Forum.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ApplicationDbContext context = application.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Themes.Any())
            {
                context.Themes.AddRange(
                    new Theme { Name = "Test Theme number 1" },
                    new Theme { Name = "Test Theme number 2" },
                    new Theme { Name = "Test Theme number 3" },
                    new Theme { Name = "Test Theme number 4" },
                    new Theme { Name = "Test Theme number 5" },
                    new Theme { Name = "Test Theme number 6" }
                );
            }
            context.SaveChanges();
        }
    }
}

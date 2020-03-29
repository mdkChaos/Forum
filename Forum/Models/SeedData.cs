using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace Forum.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder application)
        {
            ApplicationDbContext context = application.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            Theme theme1 = new Theme { Name = "Test Theme number 1" };
            Theme theme2 = new Theme { Name = "Test Theme number 2" };
            Theme theme3 = new Theme { Name = "Test Theme number 3" };
            Theme theme4 = new Theme { Name = "Test Theme number 4" };
            Theme theme5 = new Theme { Name = "Test Theme number 5" };
            if (!context.Themes.Any())
            {
                context.Themes.AddRange(
                    theme1,
                    theme2,
                    theme3,
                    theme4,
                    theme5
                );
            }

            if (!context.Topics.Any())
            {
                context.Topics.AddRange(
                    new Topic { Title = "Test Topic number 1", Body = "Theme 1", Theme = theme1, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 2", Body = "Theme 1", Theme = theme1, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 3", Body = "Theme 2", Theme = theme2, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 4", Body = "Theme 2", Theme = theme2, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 5", Body = "Theme 3", Theme = theme3, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 6", Body = "Theme 4", Theme = theme4, Time = DateTime.Now },
                    new Topic { Title = "Test Topic number 7", Body = "Theme 5", Theme = theme5, Time = DateTime.Now }
                );
            }
            context.SaveChanges();
        }
    }
}

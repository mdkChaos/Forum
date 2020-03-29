using Forum.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Models
{
    public class EFThemeRepository : IThemeRepository
    {
        private ApplicationDbContext context;
        public EFThemeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IQueryable<Theme> Themes => context.Themes;

        public async Task SaveThemeAsync(Theme theme)
        {
            if (theme.ThemeId == 0)
            {
                await context.Themes.AddAsync(theme);
            }
            else
            {
                Theme dbEntry = context.Themes
                    .FirstOrDefault(p => p.ThemeId == theme.ThemeId);
                if (dbEntry != null)
                {
                    dbEntry.Name = theme.Name;
                }
            }
            await context.SaveChangesAsync();
        }

        public async Task<Theme> DeleteThemeAsync(int themeId)
        {
            Theme dbEntry = context.Themes
                .FirstOrDefault(p => p.ThemeId == themeId);
            if (dbEntry != null)
            {
                context.Themes.Remove(dbEntry);
                await context.SaveChangesAsync();
            }
            return dbEntry;
        }
    }
}

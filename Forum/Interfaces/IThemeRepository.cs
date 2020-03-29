using Forum.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Interfaces
{
    public interface IThemeRepository
    {
        IQueryable<Theme> Themes { get; }
        Task SaveThemeAsync(Theme theme);
        Task<Theme> DeleteThemeAsync(int themeId);
    }
}

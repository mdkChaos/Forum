using Forum.Models;
using System.Linq;

namespace Forum.Interfaces
{
    public interface IThemeRepository
    {
        IQueryable<Theme> Themes { get; }
    }
}

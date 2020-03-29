using Forum.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Forum.Models
{
    public class FakeThemeRepository// : IThemeRepository
    {
        public IQueryable<Theme> Themes => new List<Theme>
        {
            new Theme { Name = "Theme 1" },
            new Theme { Name = "Theme 2" },
            new Theme { Name = "Theme 3" },
            new Theme { Name = "Theme 4" }
        }.AsQueryable<Theme>();
    }
}

using Forum.Interfaces;
using System;
using System.Collections.Generic;
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
    }
}

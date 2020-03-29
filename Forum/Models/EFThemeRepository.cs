﻿using Forum.Interfaces;
using System.Linq;

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

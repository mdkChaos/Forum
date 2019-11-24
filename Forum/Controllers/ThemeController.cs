using Forum.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class ThemeController : Controller
    {
        private IThemeRepository repository;
        public ThemeController(IThemeRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult List() => View(repository.Themes);
    }
}

using Forum.Interfaces;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class AdminController : Controller
    {
        private IThemeRepository themeRepository;
        private ITopicRepository topicRepository;

        public AdminController(IThemeRepository themeRepository, ITopicRepository topicRepository)
        {
            this.themeRepository = themeRepository;
            this.topicRepository = topicRepository;
        }

        public IActionResult IndexTheme() => View(themeRepository.Themes);

        public IActionResult EditTheme(int themeId) => View(themeRepository.Themes.FirstOrDefault(th => th.ThemeId == themeId));

        [HttpPost]
        public async Task<IActionResult> EditTheme(Theme theme)
        {
            if (ModelState.IsValid)
            {
                await themeRepository.SaveThemeAsync(theme);
                TempData["message"] = $"Тема \"{theme.Name}\" была создана";
                return RedirectToAction("IndexTheme");
            }
            else
            {
                return View(theme);
            }
        }

        public IActionResult CreateTheme() => View("EditTheme", new Theme());

        [HttpPost]
        public IActionResult DeleteTheme(int themeId)
        {
            Theme deletedTheme = themeRepository.DeleteThemeAsync(themeId).Result;
            if (deletedTheme != null)
            {
                TempData["message"] = $"Тема \"{deletedTheme.Name}\" была удалёна";
            }
            return RedirectToAction("IndexTheme");
        }


    }
}

using Forum.Interfaces;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class ThemeController : Controller
    {
        private IThemeRepository themeRepository;
        private ITopicRepository topicRepository;
        public ThemeController(IThemeRepository themeRepository, ITopicRepository topicRepository)
        {
            this.themeRepository = themeRepository;
            this.topicRepository = topicRepository;
        }

        public IActionResult List() => View(themeRepository.Themes);

        public IActionResult ListTopics(int themeId)
        {
            return View(topicRepository.Topics.Where(x => x.Theme.ThemeId == themeId));
        }
    }
}

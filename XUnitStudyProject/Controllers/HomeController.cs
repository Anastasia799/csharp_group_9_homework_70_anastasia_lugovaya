using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using XUnitStudyProject.Models;

namespace XUnitStudyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Добрый день, это тестовый текст на главной странице";
            var home = new IndexViewModel
            {
                ViewName = "Main"
            };
            return View(home);
        }

        public IActionResult Privacy()
        {
            ViewData["Policy"] = "Текст политики конфидециальности сайта.";
            var home = new IndexViewModel
            {
                ViewName = "Privacy"
            };
            return View($"{home.ViewName}");
        }

        public IActionResult TestPage(int page)
        {
            ViewBag.PageIncrement = ++page;
            return View(new TestPageViewModel{Page = page});
        }
        
        
    }
}
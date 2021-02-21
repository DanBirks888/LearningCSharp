using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearningCSharp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LearningCSharp.Controllers
{
    public class TechStackController : Controller
    {
        // GET: /<controller>/
        public IActionResult AspDotNet()
        {
            var ts = new TechStack() {
                name = "Java",
                UsedBefore = true,
                Proficiency = 7,
                FavAtrributes = { "IntelliJ", "Themes", "Spring Boot", "Syntax Layout" } };
            return View(ts);
        }
    }
}

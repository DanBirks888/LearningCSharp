using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LearningCSharp.Models;

namespace LearningCSharp.Controllers
{
    public class TechStackController : Controller
    {
        public IActionResult POCODataReturn()
        {
            List<TechStack> ts = new List<TechStack>();

            ts.Add(new TechStack { Name = "Java", UsedBefore = true, Proficiency = 8, FavAtrribute = "Syntax, IntelliJ, Spring Boot" });
            ts.Add(new TechStack { Name = "JavaScript", UsedBefore = true, Proficiency = 7, FavAtrribute = "ES6 Arrow Functions Light Editors" });
            ts.Add(new TechStack { Name = "MongoDB", UsedBefore = true, Proficiency = 6, FavAtrribute = "Faster, NoSQL flexibility, JSON data" });
            ts.Add(new TechStack { Name = "React Native", UsedBefore = true, Proficiency = 5, FavAtrribute = "Quick Layouts, Hooks, Simplified Syntax" });
            ts.Add(new TechStack { Name = "Android Studio", UsedBefore = true, Proficiency = 7, FavAtrribute = "Powerful, Excellent Abstraction, Great Documentation" });

            return View(ts);
      
        }

        public IActionResult PostYourTechStack()
        {
            ViewBag.Message = "Post your favourite Tech Stack!";

            return View();
        }
    }
}

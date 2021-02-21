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
                public IActionResult AspDotNet()
        {
                var java = new TechStack
                {
                    name = "Java",
                    UsedBefore = true,
                    Proficiency = 8,
                    FavAtrributes = {
                        "Spring Boot", 
                        "Syntax Layout",
                        "IntelliJ",
                        "Lambda & Streams!",
                        }
                };
                return View(java);
        }
    }
}

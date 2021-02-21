using System;
using System.Collections.Generic;

namespace LearningCSharp.Models
{
    public class TechStack
    {
        public string name { get; set; }
        public bool UsedBefore { get; set; }
        public int Proficiency { get; set; }
        public List<string> FavAtrributes { get; set; }
    }
}

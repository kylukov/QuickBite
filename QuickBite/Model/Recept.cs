using System;
namespace QuickBite.Model
{
        public class Recept
    {
        public string rTitle { get; set; }
        public string rPath { get; set; }
        public string rDescription { get; set; }

        public Recept()
        {
            rTitle = "demo";
            rPath = "demo";
            rDescription = "demp";

        }
        public Recept(string title, string path, string description)
        {
            rTitle = title;
            rPath = path;
            rDescription = description;
        }
    }
}
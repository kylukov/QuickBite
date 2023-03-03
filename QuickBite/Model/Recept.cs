namespace QuickBite.Model
{
    public class Recept
    {
        public string rTitle { get; set; }
        public string rPath { get; set; }
        public string rDescription { get; set; }
        public int rDuration { get; set; }
        public Recept()
        {
            rTitle = "demo";
            rPath = "demo";
            rDescription = "demp";
            rDuration = 1;

        }
        public Recept(string title, string path, string description, int duration)
        {
            rTitle = title;
            rPath = path;
            rDescription = description;
            rDuration = duration;
        }
    }
}
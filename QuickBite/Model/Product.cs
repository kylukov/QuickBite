using System;
namespace QuickBite.Model
{
    public class Product
    {
        public string Path { get; set; }
        public string Title { get; set; }

        public Product()
        {
            Title = "demo";
            Path = "demo";

        }
        public Product(string title, string path)
        {
            Title = title;
            Path = path;
        }
    }
}


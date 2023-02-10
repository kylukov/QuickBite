using System;
namespace QuickBite.Model
{
    public class Product
    {
        public string Path { get; set; }
        public string Title { get; set; }
        public int Column { get; set; }
        public int Row { get; set; }

        public Product()
        {
            Title = "demo";
            Path = "demo";
            Column = 0;
            Row = 0;
        }
        public Product(string title, string path, int column, int row)
        {
            Title = title;
            Path = path;
            Column = column;
            Row = row;
        }
    }
}


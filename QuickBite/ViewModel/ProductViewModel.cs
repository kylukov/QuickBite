using QuickBite.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.ViewModel
{
    class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel(string[] products, string[] links)
        {
            Products = new ObservableCollection<Product>();
            for (int i = 0; i < products.GetUpperBound(0) + 1; i++)
            {
                Products.Add(new Model.Product(products[i], links[i]));
            }
        }
    }
}



using QuickBite.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickBite.ViewModel
{
    internal class ProductViewModel
    {
        public ObservableCollection<Product> Products { get; set; }

        public ProductViewModel()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}



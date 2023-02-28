using QuickBite.Model;
using System.Collections.ObjectModel;

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



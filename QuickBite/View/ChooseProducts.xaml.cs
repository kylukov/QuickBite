using QuickBite.ViewModel;
namespace QuickBite;
using System.Collections.ObjectModel;
using System.IO;

public partial class ChooseProducts : ContentPage
{
    public string gett;
    public int amt = 0;
    public ObservableCollection<string> items =
        new();
    readonly string[] products = new string[] { "Яйцо", "Хлеб", "Сливки", "Сыр", "Бекон", "Майонез", "Кутчуп", "Помидор", "Огурец", "Молоко", "Курица", "Говядина", "Свинина" };
    readonly string[] links = new string[]
        { "https://cdn-icons-png.flaticon.com/512/5222/5222963.png",
          "https://cdn-icons-png.flaticon.com/512/3014/3014538.png",
          "https://cdn-icons-png.flaticon.com/512/8008/8008185.png",
          "https://cdn-icons-png.flaticon.com/512/517/517561.png",
          "https://cdn-icons-png.flaticon.com/512/7471/7471954.png",
          "https://cdn-icons-png.flaticon.com/512/4383/4383486.png",
          "https://cdn-icons-png.flaticon.com/512/3387/3387851.png",
          "https://cdn-icons-png.flaticon.com/512/1202/1202125.png",
          "https://cdn-icons-png.flaticon.com/512/7830/7830699.png",
          "https://cdn-icons-png.flaticon.com/512/6070/6070715.png",
          "https://cdn-icons-png.flaticon.com/512/6679/6679109.png",
          "https://cdn-icons-png.flaticon.com/512/1703/1703009.png",
           "pig.png"
        };
    public ChooseProducts()
    {
        
        InitializeComponent();

        BindingContext = new ProductViewModel();

        for (int i = 0; i < products.GetUpperBound(0) + 1; i++)
        {
            ((ProductViewModel)BindingContext).Products.Add(
            new Model.Product(products[i], links[i]));
        }

    }


    private void AddToShoppingList(object sender, EventArgs e)
    {
        items.Add((sender as Button).Text);
        Console.WriteLine((sender as Button).Text);
    }

    private async void GotoShoppingList(object sendet, EventArgs e)
    {
        
        await Shell.Current.GoToAsync("ShoppingList");
    }
}

using QuickBite.ViewModel;
namespace QuickBite;
using System.Collections.ObjectModel;

public partial class ChooseProducts : ContentPage
{
    public string gett;
    public int amt = 0;
    public ObservableCollection<string> items =
        new ObservableCollection<string>();
    public ChooseProducts()
    {
        string[,] products = new string[,]
        {
            {"Яйцо", "https://cdn-icons-png.flaticon.com/512/5222/5222963.png" },
            {"Хлеб", "https://cdn-icons-png.flaticon.com/512/3014/3014538.png" },
            {"Сливки", "https://cdn-icons-png.flaticon.com/512/8008/8008185.png" },
            {"Сыр","https://cdn-icons-png.flaticon.com/512/517/517561.png" },
            {"Бекон", "https://cdn-icons-png.flaticon.com/512/7471/7471954.png" },
            {"Майонез", "https://cdn-icons-png.flaticon.com/512/4383/4383486.png" },
            {"Кутчуп", "https://cdn-icons-png.flaticon.com/512/3387/3387851.png" },
            {"Помидор", "https://cdn-icons-png.flaticon.com/512/1202/1202125.png" },
            {"Огурец", "https://cdn-icons-png.flaticon.com/512/7830/7830699.png" },
            {"Молоко", "https://cdn-icons-png.flaticon.com/512/6070/6070715.png" },
            {"Курица", "https://cdn-icons-png.flaticon.com/512/6679/6679109.png" },
            {"Говядина", "https://cdn-icons-png.flaticon.com/512/1703/1703009.png" },
            {"Свинина", "pig.png" }
        };
        InitializeComponent();

        BindingContext = new ProductViewModel();

        for (int i = 0; i < products.GetUpperBound(0) + 1; i++)
        {
            ((ProductViewModel)BindingContext).Products.Add(
            new Model.Product(products[i, 0], products[i, 1]));
        }

    }
    /*
    private async void GoToShoppingList(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ShoppingList");
    }
    */

    private void AddToShoppingList(object sender, EventArgs e)
    {
        items.Add((sender as Button).Text);

        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("========================");
    }

    private async void GotoShoppingList(object sendet, EventArgs e)
    {
        await Shell.Current.GoToAsync("ShoppingList");
    }


}

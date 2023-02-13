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
            {"Яйцо", "egg.png" },
            {"Хлеб", "bread.png" },
            {"Сливки", "slivki.png" },
            {"Сыр","cheese.png" },
            {"Майонез", "mayo.png" },
            {"Кутчуп", "cetchup.png" },
            {"Помидор", "tomato.png" },
            {"Огурец", "cucmber.png" },
            {"Молоко", "milk.png" },
            {"Курица", "chicken.png" },
            {"Говядина", "beef.png" },
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

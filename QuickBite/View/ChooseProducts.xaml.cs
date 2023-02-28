using QuickBite.ViewModel;
namespace QuickBite;
using System.Collections.ObjectModel;
using System.IO;

public partial class ChooseProducts : ContentPage
{
    public ObservableCollection<string> items = new();

    public ChooseProducts()
    {
        InitializeComponent();
        BindingContext = new ProductViewModel();
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

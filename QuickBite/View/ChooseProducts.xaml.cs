using QuickBite.ViewModel;
namespace QuickBite;
using System.Collections.ObjectModel;
using System.IO;
using DataBase;
using Data;

public partial class ChooseProducts : ContentPage
{
    public string sql_input;

    public ChooseProducts()
    {
        InitializeComponent();
        BindingContext = new ProductViewModel();
    }

    private void AddToShoppingList(object sender, EventArgs e)
    {
        Console.WriteLine((sender as Button).Text);
        sql_input += (sender as Button).Text + ",";
        Console.WriteLine(sql_input);
    }

    private async void GotoShoppingList(object sendet, EventArgs e)
    {
        Console.WriteLine(sql_input.Substring(0, sql_input.Length - 1));
        // await Shell.Current.GoToAsync("ShoppingList");
        // Data.Database db = new Database();
        // Datab.find_receipt(sql_input.Substring(0, sql_input.Length-1));
    }
}

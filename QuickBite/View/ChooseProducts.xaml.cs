using QuickBite.ViewModel;
namespace QuickBite;


public partial class ChooseProducts : ContentPage
{
    public string gett;
    public int amt;
    public ChooseProducts()
    {
        string[,] products = new string[,]
        {
            {"Яйцо", "egg.png" },
            {"Хлеб", "bread.png" },
            {"Сливки", "slivki.png" },
            {"Сыр","cheese.png" },
            {"Майонез", "mayo.png" },
            {"Кетчуп", "cetchup.png" },
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
    private async void DigitClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ShoppingList");
    }


}

using QuickBite.ViewModel;
namespace QuickBite;


public partial class ChooseProducts : ContentPage
{
    public string gett;
    public ChooseProducts()
    {
        string[,] products = new string[,]
        {
            {"Яйцо", "egg.png" },
            {"Хлеб", "bread.png" },
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
        int row = 0;
        for (int i = 0; i < products.GetUpperBound(0) + 1; i++)
        {
            if (i % 2 == 0 && i != 0)
                row++;
            Console.WriteLine(row);
            ((ProductViewModel)BindingContext).Products.Add(
            new Model.Product(products[i, 0], products[i, 1], (i + 1) % 2, row));

        }
    }

    private void DigitClicked(object sender, EventArgs e)
    {
        gett += (sender as Button).Text;
        Console.Write(gett);
    }
}

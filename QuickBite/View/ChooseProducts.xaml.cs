using QuickBite.DataBase;
using QuickBite.ViewModel;
namespace QuickBite;
public partial class ChooseProducts : ContentPage
{
    public string sql_input;
    readonly string[] products = new string[] { "Яйцa", "Хлеб", "Сливки", "Сыр", "Бекон", "Майонез", "Кутчуп", "Помидор", "Огурец", "Молоко", "Курица", "Говядина", "Свинина" };
    readonly string[] links = new string[] { "https://cdn-icons-png.flaticon.com/512/5222/5222963.png", "https://cdn-icons-png.flaticon.com/512/3014/3014538.png", "https://cdn-icons-png.flaticon.com/512/8008/8008185.png", "https://cdn-icons-png.flaticon.com/512/517/517561.png", "https://cdn-icons-png.flaticon.com/512/7471/7471954.png", "https://cdn-icons-png.flaticon.com/512/4383/4383486.png", "https://cdn-icons-png.flaticon.com/512/3387/3387851.png", "https://cdn-icons-png.flaticon.com/512/1202/1202125.png", "https://cdn-icons-png.flaticon.com/512/7830/7830699.png", "https://cdn-icons-png.flaticon.com/512/6070/6070715.png", "https://cdn-icons-png.flaticon.com/512/6679/6679109.png", "https://cdn-icons-png.flaticon.com/512/1703/1703009.png", "pig.png" };

    public ChooseProducts()
    {
        InitializeComponent();
        BindingContext = new ProductViewModel(products, links);
    }

    private void AddToShoppingList(object sender, EventArgs e)
    {
        Console.WriteLine((sender as Button).Text);
        sql_input += (sender as Button).Text + ",";
        Console.WriteLine(sql_input);
    }

    private void GotoShoppingList(object sendet, EventArgs e)
    {
        Console.WriteLine(sql_input.Substring(0, sql_input.Length - 1));

        // Data.Database db = new Data.Database();
        // Datab.find_receipt(sql_input.Substring(0, sql_input.Length - 1));
    }
}

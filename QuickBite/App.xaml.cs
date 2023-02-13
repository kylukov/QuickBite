using QuickBite;

namespace QuickBite;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Routing.RegisterRoute("ChooseProducts", typeof(ChooseProducts));
        Routing.RegisterRoute("ShoppingList", typeof(ShoppingList));
        Routing.RegisterRoute("ReceptPage", typeof(ReceptPage));
        MainPage = new AppShell();
    }
}

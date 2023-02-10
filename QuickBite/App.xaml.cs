using QuickBite;

namespace QuickBite;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        Routing.RegisterRoute("ChooseProducts", typeof(ChooseProducts));
        MainPage = new AppShell();
    }
}

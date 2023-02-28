using QuickBite.ViewModel;

namespace QuickBite;

public partial class MainPage : ContentPage
{
    public MainPage()
    {

        InitializeComponent();

        string[,] most_popular = new string[,]
        {
            {"Яичница", "omlet.png", "hello"},
            {"Курица в сливках", "slivkichicken.png", "hello"},
            {"Яйца Кокот", "omlet.png", "hello"},
            {"Яичнца", "omlet.png", "hello"},
            {"Яичнца", "omlet.png", "hello"},
            {"Яичнца", "omlet.png", "hello"},

        };
        BindingContext = new ReceptViewModel(most_popular);


    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ChooseProducts");
    }

    private async void ShowDescription(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("ReceptPage");
    }
}


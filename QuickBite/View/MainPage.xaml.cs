using QuickBite.ViewModel;

namespace QuickBite;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        string[,] most_popular = new string[,]
        {
            {"Яичнца", "omlet.png", "hello"},
            {"Яичнца", "omlet.png", "hello"},
            {"Яичнца", "omlet.png", "hello"},

        };
        BindingContext = new ReceptViewModel();
        for (int i = 0; i < most_popular.GetUpperBound(0) + 1; i++)
        {
            ((ReceptViewModel)BindingContext).Recepts.Add(
            new Model.Recept(most_popular[i, 0], most_popular[i, 1], most_popular[i, 2]));
        }
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ChooseProducts");
    }
}


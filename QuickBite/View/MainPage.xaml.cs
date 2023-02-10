using QuickBite.ViewModel;

namespace QuickBite;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        BindingContext = new ReceptViewModel();

        ((ReceptViewModel)BindingContext).Recepts.Add(new Model.Recept("яичница", "egg.png", "hello"));
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ChooseProducts");
    }
}


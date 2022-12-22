namespace Notes.ViewModel;

public partial class MenuPage : ContentPage
{
    public MenuPage()
    {
        InitializeComponent();
    }

    private async void Form_create(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FormPage());
        
    }
}
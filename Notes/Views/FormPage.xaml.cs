namespace Notes.Views;

public partial class FormPage : ContentPage
{
	public FormPage()
	{
		InitializeComponent();
	}
    


    private async void Save_form(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(".."); // Return after the button clicked 
    }
}
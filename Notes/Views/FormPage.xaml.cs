namespace Notes.Views;

public partial class FormPage : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public FormPage()
	{
		InitializeComponent();
	}
    


    private async void Save_form(object sender, EventArgs e)
    {
        
        await Shell.Current.GoToAsync(".."); // Return after the button clicked 
    }
}
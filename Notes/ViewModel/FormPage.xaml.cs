using System.Text.Json;

namespace Notes.ViewModel;

public partial class FormPage : ContentPage
{
   // string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public FormPage()
	{
		InitializeComponent();
	}
    


    private async void Save_form(object sender, EventArgs e)
    {   //Initialize type Form Model
        var form = new Models.Form { Name = Name.Text, Surname = Surname.Text , Age = Age.Text = Address.Text};

        string formJson = JsonSerializer.Serialize(form);

        Models.Form deserializedForm = JsonSerializer.Deserialize<Models.Form>(formJson); 

        List<Models.Form> lista = new List<Models.Form>();
        lista.Add(deserializedForm);

        await Shell.Current.GoToAsync(".."); // Return after the button clicked 
    }
}
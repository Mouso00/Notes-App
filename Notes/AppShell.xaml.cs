namespace Notes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(ViewModel.NotePage), typeof(ViewModel.NotePage));

    }
}

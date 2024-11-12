namespace MAUIStar;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		GoToAsync("//PhotosListPage");
	}
}

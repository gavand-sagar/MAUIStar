using MAUIStar.Views;

namespace MAUIStar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new PhotosListPage(); //new NavigationPage(new DashboardPage());

    }
}

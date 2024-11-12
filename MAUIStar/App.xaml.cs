using MAUIStar.Views;

namespace MAUIStar;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ProductListPage(); //new NavigationPage(new DashboardPage());

    }
}

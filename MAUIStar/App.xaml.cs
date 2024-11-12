using MAUIStar.Views;

namespace MAUIStar;

public partial class App : Application
{
	public App(AppShell appShell)
	{
		InitializeComponent();

		MainPage = appShell;

    }
}

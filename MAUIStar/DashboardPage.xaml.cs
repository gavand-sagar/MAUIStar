namespace MAUIStar;

public partial class DashboardPage : ContentPage
{
	public DashboardPage()
	{
		InitializeComponent();
	}

    private void ProfileClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MyProfilePage());
    }
    private void MainPageClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void MyMailsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MyMailsPage());
    }

    private void MyFlyoutClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutDemo());
    }
}
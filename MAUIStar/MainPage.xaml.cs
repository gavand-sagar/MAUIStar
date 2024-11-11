namespace MAUIStar;

public partial class MainPage : ContentPage
{
    int count = 10;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (!agree.IsChecked)
        {
            this.agreeError.IsVisible = true;
            return;
        }
        else
        {
            this.agreeError.IsVisible = false;
        }
        if (password.Text != retypePassword.Text)
        {
            this.passwordError.IsVisible = true;
            return;
        }
        else
        {
            this.passwordError.IsVisible = false;
        }

        Person p = new Person(); ;
        p.FirstName = firstName.Text;
        p.LastName = lastName.Text;
        //p.City = (string)city.SelectedItem;
        p.Email = email.Text;
        p.DOB = dob.Date;
        p.Password = password.Text;
        // send it to api server
    }


}


namespace MAUIStar;

public partial class UserInformation : ContentView
{
    public static BindableProperty UsernameProperty = BindableProperty.Create(
        propertyName: nameof(Username),
        returnType: typeof(string),
        defaultValue: string.Empty,
        declaringType: typeof(UserInformation),
        propertyChanged: MyUsernameChanged
        );

    private static void MyUsernameChanged(BindableObject bindable, object oldValue, object newValue)
    {
        UserInformation currentInstance = (UserInformation)bindable;
        currentInstance.label.Text = (string)newValue;
    }

    public string Username { get { return (string)GetValue(UsernameProperty); } set { SetValue(UsernameProperty, value); } }




    public string Email{ get; set; }

    public static BindableProperty EmailProperty = BindableProperty.Create(
        propertyName: nameof(Email),
        returnType: typeof(string),
        defaultValue: string.Empty,
        declaringType: typeof(UserInformation),
        propertyChanged: MyEmailChanged
        );

    private static void MyEmailChanged(BindableObject bindable, object oldValue, object newValue)
    {
        UserInformation u = (UserInformation) bindable;
        u.emailLabel.Text = (string)newValue;
    }

    public UserInformation()
    {
        InitializeComponent();
    }
}
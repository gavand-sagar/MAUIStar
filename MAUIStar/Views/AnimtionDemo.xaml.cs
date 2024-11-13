namespace MAUIStar.Views;

public partial class AnimtionDemo : ContentPage
{
    public AnimtionDemo()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        startAnim();

    }
    private void startAnim()
    {
        var animation = new Animation();

        animation.Add(0, 1, new Animation(v => label.Rotation = v, 0, 360));

        animation.Commit(this, "Slide", 16, 500, finished: (x, y) => startAnim());
    }
}
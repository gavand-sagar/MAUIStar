using MAUIStar.ViewModels;

namespace MAUIStar.Views;

public partial class ProductListPage : ContentPage
{
    public ProductListPage()
    {
        InitializeComponent();
    }

    private void CollectionView_Scrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        var temmp = (ProductListPageViewModel)BindingContext;
        if ((temmp.ProductsList.Count - 1) == e.LastVisibleItemIndex)
        {
            temmp.NextCommand.Execute(null);
        }

    }
}
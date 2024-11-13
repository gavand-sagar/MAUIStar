using MAUIStar.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public class NavigationService : INavigationService
    {
        public Task GotoAsync(string url)
        {
           return Shell.Current.GoToAsync(url);
        }

        public Task NavigateBack()
        {
            return Shell.Current.Navigation.PopAsync();
        }

        public Task PushNavigation(ContentPage page)
        {
            return Shell.Current.Navigation.PushAsync(page);
        }

        public Task PushNavigationProducts()
        {
            return Shell.Current.Navigation.PushAsync(new ProductListPage());
        }

        public Task NavigateToRoot()
        {
            return Shell.Current.GoToAsync("//");
        }
    }
}

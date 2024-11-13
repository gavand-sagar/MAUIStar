using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public interface INavigationService
    {
        Task GotoAsync(string url);
        Task NavigateBack();
        Task PushNavigation(ContentPage page);
        Task NavigateToRoot();
    }
}

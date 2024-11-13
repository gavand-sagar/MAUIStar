using MAUIStar.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public class ViewModelLocator
    {
        public static MauiApp App;
        public ProductListPageViewModel ProductListPageViewModel => App.Services.GetService<ProductListPageViewModel>();
        public PhotosListViewModel PhotosListViewModel => App.Services.GetService<PhotosListViewModel>();
        public DependencyDemoPageViewModel DependencyDemoPageViewModel => App.Services.GetService<DependencyDemoPageViewModel>();
        public LoginPageViewModel LoginPageViewModel => App.Services.GetService<LoginPageViewModel>();
    }
}

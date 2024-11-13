using MAUIStar.Models;
using MAUIStar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIStar.ViewModels
{
    public class LoginPageViewModel : BaseViewModel
    {
        IDialogService _dialogService;
        INavigationService _navigationService;
        IMyStorageService _storageService;
        public UserModel User { get; set; }
        public ICommand LoginCommand { get; set; }

        public LoginPageViewModel(IDialogService dialogService, INavigationService navigationService, IMyStorageService storageService)
        {
            _storageService = storageService;
            _dialogService = dialogService;
            _navigationService = navigationService;
            User = new UserModel();
            LoginCommand = new CommonCommand(OnLoginClicked);
        }

        private void OnLoginClicked(object obj)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.PostAsJsonAsync("https://tempfileserver.onrender.com/generate-token", User).Result;
                if (result.IsSuccessStatusCode)
                {
                    // store token to secure storage
                    LoginResponse response = result.Content.ReadFromJsonAsync<LoginResponse>().Result;
                    _storageService.SetAuthToken(response.Token);
                    _navigationService.GotoAsync("//ProductListPage");
                }
                else
                {
                    _dialogService.ShowAlert("Login Failed");
                }
            }

        }
    }
}

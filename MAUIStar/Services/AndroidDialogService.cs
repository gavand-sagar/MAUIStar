using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public class AndroidDialogService : IDialogService
    {
        public void ShowAlert(string title, string message, string cancel)
        {
            Shell.Current.DisplayAlert(title, message, cancel);
        }

        public void ShowAlert(string title, string message)
        {
            ShowAlert(title, message, "OK");
        }

        public void ShowAlert(string message)
        {
            ShowAlert("Alert FROM ANDROID", message, "OK");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar.Services
{
    public interface IDialogService
    {
        void ShowAlert(string title, string message, string cancel);
        void ShowAlert(string title, string message);
        void ShowAlert(string message);
    }
}

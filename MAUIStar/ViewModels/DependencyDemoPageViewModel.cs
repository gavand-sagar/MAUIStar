using MAUIStar.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIStar.ViewModels
{
    public class DependencyDemoPageViewModel
    {
        IDialogService _dialogService;
        public ICommand ShowAlertCommand { get; set; }
        public DependencyDemoPageViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            ShowAlertCommand = new CommonCommand(OnShowAlert);
        }

        private void OnShowAlert(object obj)
        {
            _dialogService.ShowAlert("Worked 😊");
        }
    }
}

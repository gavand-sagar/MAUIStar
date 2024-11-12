using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MAUIStar.ViewModels
{



    public class SimpleCalculatorViewModel : BaseViewModel
    {

        public Person PersonObj { get; set; }

        //public bool FirstNameErrorVisible { get; set; }
        private bool _firstNameErrorVisible;
        public bool FirstNameErrorVisible
        {
            get { return _firstNameErrorVisible; }
            set
            {
                FirstNameErrorVisible = value;
                RaiseProperyChanged(nameof(FirstNameErrorVisible));
            }
        }

        public ICommand SaveCommand { get; set; }
        public ICommand CancelCommand { get; set; }

        public SimpleCalculatorViewModel()
        {
            this.PersonObj = new Person();
            SaveCommand = new CommonCommand(ExecuteSave);
            CancelCommand = new CommonCommand(ExecuteCancel);
        }

        private void ExecuteSave(object parameter)
        {
            //
            Person p = this.PersonObj;

        }


        private void ExecuteCancel(object obj)
        {

        }



    }
}

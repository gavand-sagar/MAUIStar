using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar
{
    public class UppperCaseBehaviour : Behavior<Entry>
    {
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += MyExtraLogic;
        }

        private void MyExtraLogic(object sender, TextChangedEventArgs e)
        {
            Entry entry= (Entry)sender;
            entry.Text = entry.Text.ToUpper();
            if(entry.Text.Length > 10)
            {
                entry.TextColor = Colors.Red;
            }
            else
            {
                entry.TextColor = Colors.White;
            }
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= MyExtraLogic;
        }
    }
}

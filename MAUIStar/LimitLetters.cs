using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar
{
    public class LimitLetters : Behavior<Entry>
    {
        public int Max { get; set; }

        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += TextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= TextChanged;
        }

        private void TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry bindable = (Entry)sender;
            if(bindable.Text.Length > Max)
            {
                bindable.Text = bindable.Text.Substring(0, Max);
            }
        }
    }
}

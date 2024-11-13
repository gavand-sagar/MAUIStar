using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIStar
{
    public class CustomeEntryHandler : EntryHandler
    {
#if WINDOWS
        protected override void ConnectHandler(Microsoft.UI.Xaml.Controls.TextBox nativeWindowsElement)
        {
            base.ConnectHandler(nativeWindowsElement);
            nativeWindowsElement.BorderBrush = new Microsoft.UI.Xaml.Media.SolidColorBrush(Microsoft.UI.Colors.Red);
        }
#endif
    }
}

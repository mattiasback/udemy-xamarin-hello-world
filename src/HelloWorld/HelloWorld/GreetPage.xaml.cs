using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            GreetSlider.Value = 0;

            //Explicit
            if (Device.OS == TargetPlatform.iOS)
            {
                Padding = new Thickness(0, 20, 0, 0);
            }
            else if(Device.OS == TargetPlatform.Android)
            {
                Padding = new Thickness(0, 20, 0, 10);
            }

            //Generic
            Device.OnPlatform<Thickness>(
                iOS: new Thickness(0, 20, 0, 0),
                Android: new Thickness(0, 20, 0, 10),
                WinPhone: new Thickness(0, 20, 0, 0)
            );

            //Non-generic
            Device.OnPlatform(
                iOS: () => { Padding = new Thickness(0, 20, 0, 0); },
                Android: () => { Padding = new Thickness(0, 20, 0, 0);}
            );
        }

    }
}
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

            switch (Device.RuntimePlatform) {
                case Device.iOS: {
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                }
                default: {
                    Padding = new Thickness(0, 0, 0, 0);
                    break;
                }
            };
        }
    }

}
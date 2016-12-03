using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrumpTimer
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {

        public MainPage()
        {
            var ads = new AdMobView();
            if (Device.OS == TargetPlatform.WinPhone)
            {
                ads.AdUnitId = "WINDOWS_PHONE_AD_UNIT_ID";
            }

            if (Device.OS == TargetPlatform.Android)
            {
                ads.AdUnitId = "ca-app-pub-5795516931583011/1381279889";
            }

           // this.AdView.Children = { ads };
            
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }


    }
}

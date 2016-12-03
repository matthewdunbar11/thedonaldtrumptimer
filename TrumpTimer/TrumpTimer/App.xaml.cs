using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace TrumpTimer
{
    public partial class App : Application
    {
        public App()
        {
            // create the ads

            this.MainPage = new TrumpTimer.MainPage();
            // include the ads
            /*this.MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new TrumpTimer.MainPage(),
                        ads
                    }
                }
            };*/
        }
 
        protected override void OnStart()
        {
            // Handle when your app starts
        }
 
        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
 
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

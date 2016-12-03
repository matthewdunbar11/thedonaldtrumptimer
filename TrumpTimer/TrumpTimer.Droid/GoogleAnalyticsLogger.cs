using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.Net.Http;
using TrumpTimer.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(GoogleAnalyticsLogger))]
namespace TrumpTimer.Droid
{
    public class GoogleAnalyticsLogger : ILogger
    {
        public GoogleAnalyticsLogger()
        {

        }

        public async void Log(string EventName)
        {
            HttpClient client = new HttpClient();
            
            Uri destinationUri = new Uri($"http://analytics.bloggo.me/piwik.php?idsite=4&rec=1&url=http://localhost&action_name={EventName}&uid{Android.OS.Build.Serial}");

            client.BaseAddress = destinationUri;
            await client.GetAsync(destinationUri);
        }
    }
}
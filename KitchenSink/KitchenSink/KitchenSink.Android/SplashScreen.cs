using Android.App;
using Android.OS;
using System.Threading;
using KitchenSink.Droid;

namespace Splash_Screen
{
   
    [Activity(Label = "Kitchen Sink", MainLauncher = true, Theme = "@style/Theme.Splash", NoHistory = true, Icon = "@drawable/icon")]
    public class SplashScreen : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            Thread.Sleep(100);

            StartActivity(typeof(MainActivity));
        }
    }
}
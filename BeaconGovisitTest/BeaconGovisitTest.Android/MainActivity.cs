using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Shiny;
using Shiny.Beacons;

[assembly: ShinyApplication(
    ShinyStartupTypeName = "BeaconGovisitTest.ShinyTestStartup",
    XamarinFormsAppTypeName = "BeaconGovisitTest.Droid"
)]
namespace BeaconGovisitTest.Droid
{
    [Activity(Label = "BeaconGovisitTest", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public partial class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //var intent = new global::Android.Content.Intent(this, new ShinyBeaconMonitoringService().Class);
            //StartForegroundService(intent);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] global::Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
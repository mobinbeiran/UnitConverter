using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Google.Android.Material.Navigation;
using Java.Util;
using Microsoft.Maui.Controls;

namespace UnitConverter;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        Window.SetNavigationBarColor(Android.Graphics.Color.Rgb(43, 11, 152));
    }
}

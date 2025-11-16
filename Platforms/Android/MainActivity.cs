/*using Android.App;
using Android.Content.PM;
using Android.OS;

namespace mymauiApp;

[Activity(Theme = "@style/Maui.SplashTheme",  Label = "MyApp",
    Icon = "@mipmap/icon",
 MainLauncher = true, LaunchMode = LaunchMode.SingleTop,
  ConfigurationChanges = ConfigChanges.ScreenSize | 
  Android.Content.PM.ConfigChanges.Orientation | ConfigChanges.UiMode | 
  ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
}
*/
using Android.App;
using Android.Content.PM;
using Android.OS;

namespace mymauiApp;

[Activity(
    Theme = "@style/Maui.SplashTheme",
    MainLauncher = true,
    ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize |
                          Android.Content.PM.ConfigChanges.Orientation |
                          Android.Content.PM.ConfigChanges.UiMode |
                          Android.Content.PM.ConfigChanges.ScreenLayout |
                          Android.Content.PM.ConfigChanges.SmallestScreenSize |
                          Android.Content.PM.ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
    }
}

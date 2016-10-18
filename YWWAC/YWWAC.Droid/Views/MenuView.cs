using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Menu", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class MenuView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MenuView);
        }
    }
}

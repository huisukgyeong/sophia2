using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "Community Menu")]
    public class CommunityMenuView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CommunityMenuView);
        }
    }
}
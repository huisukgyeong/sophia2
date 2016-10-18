using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using System.Collections.Generic;
using System;
using Android.OS;
using Android.Views;
using Android.Runtime;
using Android.Content;
using Android.Widget;

namespace YWWAC.Droid.Views
{
    [Activity(Label = "News")]
    public class NewsView : Activity
    {
        int count = 1;
        private List<string> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.NewsView);

            mListView = FindViewById<ListView>(Resource.Id.myListView);

            mItems = new List<string>();
            mItems.Add("bob");
            mItems.Add("Tom");
            mItems.Add("Jim");

            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mItems);
            mListView.Adapter = adapter;


        }
    }
}
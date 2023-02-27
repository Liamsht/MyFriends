using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFriends.Activities
{
    [Activity(Label = "FriendsActivity")]
    public class FriendsActivity : BaseActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_friends);

            //InitViews();
        }

        public override void InitViews()
        {
            throw new NotImplementedException();
        }
    }
}
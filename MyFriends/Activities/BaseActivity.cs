using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFriends.Activities
{
    [Activity(Label = "Activity1")]
    public abstract class BaseActivity : AppCompatActivity
    {
        public abstract void InitViews();
    }
}
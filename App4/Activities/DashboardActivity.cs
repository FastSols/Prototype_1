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
using App4.Activities;
namespace App4.Activities
{
    [Activity(Label = "DashboardActivity")]
    public class DashboardActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Dashboard);
            Button profilebutton = FindViewById<Button>(Resource.Id.profile);
            profilebutton.Click += profileClick;
            void profileClick(Object sender, EventArgs eventArgs)
            {
                var p = new Intent(this, typeof(ProfileActivity));

                StartActivity(p);
            }


            //  Button Ques = FindViewById<Button>(Resource.Id.questiions);
            //  Ques.Click += profileClick;
            // void QuesClick(Object sender, EventArgs eventArgs)
            // {
            //    var p = new Intent(this, typeof(ProfileAcitvity));
            //    StartActivity(p);
            //  }


            // Button Videos = FindViewById<Button>(Resource.Id.videos);
            //   Videos.Click += profileClick;
            //  void VideosClick(Object sender, EventArgs eventArgs)
            //  {
            //      var p = new Intent(this, typeof(ProfileAcitvity));
            //StartActivity(p);
            //}


            //  Button History = FindViewById<Button>(Resource.Id.History);
            //   History.Click += profileClick;
            //   void HistoryClick(Object sender, EventArgs eventArgs)
            //{
            // var p = new Intent(this, typeof(ProfileAcitvity));
            //  StartActivity(p);
            // }


            // Button Subscript = FindViewById<Button>(Resource.Id.Subscription);
            // Subscript.Click += profileClick;
            //  void SubscriptClick(Object sender, EventArgs eventArgs)
            //  {
            //       var p = new Intent(this, typeof(ProfileAcitvity));
            //     StartActivity(p);
            //  }

            //  SetContentView(Resource.Layout.SignIn);
            //  Button Feedback = FindViewById<Button>(Resource.Id.Feedbacks);
            //  Feedback.Click += profileClick;
            //  void FeedbackClick(Object sender, EventArgs eventArgs)
            //  {
            //      var p = new Intent(this, typeof(ProfileAcitvity));
            //      StartActivity(p);
            //  }

        }
    }
}
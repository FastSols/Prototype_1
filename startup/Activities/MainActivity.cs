using Android.App;
using Android.Widget;
using Android.OS;
using System.Data.SqlClient;
using Android.Content;
using System;
using startup.Activities;

namespace startup
{
    [Activity(Label = "startup", MainLauncher = true)]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SqlConnection con = new SqlConnection("azure se lelo");
          
            SetContentView(Resource.Layout.Main);
            TextView textView = FindViewById<TextView>(Resource.Id.display);
            Button button = FindViewById<Button>(Resource.Id.SignUpButton);
            button.Click += SignUpClick;
            void SignUpClick(object sender,System.EventArgs eventArgs)
            {
              
                
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);
               
                
            }

            Button button1 = FindViewById<Button>(Resource.Id.SignInButton);
            button1.Click += SignInClick;
            void SignInClick(object sender, System.EventArgs eventArgs)
            {
                var intent = new Intent(this, typeof(SigninActivity));
                StartActivity(intent);
                

            }
        }
    }
}


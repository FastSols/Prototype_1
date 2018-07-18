using Android.App;
using Android.Widget;
using Android.OS;
using System.Data.SqlClient;
using Android.Content;
using System;

namespace startup
{
    [Activity(Label = "startup", MainLauncher = true)]
    public class MainActivity : Activity
    {
       
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SqlConnection con = new SqlConnection("Server = tcp:fastsols.database.windows.net, 1433; Initial Catalog=UserDetails; User ID = system123; Password = Hornyporny@123;Timeout=30;");
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            TextView textView = FindViewById<TextView>(Resource.Id.display);
            Button button = FindViewById<Button>(Resource.Id.SignUpButton);
            button.Click += SignUpClick;
            void SignUpClick(object sender,System.EventArgs eventArgs)
            {
              
                try { 

                con.Open();
                 textView.Text = con.State.ToString();
                }
                catch (Exception e)
            {
                    textView.Text = e.Message.ToString();
                }
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);

                con.Close();
            }

            Button button1 = FindViewById<Button>(Resource.Id.SignInButton);
            button1.Click += SignInClick;
            void SignInClick(object sender, System.EventArgs eventArgs)
            {
                var intent = new Intent(this, typeof(Activity2));
                StartActivity(intent);
                // con.Open();
                //textView.Text = con.ToString();

            }
        }
    }
}


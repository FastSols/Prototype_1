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
using System.Data.SqlClient;
using startup.Activities;

namespace startup
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignUp);
            EditText email = FindViewById<EditText>(Resource.Id.email);
            EditText name = FindViewById<EditText>(Resource.Id.name);
            EditText surname = FindViewById<EditText>(Resource.Id.surname);
            EditText mobile = FindViewById<EditText>(Resource.Id.mobile);
            EditText course = FindViewById<EditText>(Resource.Id.course);
            EditText major = FindViewById<EditText>(Resource.Id.major);
            EditText password = FindViewById<EditText>(Resource.Id.password);

            Button button = FindViewById<Button>(Resource.Id.signup);
            button.Click += SignUpClick;
            void SignUpClick(object sender, System.EventArgs eventArgs)
            {
                string sql = "insert into student(Email,Firstname,Surname,Mobile,Course,Major,Pass) values ('" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + mobile.Text + "','" + course.Text + "','" + major.Text + "','" + password.Text + "');";
                try
                {

                    con.Open();
                    Toast.MakeText(this,con.State.ToString(), ToastLength.Long).Show();
                    SqlCommand cmd = new SqlCommand(sql, con);
                  int i =   cmd.ExecuteNonQuery();
                    var intent = new Intent(this, typeof(SendMailActivity));
                    StartActivity(intent);
                    Toast.MakeText(this, i.ToString(), ToastLength.Long).Show();
                    Finish();
                    //textView.Text = con.State.ToString();
                }
                catch (Exception e)
                {
                    // textView.Text = e.Message.ToString();
                }
              

                con.Close();
                // Create your application here
            }

        }
    }
}

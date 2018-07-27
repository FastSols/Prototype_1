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
namespace startup.Activities
{
    [Activity(Label = "SigninActivity")]
    public class SigninActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignIn);
           
            Button signingbutton = FindViewById<Button>(Resource.Id.login);
            signingbutton.Click += loginClick;

            void loginClick(Object sender, EventArgs eventArgs)
            {
                // TextView email = FindViewById<TextView>(Resource.Id.email_address);
                //  TextView password = FindViewById<TextView>(Resource.Id.password_text);
                //  string con_query = "take string from azure";
                //   string command = "select * from SignInDetails where Email = '" + email.Text + "' ";
                //   SqlConnection con = new SqlConnection(con_query);
                //   con.Open();
                //   SqlCommand sqlCommand = new SqlCommand(command, con);
                //  SqlDataReader dataReader = sqlCommand.ExecuteReader();
                //   if (dataReader.Read())

                // {
                //      if (password.Text == dataReader["Password"].ToString())
                //    {
                //  Toast.MakeText(this, dataReader["Email"].ToString(), ToastLength.Long).Show();
                var intent = new Intent(this, typeof(Dashboard));                   // }
                StartActivity(intent);
                //
            }

                 
            }
            // Create your application here
        }
    }



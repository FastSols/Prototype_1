﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App4.Activities
{
    [Activity(Label = "SignInActivity")]
    public class SignInActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.SignIn);
            // Create your application here

            Button signingbutton = FindViewById<Button>(Resource.Id.login);
            signingbutton.Click += loginClick;

            void loginClick(Object sender, EventArgs eventArgs)
            {
                Toast.MakeText(this, "inside event", ToastLength.Long).Show();
                TextView email = FindViewById<TextView>(Resource.Id.email_address);
                TextView password = FindViewById<TextView>(Resource.Id.password_text);
                string con_query = "Azure se lelo";
                string command = "select * from SignInDetails where Email = '" + email.Text + "' ";
                SqlConnection con = new SqlConnection(con_query);
                con.Open();
          
                SqlCommand sqlCommand = new SqlCommand(command, con);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                if (dataReader.Read())

                {
                    
                    if (password.Text == dataReader["Password"].ToString())
                    {
                        Toast.MakeText(this, dataReader["Email"].ToString(), ToastLength.Long).Show();

                    }
                }
            }
        }
    }
}
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
            SqlConnection con ;
            EditText domain = FindViewById<EditText>(Resource.Id.domain);
            CheckBox teacher = FindViewById<CheckBox>(Resource.Id.teacher);
            Button button = FindViewById<Button>(Resource.Id.signup);
            CheckBox student = FindViewById<CheckBox>(Resource.Id.student);
            teacher.CheckedChange += teacherClick;
            domain.Visibility = ViewStates.Invisible;



              SqlConnection connect()
            {
                SqlConnection connection = new SqlConnection("Server = tcp:fastsols.database.windows.net, 1433; Initial Catalog=UserDetails; User ID = system123; Password = Hornyporny@123;Timeout=30;");
              connection.Open();

                return connection;
            }

     
            void teacherClick(object sender,EventArgs eventArgs)
            {
                
                bool a = teacher.Checked;
                if (a == true)
                {
                    
                    domain.Visibility = ViewStates.Visible;
                }
                if (a == false)
                {
                   
                    domain.Visibility = ViewStates.Invisible;
                }
            }
            button.Click += SignUpClick;
            void SignUpClick(object sender, System.EventArgs eventArgs)
            {
                bool a = student.Checked;
                bool b = teacher.Checked;
                con = connect();
                Toast.MakeText(this, con.State.ToString(), ToastLength.Long).Show();

                if (a == true)
                {
                    // Toast.MakeText(this, "inside student", ToastLength.Long).Show();

                    string sql = "insert into student(Email,Firstname,Surname,Mobile,Course,Major,Pass) values ('" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + mobile.Text + "','" + course.Text + "','" + major.Text + "','" + password.Text + "');";
                    try
                    {


                        // Toast.MakeText(this, "Registered as student", ToastLength.Long).Show();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        int i = cmd.ExecuteNonQuery();

                        Toast.MakeText(this, i.ToString(), ToastLength.Long).Show();
                        //     Finish();
                        //textView.Text = con.State.ToString();
                    }
                    catch (Exception e)
                    {
                        // textView.Text = e.Message.ToString();
                    }
                    // Create your application here
                }
                if (b == true)
                {
                    Toast.MakeText(this, "inside teacher", ToastLength.Long).Show();
                    string sql = "insert into Teacher(Email,Name,Surname,Mobile,Password,Domain) values ('" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + mobile.Text + "','" + password.Text + "','" + domain.Text + "');";
                    try
                    {


                        Toast.MakeText(this, "Registered as teacher", ToastLength.Long).Show();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        int i = cmd.ExecuteNonQuery();

                        Toast.MakeText(this, i.ToString(), ToastLength.Long).Show();
                        // Finish();
                        //textView.Text = con.State.ToString();
                    }
                    catch (Exception e)
                    {
                        // textView.Text = e.Message.ToString();
                    }



                    // Create your application here

                }

                else if (a && b == true)
                {
                    string sql = "insert into Teacher(Email,Name,Surname,Mobile,Password,Domain) values ('" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + mobile.Text + "','" + password.Text + "','" + domain.Text + "');";
                    string sql2 = "insert into student(Email,Firstname,Surname,Mobile,Course,Major,Pass) values ('" + email.Text + "','" + name.Text + "','" + surname.Text + "','" + mobile.Text + "','" + course.Text + "','" + major.Text + "','" + password.Text + "');";

                }
                con.Close();
            }

        }
       

    }
}

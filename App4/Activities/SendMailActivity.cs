using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SendGrid;
using SendGrid.Helpers;
using SendGrid.Helpers.Mail;

namespace App4.Activities
{
    [Activity(Label = "SendMailActivity")]
    public class SendMailActivity : Activity
    {
      static  Random r = new Random(9999);
        static string email = "";
        protected override void OnCreate(Bundle savedInstanceState)
        {
           
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Mail);
             string username = Intent.Extras.GetString("EmailId");
            email = username;
           
            try {

                SendMail();
               
                Toast.MakeText(this,"complete", ToastLength.Long).Show();
            }
            
            catch (Exception e)
            {
            }

           // Toast.MakeText(this, "Inside Activity ", ToastLength.Long).Show();
        }

        static async Task SendMail()
        {

            int i = r.Next() ;
            var client = new SendGridClient("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");
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("chitalechinmay@outlook.com", "CLARIFY TEAM"),
                Subject = "TRIAL EMAIL 2 !",
                PlainTextContent = "YYYYUUHHUUUUUUUUUU",
                HtmlContent = "<Strong> Welcome new user please verify your account in below link</Strong>" +
              "<br>" +
                 "<a href='"+"instantsolution.co.in"+"'> Click Here</a>" +
                 "<Strong>your OTP is '"+i+"'</Strong>" 
               
            };
            msg.AddTo(new EmailAddress(email, "Test User"));
           await client.SendEmailAsync(msg);
          

        }

    }

   
    // Create your application here
}
   
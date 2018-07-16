using Android.App;
using Android.Widget;
using Android.OS;

namespace startup
{
    [Activity(Label = "startup", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Welcome);
            var uri = Android.Net.Uri.Parse("https://www.youtube.com/watch?v=YkksHqoIWI0");
            VideoView videoView = FindViewById<VideoView>(Resource.Id.welcomeVideo);
            videoView.SetMediaController(new MediaController(this));
            videoView.SetVideoURI(uri);
            videoView.RequestFocus();
            videoView.Start();
        }
    }
}


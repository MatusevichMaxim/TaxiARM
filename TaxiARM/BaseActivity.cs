using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TaxiARM.Classes;
using Android.Graphics;
using TaxiARM.Helpers;

namespace TaxiARM
{
    [Activity(Label = "TaxiARM", MainLauncher = true, ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class BaseActivity : Activity
    {
        private Button loginButton;
        private EditText loginText;
        private EditText passText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            RequestWindowFeature(WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.Main);

            Constants.Instance.InitializeConstants(Assets);

            loginButton = FindViewById<Button>(Resource.Id.login_button);
            loginText = FindViewById<EditText>(Resource.Id.login_text);
            passText = FindViewById<EditText>(Resource.Id.password_text);

            loginButton.SetTypeface(Constants.Instance.Vonique64Bold, TypefaceStyle.Normal);
            loginButton.SetBackgroundResource(Resource.Drawable.login_button);
            loginButton.Click += OnLogin;

            //loginText.SetTypeface(tf, TypefaceStyle.Normal);
            //passText.SetTypeface(tf, TypefaceStyle.Normal);
        }

        private void OnLogin(object sender, EventArgs e)
        {
            var login = loginText.Text;
            var pass = passText.Text;

            if (DataIsCorrect(login, pass))
            {
                var intent = new Intent(this, typeof(MainMenuActivity));
                StartActivity(intent);
            }
            else
            { 
                Toast.MakeText(this, "Incorrect data!", ToastLength.Short).Show();
            }
        }

        private bool DataIsCorrect(string login, string password)
        {
            if (login == "maxim" && password == "123")
                return true;

            return true; // TODO : return false
        }
    }
}


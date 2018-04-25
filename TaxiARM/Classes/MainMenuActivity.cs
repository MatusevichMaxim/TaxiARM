
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using TaxiARM.Helpers;

namespace TaxiARM.Classes
{
    [Activity(Label = "MainMenuActivity")]
    public class MainMenuActivity : Activity
    {
        private TextView orderReview;
        private TextView orderReport;
        private TextView clientsReviews;
        private TextView discountCards;
        private TextView driversButton;
        private TextView ratesButton;
        private TextView streetsButton;
        private TextView problemsReports;
        private Button logout;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.lyt_main_menu);

            orderReview = FindViewById<TextView>(Resource.Id.orders_review);
            orderReport = FindViewById<TextView>(Resource.Id.orders_report);
            clientsReviews = FindViewById<TextView>(Resource.Id.clients_reviews);
            discountCards = FindViewById<TextView>(Resource.Id.discount_cards);
            driversButton = FindViewById<TextView>(Resource.Id.drivers_button);
            ratesButton = FindViewById<TextView>(Resource.Id.rates_button);
            streetsButton = FindViewById<TextView>(Resource.Id.streets_button);
            problemsReports = FindViewById<TextView>(Resource.Id.problems_reports);

            logout = FindViewById<Button>(Resource.Id.logout);
            logout.SetTypeface(Constants.Instance.Vonique64Bold, TypefaceStyle.Normal);
            logout.Click += delegate { OnBackPressed(); };


        }
    }
}

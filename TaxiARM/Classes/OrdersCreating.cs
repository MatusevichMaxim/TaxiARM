
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using TaxiARM.Helpers;

namespace TaxiARM.Classes
{
    [Activity(Label = "OrdersCreating")]
    public class OrdersCreating : Activity
    {
        private Button findDrivers;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var st = new SpannableString("Verification");
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_order_creating);

            findDrivers = FindViewById<Button>(Resource.Id.btn_find_driver);
            findDrivers.SetTypeface(Constants.Instance.Vonique64Bold, TypefaceStyle.Normal);
            findDrivers.Click += FindDrivers_Click;
        }

        private void FindDrivers_Click(object sender, EventArgs e)
        {
            
        }
    }
}

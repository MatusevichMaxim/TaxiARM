
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;

namespace TaxiARM.Classes
{
    [Activity(Label = "ReviewActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class ReviewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var title = $"{Intent.GetStringExtra("review_id")} review";

            var st = new SpannableString(title);
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_order_review);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}

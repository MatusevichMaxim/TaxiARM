
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
    [Activity(Label = "OrdersReportActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class OrdersReportActivity : Activity
    {
        private List<string> items;
        private ListView reportsList;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var st = new SpannableString("Orders report");
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_orders_report_list);

            reportsList = FindViewById<ListView>(Resource.Id.orders_report_list);
            items = new List<string>();

            for (int i = 1; i <= 5; i++)
            {
                items.Add($"Order #{i}");
            }

            var adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);
            reportsList.Adapter = adapter;

            reportsList.ItemClick += (sender, e) =>
            {
                var item = adapter.GetItem(e.Position);

                var intent = new Intent(this, typeof(ReportActivity));
                intent.PutExtra("report_id", item);
                StartActivity(intent);
            };
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

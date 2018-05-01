using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Widget;
using TaxiARM.Adapters;
using TaxiARM.Models;

namespace TaxiARM.Classes
{
    [Activity(Label = "OrdersActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class OrdersActivity : Activity
    {
        private List<OrderModel> mItems;
        private ListView list;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var st = new SpannableString("Orders");
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_orders_list);
            list = FindViewById<ListView>(Resource.Id.orders_list);

            mItems = new List<OrderModel>();

            for (int i = 0; i < 5; i++)
            {
                mItems.Add(new OrderModel()
                {
                    OrderId = $"#{i}",
                    Status = true,
                    LandingAddress = "LolKek",
                    TargetAddress = "Pipka",
                    Time = "18:20",
                    Persons = $"{i} persons"
                });
            }

            CustomListAdapter adapter = new CustomListAdapter(this, mItems);

            list.Adapter = adapter;
            list.ItemClick += List_ItemClick;
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

        private void List_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(OrdersCreating));
            StartActivity(intent);
        }
    }
}

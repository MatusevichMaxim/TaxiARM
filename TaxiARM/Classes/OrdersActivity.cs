using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
using TaxiARM.Adapters;
using TaxiARM.Models;

namespace TaxiARM.Classes
{
    [Activity(Label = "OrdersActivity")]
    public class OrdersActivity : Activity
    {
        private List<OrderModel> mItems;
        private ListView list;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

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
        }
    }
}

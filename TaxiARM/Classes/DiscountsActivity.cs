
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
using TaxiARM.Adapters;
using TaxiARM.Helpers;
using TaxiARM.Models;

namespace TaxiARM.Classes
{
    [Activity(Label = "DiscountsActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class DiscountsActivity : Activity
    {
        private ImageView addButton;

        private DiscountAdapter adapter;
        private List<DiscountModel> mItems;
        private ListView list;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var st = new SpannableString("Discounts");
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_discount_cards);
            list = FindViewById<ListView>(Resource.Id.discounts_list);

            mItems = new List<DiscountModel>();

            mItems.Add(new DiscountModel()
            {
                DiscountId = "FF123F",
                DiscountName = "Summer",
                DiscountSize = 5
            });

            mItems.Add(new DiscountModel()
            {
                DiscountId = "FP109G",
                DiscountName = "9 May",
                DiscountSize = 10
            });

            mItems.Add(new DiscountModel()
            {
                DiscountId = "OHY781",
                DiscountName = "VIP",
                DiscountSize = 15
            });

            adapter = new DiscountAdapter(this, mItems);
            list.Adapter = adapter;
            list.ItemLongClick += DeleteRow;

            addButton = FindViewById<ImageView>(Resource.Id.add_discount);
            addButton.Click += AddRow;
        }

        private void AddRow(object sender, EventArgs e)
        {
            
        }

        private void DeleteRow(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            AlertDialog.Builder alert = new AlertDialog.Builder(this);
            alert.SetTitle("Confirm delete");
            alert.SetMessage("Are you sure you want delete this?");
            alert.SetPositiveButton("Delete", (senderAlert, args) => 
            {
                mItems.RemoveAt(e.Position);
                adapter.NotifyDataSetChanged();
            });
            alert.SetNeutralButton("Edit", (senderAlert, args) =>
            { 
                var customDialog = new EditDialog(this, EditDiscount);
                customDialog.Create();
                customDialog.Window.SetLayout(900, 900);
                customDialog.Show();
            });
            alert.SetNegativeButton("Cancel", (senderAlert, args) => { });

            Dialog dialog = alert.Create();
            dialog.Show();
        }

        private void EditDiscount()
        { 
            
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

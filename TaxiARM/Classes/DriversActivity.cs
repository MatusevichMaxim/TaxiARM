using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Widget;
using TaxiARM.Adapters;
using TaxiARM.Models;

namespace TaxiARM.Classes
{
    [Activity(Label = "DriversActivity", ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait)]
    public class DriversActivity : Activity
    {
        private List<DriverModel> mItems;
        private ListView list;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var st = new SpannableString("Drivers");
            ActionBar.SetHomeButtonEnabled(true);
            ActionBar.SetDisplayHomeAsUpEnabled(true);
            ActionBar.TitleFormatted = st;

            SetContentView(Resource.Layout.lyt_drivers_list);
            list = FindViewById<ListView>(Resource.Id.drivers_cards_list);

            mItems = new List<DriverModel>();

            for (int i = 0; i < 5; i++)
            {
                mItems.Add(new DriverModel()
                {
                    DriverId = "123ASD",
                    FirstName = "Oleg",
                    SecondName = "Rimmer",
                    Car = new CarModel() { CarModelId = "1", CarBrand = "Porsche" },
                    CarNumber = "7232HG-2"
                });
            }

            var adapter = new DriverAdapter(this, mItems);

            list.Adapter = adapter;
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

using System;
using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using TaxiARM.Models;

namespace TaxiARM.Adapters
{
    public class DriverAdapter : BaseAdapter<DriverModel>
    {
        private Context mContext;
        public List<DriverModel> mItems;

        public DriverAdapter(Context context, List<DriverModel> items)
        {
            mItems = items;
            mContext = context;
        }

        public override DriverModel this[int position] => mItems[position];

        public override int Count => mItems.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.lyt_driver_card, null, false);

            TextView name = row.FindViewById<TextView>(Resource.Id.driver_card_name);
            TextView car = row.FindViewById<TextView>(Resource.Id.driver_card_model);
            TextView number = row.FindViewById<TextView>(Resource.Id.driver_card_number);

            name.Text = mItems[position].FirstName + " " + mItems[position].SecondName;
            car.Text = mItems[position].Car.CarBrand;
            number.Text = mItems[position].CarNumber;

            return row;
        }
    }
}

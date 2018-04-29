using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using TaxiARM.Models;

namespace TaxiARM.Adapters
{
    public class CustomListAdapter : BaseAdapter<OrderModel>
    {
        private Context mContext;
        public List<OrderModel> mItems;


        public CustomListAdapter(Context context, List<OrderModel> items)
        {
            mItems = items;
            mContext = context;
        }

        public override OrderModel this[int position] => mItems[position];

        public override int Count => mItems.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.lyt_orders_row, null, false);

            TextView orderId = row.FindViewById<TextView>(Resource.Id.order_id);
            TextView landing = row.FindViewById<TextView>(Resource.Id.landing_text);
            TextView targetPoint = row.FindViewById<TextView>(Resource.Id.target_point_text);
            TextView time = row.FindViewById<TextView>(Resource.Id.landing_time);
            TextView persons = row.FindViewById<TextView>(Resource.Id.people_counter);
            ImageView status = row.FindViewById<ImageView>(Resource.Id.status_icon);

            orderId.Text = mItems[position].OrderId;
            landing.Text = mItems[position].LandingAddress;
            targetPoint.Text = mItems[position].TargetAddress;
            time.Text = mItems[position].Time;
            persons.Text = mItems[position].Persons;

            if (mItems[position].Status)
                status.SetImageResource(Resource.Drawable.ic_active_status);
            else
                status.SetImageResource(Resource.Drawable.ic_waiting_status);

            return row;
        }
    }
}

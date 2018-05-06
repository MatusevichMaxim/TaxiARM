using System.Collections.Generic;
using Android.Content;
using Android.Views;
using Android.Widget;
using TaxiARM.Models;

namespace TaxiARM.Adapters
{
    public class DiscountAdapter : BaseAdapter<DiscountModel>
    {
        private Context mContext;
        public List<DiscountModel> mItems;

        public DiscountAdapter(Context context, List<DiscountModel> items)
        {
            mItems = items;
            mContext = context;
        }

        public override DiscountModel this[int position] => mItems[position];

        public override int Count => mItems.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;

            if (row == null)
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.lyt_discount_row, null, false);

            TextView discountName = row.FindViewById<TextView>(Resource.Id.discount_name);
            TextView discountSize = row.FindViewById<TextView>(Resource.Id.discount_size);

            discountName.Text = mItems[position].DiscountName;
            discountSize.Text = $"- {mItems[position].DiscountSize}%";

            return row;
        }
    }
}

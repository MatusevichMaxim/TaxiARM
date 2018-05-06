using System;
using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;

namespace TaxiARM.Helpers
{
    public class EditDialog : Dialog
    {
        private Action action;

        public EditDialog(Activity activity, Action action) : base(activity)
        {
            this.action = action;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            RequestWindowFeature((int)WindowFeatures.NoTitle);
            SetContentView(Resource.Layout.lyt_edit_discount_dialog);

            var edit = FindViewById<Button>(Resource.Id.dialog_edit_button);
            edit.Click += (e, a) =>
            {
                action?.Invoke();
            };
        }
    }
}

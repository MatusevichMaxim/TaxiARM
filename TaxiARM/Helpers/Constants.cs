using System;
using Android.Graphics;

namespace TaxiARM.Helpers
{
    public class Constants
    {
        private static Constants thisRef;

        public static Constants Instance
        {
            get
            {
                if (thisRef == null)
                    thisRef = new Constants();

                return thisRef;
            }
        }

        public Typeface Vonique64;
        public Typeface Vonique64Bold;

        public Constants() { }

        public void InitializeConstants(Android.Content.Res.AssetManager assets)
        { 
            Vonique64 = Typeface.CreateFromAsset(assets, "Vonique 64.ttf");
            Vonique64Bold = Typeface.CreateFromAsset(assets, "Vonique 64 Bold.ttf");
        }
    }
}

using System;

namespace TaxiARM.Models
{
    public class OrderModel
    {
        public string OrderId { get; set; }

        public bool Status { get; set; } // active == true

        public string LandingAddress { get; set; }

        public string TargetAddress { get; set; }

        public string Time { get; set; }

        public string Persons { get; set; }
    }
}

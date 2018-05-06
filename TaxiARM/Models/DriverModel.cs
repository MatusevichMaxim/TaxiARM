using System;
namespace TaxiARM.Models
{
    public class DriverModel
    {
        public string DriverId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public CarModel Car { get; set; }

        public string CarNumber { get; set; }
    }
}

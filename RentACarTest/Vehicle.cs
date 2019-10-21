using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarTest
{
    public class Vehicle
    {
        public enum Manufacturer { Volvo, Saab, Toyota, BMW, Mercedes }
        public Manufacturer _manuf { get; set; }

        public decimal HourFee { get; set; }
        public string RegistrationNumber { get; set; }
        public decimal DailyPrice { get; set; }  
        public int NumberOfSeats { get; set; }
        public int CargoCapacity { get; set; }
        public bool IsRented { get; set; }
        public bool IsElectric { get; set; }
        public bool IsRentedForMoreThenAWeek { get; set; }

        public string VehicleType { get; set; }


        public Vehicle(Manufacturer manuf, string regNr, decimal dayPrice, int cargoCap, bool isRent, string vehicleType, decimal hourFee, bool isRentedForMoreThenAWeek)
        {
            _manuf = manuf;
            RegistrationNumber = regNr;
            DailyPrice = dayPrice;
            CargoCapacity = cargoCap;
            IsRented = isRent;
            VehicleType = vehicleType;
            HourFee = hourFee;
            IsRentedForMoreThenAWeek = isRentedForMoreThenAWeek;
        }

        public Vehicle(Manufacturer manuf, string regNr, decimal dayPrice, int numbSeats, bool isElect, bool isRent, string vehicleType, decimal hourFee, bool isRentedForMoreThenAWeek)
        {
            _manuf = manuf;
            RegistrationNumber = regNr;
            DailyPrice = dayPrice;
            NumberOfSeats = numbSeats;
            IsElectric = isElect;
            IsRented = isRent;
            VehicleType = vehicleType;
            HourFee = hourFee;
            IsRentedForMoreThenAWeek = isRentedForMoreThenAWeek;
        }

        public Vehicle()
        {
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarTest
{
    public class Sedan : Vehicle
    {


        public Sedan(Manufacturer manuf, string regNr, decimal dayPrice, int numbSeats, bool isElect, bool isRent, string vehicleType, decimal hourFee, bool isRentedForMoreThenAWeek) :
                     base(manuf, regNr, dayPrice, numbSeats, isElect, isRent, vehicleType, hourFee, isRentedForMoreThenAWeek)
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


    }
    }

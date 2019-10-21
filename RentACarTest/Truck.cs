using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarTest
{
    class Truck : Vehicle
    {
        public Truck(Manufacturer manuf, string regNr, decimal dayPrice, int cargoCap, bool isRent, string vehicleType, decimal hourFee, bool isRentedForMoreThenAWeek) :
                    base(manuf, regNr, dayPrice, cargoCap, isRent, vehicleType, hourFee, isRentedForMoreThenAWeek)
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
        public void TruckObject()
        {
            //Manufacturer, string regNr, decimal dayPrice, int cargoCap, bool isRent
            Truck tSaab = new Truck(Manufacturer.Saab, "JON003", 7000, 4000, false, "Truck", 70, false);

            Truck tBMV = new Truck(Manufacturer.BMW, "LOR003", 8000, 1500, false, "Truck", 50, false);

            Truck tToyota = new Truck(Manufacturer.Toyota, "DAN003", 1700, 2500, false, "Truck", 40, false);

            Truck tVolvo = new Truck(Manufacturer.Volvo, "MAT003", 7001, 10000, false, "Truck", 70, false);

            Truck tMercedes = new Truck(Manufacturer.Mercedes, "AND003", 6600, 3000, false, "Truck", 80, false);
        }
    }
}


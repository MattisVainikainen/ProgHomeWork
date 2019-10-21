using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    //This class inherits from parent class "Vehicles"
    class Sedan:Vehicles
    {
        bool IsElectric;
        int NumberOfSeats;
        
        

        //Enum list of all the car brands
        public enum Manufacturer { Volvo, Saab, Toyota, BMW, Mercedes }
        private Manufacturer _manuf;
        


        public Sedan(Manufacturer manuf, bool iElect, int nrSeats, string regNr, double dPrice)
        {
            _manuf = manuf;
            IsElectric = iElect;
            NumberOfSeats = nrSeats;
            RegistrationNumber = regNr;
            DailyPrice = dPrice;
            
        }
        public Sedan(double dPrice)
        {
            DailyPrice = dPrice;
        }

        // Method for creating every car as an object, and putting it into a list. 
        public void CreateCarObject()
        {
            Sedan Saab1 = new Sedan(Manufacturer.Saab, false, 4, "JON001", 1000);
            Sedan Saab2 = new Sedan(Manufacturer.Saab, true, 4, "EGH002", 1000);

            Sedan BMV1 = new Sedan(Manufacturer.BMW, false, 4, "LOR001", 1000);
            Sedan BMV2 = new Sedan(Manufacturer.BMW, true, 4, "MAH002", 1000);

            Sedan Toyota1 = new Sedan(Manufacturer.Toyota, false, 4, "DAN001", 1000);
            Sedan Toyota2 = new Sedan(Manufacturer.Toyota, true, 4, "SOD007", 1000);

            Sedan Volvo1 = new Sedan(Manufacturer.Volvo, false, 4, "MAT001", 1000);
            Sedan Volvo2 = new Sedan(Manufacturer.Volvo, true, 4, "VAI002", 1000);

            Sedan Mercedes1 = new Sedan(Manufacturer.Mercedes, false, 4, "AND001", 1000);
            Sedan Mercedes2 = new Sedan(Manufacturer.Mercedes, true, 4, "PON002", 1000);

            List<Sedan> ListOfCars = new List<Sedan>();

            ListOfCars.Add(Saab1);
            ListOfCars.Add(Saab2);
            ListOfCars.Add(BMV1);
            ListOfCars.Add(BMV2);
            ListOfCars.Add(Toyota1);
            ListOfCars.Add(Toyota2);
            ListOfCars.Add(Volvo1);
            ListOfCars.Add(Volvo2);
            ListOfCars.Add(Mercedes1);
            ListOfCars.Add(Mercedes2);

        }




        //Sends back a value if electric is true and gets this 10% discount
        public bool ElectricDiscount()
        {
            return true;
        }

        

       

    }
}

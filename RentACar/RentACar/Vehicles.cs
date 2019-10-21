using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar
{
    //Create an abstract class for other classes to inherit. Inherited by child classes "Truck" and "Sedan"
    abstract class Vehicles
    {
        protected string RegistrationNumber { get; set; }
        protected float DailyPrice { get; set; }
        protected int NumberOfCars { get; set; }

        //Constructor 
        public Vehicles(string regNr, float dPrice)
        {
            RegistrationNumber = regNr;
            DailyPrice = dPrice;
            
  
        }
        
    }

    
}

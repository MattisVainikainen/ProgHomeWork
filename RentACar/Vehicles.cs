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
        protected double dailyPrice;
        protected int NumberOfCars { get; set; }

        //Constructor 
        //public Vehicles(string regNr, double dPrice)
        //{
        //    RegistrationNumber = regNr;
        //    dailyPrice = dPrice;
            
  
        //}
        
     
        public double DailyPrice
        {
            get { return dailyPrice; }
            set
            {
                dailyPrice = value;
            }
        }
    }

    
}

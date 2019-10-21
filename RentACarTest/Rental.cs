using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACarTest
{
    public class Rental
    {
        static Rental s = new Rental();
        private const decimal BookingFee = 200;
        public List<Vehicle> ListOfVehicles { get; set; }
        public List<Vehicle> RentedVehicles { get; set; }

        //Empty constructor with 2 Lists inside.
        public Rental()
        {
            ListOfVehicles = new List<Vehicle>();
            RentedVehicles = new List<Vehicle>();
        }

        //Calculate Hour price if you only rent a vehicle for some hours.
        public decimal CalcHourPrice()
        {
            decimal userHourInput;
            Console.WriteLine("How many hours:");
            userHourInput = decimal.Parse(Console.ReadLine());
            decimal totalCost = 0;
            foreach (var car in ListOfVehicles)
            {
                totalCost += car.HourFee * userHourInput + BookingFee;
            }
            return totalCost;
        }
        
        //Show all vehiclas in ListOfVehicles
        public void ShowVehicles()
        {
            
            foreach (var vehicle in ListOfVehicles)
            {
                Console.WriteLine($"DailyPrice: {vehicle.DailyPrice}, HourFee: {vehicle.HourFee}, ManuFacturer: {vehicle._manuf}");
            }
        }

        //Check if car is electric or not. if its true you get 10% discount.
        public decimal CheckForElectricDiscount()
        {
            decimal totalCost = 0;
            foreach (var car in s.ListOfVehicles)
            {
                if(car.IsElectric == true && car.IsRentedForMoreThenAWeek == false)
                { // If car is electric you get 10% discount on totalcost.
                    totalCost = (car.DailyPrice + BookingFee) * 0.9M;
                    Console.WriteLine("Electric cars gives 10% discount! Thats Great!");
                    return totalCost;
                 
                }
                if (car.IsElectric == true && car.IsRentedForMoreThenAWeek == true)
                { // If car is electric you get 10% discount on totalcost.
                    totalCost = (car.DailyPrice + BookingFee) * 0.8M;
                    Console.WriteLine("Electric cars gives 10% discount! Thats Great!");
                    Console.WriteLine("Renting for more then 7 days also gives 10% discount");
                    return totalCost;

                }

                if(car.IsElectric == false && car.IsRentedForMoreThenAWeek == true)
                {
                    totalCost = (car.DailyPrice + BookingFee) * 0.9M;
                }

                else
                { //If car is not electric you pay full price ( daily + BookingFee)
                    totalCost += car.DailyPrice + BookingFee;
                }
                
                
            }
            return totalCost;

        }
        public static void RentCars()
        {
            //Sedan car = new Sedan(Vehicle.Manufacturer.Saab, "hej007", 300, 4, false, true, "Sedan", 30);
            Sedan car1 = new Sedan(Vehicle.Manufacturer.Saab, "hej007", 500, 4, false, false, "Sedan", 50, true);
            //Truck truck1 = new Truck(Vehicle.Manufacturer.Mercedes, "hej999", 1200, 1300, true, "Truck", 40);
            //Truck tSaab = new Truck(Vehicle.Manufacturer.Saab, "JON003", 7000, 4000, false, "Truck", 60);
            //Truck tBMV = new Truck(Vehicle.Manufacturer.BMW, "LOR003", 8000, 1500, false, "Truck", 70);


            //s.ListOfVehicles.Add(car);
            s.ListOfVehicles.Add(car1);
            //s.ListOfVehicles.Add(truck1);
            //s.ListOfVehicles.Add(tSaab);
            //s.ListOfVehicles.Add(tBMV);
            //s.RentedVehicles.Add(car);

            foreach (var vehicle in s.ListOfVehicles)
            {
                if(vehicle.VehicleType == "Sedan")
                {
                    Console.WriteLine($"Vehicle: {vehicle._manuf}, Daily Cost: {vehicle.DailyPrice}, HourFee: {vehicle.HourFee}, Modeltype: {vehicle.VehicleType} Electric: {vehicle.IsElectric}");
                }
                if(vehicle.VehicleType == "Truck")
                {
                    Console.WriteLine($"Vehicle: {vehicle._manuf} Cost: {vehicle.DailyPrice}, Modeltype: {vehicle.VehicleType}, CargoCapacity: {vehicle.CargoCapacity}");
                } 
            }
            Console.WriteLine($"Total price: {s.CheckForElectricDiscount()}");
            

        }
    }
}

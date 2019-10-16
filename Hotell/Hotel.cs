using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class Hotel
    {
        public Room room; //Composite relation to room
        public string hotelName;
        public static List<Customer> CustomerList = new List<Customer>(); //Aggragation relation to customer.

        public static int customerNumberMaker = 1000;
        public static int roomNumberMaker = 100;

        public Hotel(string name)
        {
            hotelName = name;
        }

        public Hotel()
        {

        }
        //function that takes the class Room as reference
        public Room bookRoom()
        {
            //Create customer
            Customer customer = new Customer();
            Console.Write("Enter customer name ");
            customer.Name = Console.ReadLine();
            customer.CustomerId = ++customerNumberMaker;


            CustomerList.Add(customer);
            foreach(Customer customers in CustomerList)
            {
                Console.WriteLine($"Customer id: {customers.CustomerId} for costumer {customers.Name}");
            }

            //Create Room
            Room roomNew = new Room();
            roomNew.RoomNr = ++roomNumberMaker;
            roomNew.Occupied = true;

            Console.WriteLine($"Room nr booked: {roomNew.RoomNr}, Booking status is: { roomNew.Occupied}");

            return room;
        }

    }
}

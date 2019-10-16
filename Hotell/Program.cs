using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class Program
    {
        static void Main(string[] args)
        {
            Hotel hotel = new Hotel();
            hotel.hotelName = "Grand";
            Console.WriteLine($"Welcome to: {hotel.hotelName}");
            hotel.bookRoom();

            RoomKeyCard rk = new RoomKeyCard();
            rk.useKeyCard();

            Console.ReadLine();

        }
    }
}

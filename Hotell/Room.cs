using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class Room
    {
        public int RoomNr;
        public string Beds;
        private bool occupied = false;
        private Hotel hotel;

        public Room(Hotel hotel)
        {
            this.hotel = hotel;
        }
        public Room()
        {

        }

        public bool Occupied
        {
            get { return occupied; }
            set
            {
                occupied = value;
            }
        }
    }
}

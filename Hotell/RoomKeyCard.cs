using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class RoomKeyCard
    {
        public int cardNr = 0;

        public RoomKeyCard(int cnr)
        {
            cardNr = cnr;
        }

        public RoomKeyCard()
        {

        }

        public int CardNr
        {
            get { return cardNr; }
        }

        public void useKeyCard()
        {
            cardNr += 1;
            Console.WriteLine($"Card nr is: {CardNr}");
        }
    }
}

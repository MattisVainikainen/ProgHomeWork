using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning34
    {
        public void Print()
        {
            while (true)
            {
                Console.WriteLine("Ange tecken");
                string input = Console.ReadLine();

                if(input == "*")
                {
                    Console.WriteLine("Du valde * och vi avslutar programmet.");
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}

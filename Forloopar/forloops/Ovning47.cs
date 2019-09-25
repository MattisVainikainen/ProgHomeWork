using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning47
    {
        public void Print()
        {
            int produkt = 1;
            for (int i = 1; i <= 15; i+=2)
            {
                produkt = produkt * i;
                Console.WriteLine($"{produkt}");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning43
    {
        public void Print()
        {
            int sum = 0;
          //  int omgång = 0;
            for (int i = 2; i <= 30; i+=2)
            {
             //  omgång = i / 2;
                sum = sum + i;
                Console.WriteLine($"Omgång{i/2} Summa {sum}");
                

            }
            
            Console.ReadLine();
        }
    }
}

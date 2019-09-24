using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class ForLoopss
    {
        public void Print()
        {
            
            for (int i = 0; i <= 50; i+=2)
            {
                int summa = i;
                Console.WriteLine($"Omgång {i} är summan {summa}");
                summa = i + i;
            }
            Console.ReadLine();
        }
    }
}

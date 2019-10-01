using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning69
    {
        public void Print()
        {
            int[] tal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            for (int i = 0; i < tal.Length; i+=2)
            {
                Console.WriteLine(i+2);
            }
            Console.ReadLine();
        }

        public static void RunOvning69()
        {
            Ovning69 Ovn69 = new Ovning69();
            Ovn69.Print();
        }
    }
}

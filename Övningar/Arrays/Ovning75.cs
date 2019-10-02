using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning75
    {
        public void Print()
        {
            int[] olikaTal = { -3, 5, -7, 8, 18 };
            int sumPositivaTal = 0;
            int sumNegativaTal = 0;

            foreach (var number in olikaTal)
            {
                if(number > 0)
                {
                    sumPositivaTal += number;
                }
                else
                {
                    sumNegativaTal += number;
                }
            }

            Console.WriteLine($"Summan av alla positiva tal: {sumPositivaTal}");
            Console.WriteLine($"Summan av alla positiva tal: {sumNegativaTal}");
            Console.ReadLine();

        }

        public static void RunOvning75()
        {
            Ovning75 Ovn75 = new Ovning75();
            Ovn75.Print();
        }
    }
}

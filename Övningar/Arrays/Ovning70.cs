using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning70
    {
        public void Print()
        {
            
            int[] OlikaTal = { -10, 10, 40, -4, 34 , -10, -100, 566};
            int negativaTal = 0;

            foreach (var number in OlikaTal)
            {
                if(number > 0)
                {
                    Console.WriteLine(number);
                }
            }
           
            Console.ReadLine();
        }

        public static void RunOvning70()
        {
            Ovning70 Ovn70 = new Ovning70();
            Ovn70.Print();
        }
    }
}

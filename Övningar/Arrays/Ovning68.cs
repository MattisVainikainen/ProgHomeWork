using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning68
    {
        public void Print()
        {
            int[] antalTal = { 2, 4, 6, 8, 10 };

            foreach (var numbers in antalTal)
            {
                Console.WriteLine($"IndexNumber: {numbers} and double that = {numbers *2} ");
            }
        }

        public static void RunOvning68()
        {
            Ovning68 Ovn68 = new Ovning68();
            Ovn68.Print();
        }
    }
}

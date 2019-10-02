using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning74
    {
        public void Print()
        {
            int[] olikaTal = { 4, 5, 88, 3, 8};
            int MAX = olikaTal.Max();
            int MIN = olikaTal.Min();
            
            int max_position = Array.IndexOf(olikaTal, MAX);
            int min_position = Array.IndexOf(olikaTal, MIN);


            int antalLoops = 0;
            foreach (var number in olikaTal)
            {
                antalLoops++;
                Console.WriteLine($"Tal {antalLoops}: {number}");
            }

            Console.WriteLine($"Största talet är:{MAX} på position: {max_position} ");
            Console.WriteLine($"Minsta talet är:{MIN} på position: {min_position} ");
            Console.ReadLine();
            

        }

        public static void RunOvning74()
        {
            Ovning74 Ovn74 = new Ovning74();
            Ovn74.Print();
        }
    }
}

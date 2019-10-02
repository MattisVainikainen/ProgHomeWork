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
            //Array utav INTS
            int[] olikaTal = { 4, 5, 88, 3, 8};
            // Här skapar vi en variabel MAX som använder sig utav .MAX() metoden.
            int MAX = olikaTal.Max();
            // Här skapar vi en variabel MIN som använder sig utav .MIN() metoden.
            int MIN = olikaTal.Min();
            
            //Här får vi reda på index platsen för MAX och MIN
            int max_position = Array.IndexOf(olikaTal, MAX);
            int min_position = Array.IndexOf(olikaTal, MIN);

            // Vi deklarerar en variabel för varje gång den loopas.
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

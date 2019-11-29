using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning6
    {
        //Skapar en array med 5 indexplatser.
        int[] elements = new int[5] { 10, -13, 4, 5, 3 };
        int sum;
        public void Ovn6()
        {
            //För varje indexplats så adderar vi dessa tillsammans i variabeln sum.
            foreach (var number in elements)
            {
                sum += number;

            }

            //Skriver ut totalsumman.
            Console.WriteLine($"Total sum of all numbers = {sum}");
            Console.ReadLine();

        }


        public static void PrintOvning6()
        {
            Ovning6 Ovn6 = new Ovning6();
            Ovn6.Ovn6();
        }
    }
}

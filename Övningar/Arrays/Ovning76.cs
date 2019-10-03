using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning76
    {
        public void Print()
        {
            int[] arrayNrOne = { 3, 6, 7, 8, 9 };
            int[] arrayTwo = new int[5];

            Array.Copy(arrayNrOne, arrayTwo, 5);

            Array.Reverse(arrayTwo);
            foreach (var number in arrayTwo)
            {
                Console.WriteLine($"{number}");
            }
            Console.WriteLine($"Vi kopierade innehållet från {arrayNrOne}");
            Console.ReadLine();

        }

        public static void RunOvning76()
        {
            Ovning76 Ovn76 = new Ovning76();
            Ovn76.Print();
        }
    }
}

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

            int[] arrayNrOne = new int[5];
            int[] arrayTwo = new int[5];

            Console.Write("Input 5 elements in the array :\n");
            for (int i = 0; i < arrayNrOne.Length; i++)
            {
                Console.Write($"element - {i + 1} : ");
                arrayNrOne[i] = Convert.ToInt32(Console.ReadLine());
            }


            Array.Copy(arrayNrOne, arrayTwo, arrayNrOne.Length);
            Reverse(arrayTwo);
            Console.WriteLine("\nReversing back");
            Reverse(arrayTwo);
            
            
           

            Console.ReadLine();

        }

        private static void Reverse(int[] arrayTwo)
        {
            Array.Reverse(arrayTwo);
            foreach (var number in arrayTwo)
            {
                Console.Write($"{number}");
            }
        }

        public static void RunOvning76()
        {
            Ovning76 Ovn76 = new Ovning76();
            Ovn76.Print();
        }
    }
}

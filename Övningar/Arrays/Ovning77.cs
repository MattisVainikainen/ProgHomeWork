using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning77
    {

        public void Print()
        {
            int[] olikaTal = new int[5];

            for (int i = 0; i < olikaTal.Length; i++)
            {
                Console.Write($"Ange tal: {i + 1}: ");
                olikaTal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write($"Du skrev in följande: ");
            Regular(olikaTal);
            Console.WriteLine();
            Console.Write("Baklänges blir detta: ");
            Reverse(olikaTal);
            Console.WriteLine();
            Console.Write("Baklänges igen så blir detta: ");
            Reverse(olikaTal);


        }

        private static void Regular(int[] olikaTal)
        {
            foreach (var number in olikaTal)
            {
                Console.Write($"{number}");
            }
        }

        private static void Reverse(int[] olikaTal)
        {
            Array.Reverse(olikaTal);
            foreach (var number in olikaTal)
            {
                Console.Write($"{number}");
            }
        }

        public static void RunOvning77()
        {
            Ovning77 Ovn77 = new Ovning77();
            Ovn77.Print();
        }
    }
}

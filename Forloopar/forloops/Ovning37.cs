using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    public class Ovning37
    {
        public void Print()
        {
            Console.Write("Ange hur många tal du vill skriva: ");
            int antalTal = int.Parse(Console.ReadLine());

            for (int i = 1; i <= antalTal; i++)
            {
                Console.Write("Ange tal:");
                int tal = int.Parse(Console.ReadLine());
                Console.WriteLine($"{i}:a talet. {tal}");
            }

            Console.ReadLine();
        }
    }
}

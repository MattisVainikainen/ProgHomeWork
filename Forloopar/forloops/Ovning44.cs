using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning44
    {
        public void Print()
        {
            int sum = 0;
            Console.Write("Ange antal tal du vill skriva in: ");
            int userInputs = int.Parse(Console.ReadLine());

            for (int i = 1; i <= userInputs; i++)
            {
                Console.Write("Ange tal: ");
                int userInput = int.Parse(Console.ReadLine());
                sum += userInput;
                Console.WriteLine($"Omgång: {i} blir summan: {sum}");
            }
            
            Console.ReadLine();

        }
    }
}

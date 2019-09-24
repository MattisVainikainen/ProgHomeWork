using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning42
    {
        public void Print ()
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ange tal: ");
                int userInput = int.Parse(Console.ReadLine());
                sum += userInput;
                Console.WriteLine($"Omgång{i} är summan: {sum}");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"Totalt blir summan: {sum}");
           
            Console.ReadLine();
        }
      
       
    }
}

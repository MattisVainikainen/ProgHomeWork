using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning51
    {
        public void Print()
        {
            Console.WriteLine("Skriv ut 10st heltal.");
            
            int amountOf7 = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ange tal {i}: ");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == 7)
                {
                    amountOf7++;
                }
            }
            Console.WriteLine($" Du skrev siffran 7:     |{amountOf7} gånger| ");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning52
    {
        public void Print()
        {
            int positiveNumber = 0;
            int negativeNumber = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ange tal {i}: ");
                int userInput = int.Parse(Console.ReadLine());

                if(userInput < 0)
                {
                    negativeNumber++;
                }

                if(userInput > 0)
                {
                    positiveNumber++;
                }

                
            }
            Console.Write($"Du angav ett positivt nummer {positiveNumber} gånger.");
            Console.ReadLine();
        }
    }
}

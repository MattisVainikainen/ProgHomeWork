using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning59
    {
        
        public void Print()
        {

            Console.Write("Ange hur många tal du vill skriva in: ");
            int amountNumber = int.Parse(Console.ReadLine());
            Console.Write("Input First number: ");
            double number1 = int.Parse(Console.ReadLine());

            double störstaTalet = number1;
            double minstaTalet = number1;

            for (int i = 2; i <= amountNumber; i++)
            {
                Console.WriteLine($"Ange Tal {i}: ");
                double userInput = int.Parse(Console.ReadLine());

                if(userInput > störstaTalet)
                {
                    störstaTalet = userInput;
                }

                if(userInput < minstaTalet)
                {
                    minstaTalet = userInput;
                }
            }

            Console.WriteLine($"Largets number is: {störstaTalet} and the smallest number is: {minstaTalet}");
            Console.ReadLine();


        }
    }
}

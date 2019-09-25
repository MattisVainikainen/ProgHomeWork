using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning48
    {
        public void Print()
        {
     
              Console.Write("Ange N värdet: ");
              int userInput = int.Parse(Console.ReadLine());
              Console.Write($"{userInput}! = ");

              for (int i = 1; i <= userInput; i++)
              {
                if(i == userInput)
                {
                    Console.Write($" {i}.");
                }
                else
                {
                    Console.Write($" {i} * ");
                }
                    

              }
            Console.ReadKey();
        }
    }
}

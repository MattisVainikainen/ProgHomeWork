using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning56
    {
        public void Print()
        {
            int userInput = 0;
            int sum = 0;
            int amountOfNumbers = 0;
            int omgång = 1;

            do
            {
                Console.Write($"Ange Tal {omgång}: ");
                userInput = int.Parse(Console.ReadLine());
                if(userInput == 9999)
                {
                    Console.WriteLine("Du måste ange ett första värde som inte är 9999 ");
                }  
            } while (userInput == 9999);

            amountOfNumbers++;
            omgång++;


            while (userInput != 9999)
            {
                Console.Write($"Ange Tal {omgång}: ");
                userInput = int.Parse(Console.ReadLine());

                
                if (userInput == 9999)
                {
                    Console.WriteLine($"Medelvärdet av alla tal du skrev in = {sum / amountOfNumbers} ");
                }
                
                else
                {
                    omgång++;
                    amountOfNumbers++;
                    sum += userInput;
                }
            }
            Console.ReadLine();
        }
    }
}

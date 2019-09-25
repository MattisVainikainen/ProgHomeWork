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
            int negativeNumber = 0;
            int positiveNumber = 0;
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                
                Console.Write($"Ange tal {i}: ");
                int tal = int.Parse(Console.ReadLine());

                if(tal > 0)
                {
                    sum += tal;
                    positiveNumber++;
                }
                else
                {
                    negativeNumber++;
                }
 
            }
            Console.WriteLine($"Antal negativa nummer: {negativeNumber} ");
            Console.WriteLine($"Antal positiva nummer: {positiveNumber} ");           
            Console.WriteLine($"Summan av alla tal blir: {sum} ");
            Console.ReadLine();
        }
    }
}

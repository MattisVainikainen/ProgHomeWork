using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning55
    {
        public void Print()
        {
            int störreTal = 0;
            int mindreTal = 0;
            int sum = 0;
            int sum1 = 0;
            int tal1;
            int tal2;
            Console.WriteLine("Ange 11st heltal.");

            Console.Write("Ange första talet: ");
            tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First input compared to all others");
            Console.WriteLine($"Första tal: {tal1} ");
            Console.WriteLine("_______________________________");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ange tal2 {i}: ");
                tal2 = int.Parse(Console.ReadLine());

               

                if(tal1 < tal2)
                {
                    sum += tal2;
                    störreTal++;
                    
                }

                else
                {
                    sum1 += tal2;
                    mindreTal++;
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("_________________________________________________");
            Console.WriteLine($"{störreTal} numbers was larger then {tal1} ");
            Console.WriteLine($"{mindreTal} numbers was smaller then {tal1}");
            Console.WriteLine("_________________________________________________");
            Console.WriteLine($"sum of numbers larger then {tal1} = {sum}");
            Console.WriteLine($"sum of numbers smaller then {tal1} = {sum1} ");
            Console.WriteLine("_________________________________________________");

            Console.ReadLine();
        }
    }
}

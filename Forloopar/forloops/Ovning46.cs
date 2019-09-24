using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning46
    {
        public void Print()
        {
            double salary = 0.01;
            int omgång = 0;
            double gathered = 0;
            while(salary != 1000000)
            {
                omgång++;
                gathered += salary;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"You earned {salary} day {omgång}");
                Console.WriteLine($"you gathered {gathered}.");

                Console.WriteLine();
                Console.WriteLine();
                salary = salary * 2;

                if (salary >= 1000000)
                {
                    omgång++;
                    Console.WriteLine($"Lön: {salary}.  You earned a million and it took {omgång} days.");
                    Console.ReadLine();
                }
            }

            Console.ReadLine();
        }
    }
}

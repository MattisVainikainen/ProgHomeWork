using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning41
    {
        public void Print()
        {
            int sum = 0;
            for (int i = 1; i <= 50; i++)
            {
                
                sum = sum + i;
                

                Console.WriteLine($"{i} omgången. {sum}");
            }
            Console.ReadLine();
        }
    }
}

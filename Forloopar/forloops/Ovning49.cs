using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning49
    {
        public void Print()
        {
            Console.Write("Ange Värdet X: ");
            double x = int.Parse(Console.ReadLine());
            Console.Write("Ange Värdet n: ");
            double n = int.Parse(Console.ReadLine());
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                sum  = sum * x;
               
            }
            Console.WriteLine($"Produkten av {x} ^ {n} = {sum}");
            //   Console.WriteLine(Math.Pow(x,n));

            Console.ReadLine();
            

        }
        
    }
}

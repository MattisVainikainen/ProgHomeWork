using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning40
    {
        
        public void Print()
        {
            Console.Write("Ange X värdet: ");
            int x = int.Parse(Console.ReadLine());


            x = (3 * (x * x * x)) - (5*( x * x) + (x * x)) - 20;
            Console.WriteLine($"Svaret på f(x) är: {x}");
            Console.ReadLine();
        }

        
    }
}

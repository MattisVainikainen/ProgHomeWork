using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning2
    {
     
        public void IsVa1Double(double t1, double t2)
        {
            if(t1*2 > t2)
            {
                Console.WriteLine("Tal 1 är dubbelt så stort som Tal 2");
            }
            Console.ReadLine();
        }

        public void PrintDouble()
        {
            Console.Write("Skriv in tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());


            IsVa1Double(tal1, tal2);

        }
    }
}

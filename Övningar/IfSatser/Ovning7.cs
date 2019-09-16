using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning7
    {
        public double IfTal2Is0(double t1, double t2)
        {
            if(t2 == 0)
            {
                Console.WriteLine("Error! kan inte dela första talet med 0");
                Console.ReadLine();
            }

            return t1 / t2;
        }
        public void PrintKvot()
        {
            Console.Write("Ante tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ante tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ditt tal blir : {0}", IfTal2Is0(tal1, tal2));
            Console.ReadLine();
        }
    }

        
}

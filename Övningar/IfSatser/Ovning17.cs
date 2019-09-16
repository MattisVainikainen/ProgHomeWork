using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning17
    {
        public void SkrivUtMinstaTalet(int t1, int t2, int t3)
        {
            if(t1 < t2 && t1 < t3)
            {
                Console.WriteLine(t1 + " är minsta talet.");
            }

            else if (t2 < t1 && t2 < t3)
            {
                Console.WriteLine(t2 + " är minsta talet. ");
            }

            else
            {
                Console.WriteLine(t3 + " är minsta talet. ");
            }
        }
        public void Print()
        {
            Console.WriteLine("Ange tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange tal 3: ");
            int tal3 = Convert.ToInt32(Console.ReadLine());

            SkrivUtMinstaTalet(tal1, tal2, tal3);
            Console.ReadLine();
        }
    }
}

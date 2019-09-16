using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning16
    {
        public void StorstaTalet(int t1, int t2)
        {
            if(t1 > t2)
            {
                Console.WriteLine(t1 + " är störst. ");
            }

            else if (t1 < t2)
            {
                Console.WriteLine(t2 + " är störst. ");
            }

            else
            {
                Console.WriteLine(t1 + " och " + t2 + " är lika stora. ");
            }
        }
        public void Print()
        {
            Console.WriteLine("Ange tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            StorstaTalet(tal1, tal2);
            Console.ReadLine();
        }
    }
}

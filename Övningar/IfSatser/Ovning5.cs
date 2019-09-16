using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning5
    {
        public void JamntDelatMedTal2(int t1,int t2)
        {
            if(t1 % 2 == 0)
            {
                Console.WriteLine("Jämnt tal");
            }
            Console.ReadLine();
        }
        
        public void PrintJamntDelatMedtal2()
        {
            Console.Write("Skriv in tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Skriv in tal 2: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());


            JamntDelatMedTal2(tal1, tal2);

        }
    }
}

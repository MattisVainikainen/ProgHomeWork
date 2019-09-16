using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning3
    {
        public void EvenNumber(int t)
        {
            if(t % 2 == 0)
            {
                Console.WriteLine("Talet är jämnt delbart");
            }
            Console.ReadLine();
        }

        public void PrintEvenNumber()
        {
            Console.Write("Skriv in tal 1: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            EvenNumber(tal1);
                        
        }
    }
}

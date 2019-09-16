using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning4
    {
        public void EvenOrOddNumber(int t)
        {

            if (t % 2 == 0)
            {
                Console.WriteLine("Du valde ett jämnt tal. ");
            }

            else 
            {
                Console.WriteLine("Du valde ett ojämnt tal. ");
            }

            Console.ReadLine();

        }

        public void PrintEvenOrOddNumber()
        {
                Console.Write("Skriv in valfritt nummer: ");
                int tal1 = Convert.ToInt32(Console.ReadLine());
            
                EvenOrOddNumber(tal1);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning13
    {
        decimal kvot;
        public int DelaTaletMed3(int number)
        {

            if (number %3 == 0 && number %30 != 0)
            {
                kvot = number / 3;
            }
            return (int)kvot;
        }
        public void Print()
        {
            Console.WriteLine("Ange ett tal: ");
            int tal = int.Parse(Console.ReadLine());

            Console.WriteLine($"Kvoten är: {DelaTaletMed3(tal)}");
            Console.ReadLine();
        }
    }
}

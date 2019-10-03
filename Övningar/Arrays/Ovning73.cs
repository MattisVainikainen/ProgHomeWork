using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning73
    {
        public void Print()
        {
            double[] tal = { 3, 5, 2.35, 6, 8 };
            double sum = 0;
            double avg = sum / tal.Length;
            foreach (var number in tal)
            {
                sum += number;
            }

            Console.WriteLine($"Totalt blir summan utav dessa tal: {sum.ToString("0.00")}");
            Console.WriteLine($"Medelvärdet utav dessa blir: {avg.ToString("0.00")}");
            Console.ReadLine();
        }

        public static void RunOvning73()
        {
            Ovning73 Ovn73 = new Ovning73();
            Ovn73.Print();
        }
    }
}

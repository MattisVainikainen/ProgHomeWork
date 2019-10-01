using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning72
    {
        public void Print()
        {
            int[] tal = { 5, -4, -3, 7, -8 };
            int negativeNumber = 0;
            int i = 0;
            int currentI = 0;
            foreach (var number in tal)
            {
                
                if(number < 0)
                {                
                    negativeNumber = number;
                    currentI = i;
                }
                i++;
            }
            Console.WriteLine($"Sista negativa numret är: {negativeNumber} på index nr: {currentI} ");
            Console.ReadLine();
        }

        public static void RunOvning72()
        {
            Ovning72 Ovn72 = new Ovning72();
            Ovn72.Print();
        }
    }
}

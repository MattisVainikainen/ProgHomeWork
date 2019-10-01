using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning66
    {
        public void Print()
        {

            Console.Write("Ange persNumret (YYMMDD-NNNN): ");
            string[] persNummer = new string[11];
            foreach (var item in persNummer)
            {
                if(persNummer[7].Contains("-"))
                {
                    Console.WriteLine("Right format");
                }
                else
                {
                    Console.WriteLine("Wrong format");
                }
            }

            
    

            Console.ReadLine();
        }

        public static void RunOvning66()
        {
            Ovning66 Ovn66 = new Ovning66();
            Ovn66.Print();
        }
    }
}

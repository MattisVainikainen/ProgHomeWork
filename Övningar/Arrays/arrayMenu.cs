using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class arrayMenu
    {

        public static void Print()
        {
            Console.WriteLine("Olika Array Övningar.");
            Console.WriteLine();
            Console.WriteLine("1: Övning 1");
            Console.WriteLine("2: Övning 2");
            Console.WriteLine("3: Övning 66");
            Console.WriteLine();
            Console.Write("Ange val: ");
            int menu = int.Parse(Console.ReadLine());

            switch(menu)
            {
                case 1:
                    Arrayovning.RunArrayOvning();
                    break;

                case 2:
                    Arrays1.RunArray1();
                    break;

                case 3:
                    Ovning66.RunOvning66();
                    break;
            }

        }
    }
}

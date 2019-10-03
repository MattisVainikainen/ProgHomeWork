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
            Console.WriteLine("4: Övning 67");
            Console.WriteLine("5: Övning 68");
            Console.WriteLine("6: Övning 69");
            Console.WriteLine("7: Övning 70");
            Console.WriteLine("8: Övning 72");
            Console.WriteLine("9: Övning 73");
            Console.WriteLine("10: Övning 74");
            Console.WriteLine("11: Övning 75");
            Console.WriteLine("12: Övning Copy Array");
            Console.WriteLine("13: Övning 76");
            Console.WriteLine("14: Övning 77");
            Console.WriteLine("15: Övning 78");
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

                case 4:
                    Ovning67.RunOvning67();
                    break;

                case 5:
                    Ovning68.RunOvning68();
                    break;

                case 6:
                    Ovning69.RunOvning69();
                    break;

                case 7:
                    Ovning70.RunOvning70();
                    break;

                case 8:
                    Ovning72.RunOvning72();
                    break;

                case 9:
                    Ovning73.RunOvning73();
                    break;

                case 10:
                    Ovning74.RunOvning74();
                    break;

                case 11:
                    Ovning75.RunOvning75();
                    break;

                case 12:
                    CopyArray.RunCopyArray();
                    break;

                case 13:
                    Ovning76.RunOvning76();
                    break;

                case 14:
                    Ovning77.RunOvning77();
                    break;

                case 15:
                    Ovning78.RunOvning78();
                    break;
            }

        }
    }
}

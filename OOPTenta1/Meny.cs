using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    static class Meny
    {
        public static void Ovningar()
        {
            Console.WriteLine("Tenta Övningar 1-9");
            Console.WriteLine();
            Console.WriteLine("Övning 1: ");
            Console.WriteLine("Övning 2: ");
            Console.WriteLine("Övning 3: ");
            Console.WriteLine("Övning 4: ");
            Console.WriteLine("Övning 5: ");
            Console.WriteLine("Övning 6: ");
            Console.WriteLine("Övning 7: ");
            Console.WriteLine("Övning 8: ");
            Console.WriteLine("Övning 9: ");
            Console.WriteLine();

            Console.Write("Välj Övning: ");
            int MenyList = int.Parse(Console.ReadLine());
            switch(MenyList)
            {
                case 1:
                    Ovning1.PrintOvning1();
                    break;

                case 2:
                    Ovning2.PrintOvning2();
                    break;

                case 3:
                    Ovning3.PrintOvning3();
                    break;

                case 4:
                    Ovning4.PrintOvning4();
                    break;

                case 5:
                    Ovning5.PrintOvning5();
                    break;

                case 6:
                    Ovning6.PrintOvning6();
                    break;

                case 7:
                    Ovning7.PrintOvning7();
                    break;

                case 8:
                    Ovning8.PrintOvning8();
                    break;

                case 9:
                    Ovning9.PrintOvning9();
                    break;

                default:
                    Console.WriteLine("Välj alternativ som finns.");
                    break;

            }
        }
    }
}

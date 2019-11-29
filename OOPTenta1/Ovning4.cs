using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning4
    {
        int x, y, z;
        public void Ovn4()
        {
            TestNumbers(x, y, z); //Anropar metoden med x, y och z som indata. dessa är av typen int.
        }

        //Användare skriver in talen x, y och z.
        public void TestNumbers(int x, int y, int z)
        {
            Console.Write("Tal x: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Tal y: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Tal z: ");
            z = int.Parse(Console.ReadLine());

            //Om y är större än x så skriver vi ut att detta är True, annars False;
            if (y> x)
            {
                Console.WriteLine($"True, Y är större än X");
            }
            else
            {
                Console.WriteLine("False, Y är inte större än X");
            }

            //Om z är större än y så skriver vi ut att detta är True, annars False;
            if (z > y)
            {
                Console.WriteLine($"True, Z är större än Y");
            }
            else
            {
                Console.WriteLine($"False, Z är inte större än Y");
            }

            Console.ReadLine();
        }

        public static void PrintOvning4()
        {
            Ovning4 Ovn4 = new Ovning4();
            Ovn4.Ovn4();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning39
    {

        public void Print()
        {
            while(true)
            {
                Console.Write("Ange produkt pris: ");
                int pris = int.Parse(Console.ReadLine());

                double prismedmoms = pris * 1.25;
                if(pris == 0)
                {
                    Console.WriteLine("Du valde att avsluta programmet.");
                    break;
                }
                Console.WriteLine($"Ditt pris blir: {prismedmoms}");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning9
    {
        //Skapar 2 olika arrays med olika indata. Negativa som positiva heltal.
        //Anger även 2 olika totalsummor.
        int[] a = new int[5] { 1, 2, 30, 4, -5 };
        int[] b = new int[5] { -4, 3, 14, -13, 9 };
        int sumA;
        int sumB;

        public void Ovn9()
        {
            //För varje tal i array a så adderar vi dom.
            foreach (var number in a)
            {
                sumA += number;
                Console.WriteLine(number);
            }
            Console.WriteLine($"TotalSumman av Array a = {sumA}");
            Console.WriteLine("--------------------------------");
            //För varje tal i array b så adderar vi dom.
            foreach (var number in b)
            {
                sumB += number;
                Console.WriteLine($"{number}");
            }
            Console.WriteLine($"TotalSumman av Array a = {sumB}");
            Console.WriteLine("--------------------------------");

            //Om summan av Array a är större än Array b så skriver vi ut att Array A är störst.
            //Annars skriver vi ut att Array b är störst.
            if (sumA > sumB)
            {
                Console.WriteLine($"Summan av Array A är större än Array B.");
            }
            else if (sumB > sumA)
            {
                Console.WriteLine($"Summan av Array B är större än Array A.");
            }

            Console.ReadLine();

        }


        public static void PrintOvning9()
        {
            Ovning9 Ovn9 = new Ovning9();
            Ovn9.Ovn9();
        }
    }
}

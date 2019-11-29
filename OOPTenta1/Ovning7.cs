using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning7
    {
        public void Ovn7()
        {
            //Skapar 2 olika arrays där indata endast anges på array elements.
            int[] elements = new int[4] { 1, 3, 2, 4 };
            int[] elements1 = new int[4];

            //Normal List. Här skriver vi ut all indata precis i den ordning som vi skapade den.
            Console.WriteLine("Normal List");
            foreach (var number in elements)
            {
                Console.WriteLine(number);
            }

            //Vi kopierar all data från elements till elements1 där vi anger startindex på elements1.
            //Vi anväder metoden Array.Reverse för att skriva ut indatan baklänges.
            elements.CopyTo(elements1, 0);
            Array.Reverse(elements1);

            //Reversed List. Här skrivs indatan ut baklänges.
            //Bara att göra en likadan med Array.Sort(elements1) om man vill sortera listan.
            Console.WriteLine("Reversed List");
            foreach (var number in elements1)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();


        }


        public static void PrintOvning7()
        {
            Ovning7 Ovn7 = new Ovning7();
            Ovn7.Ovn7();
        }
    }
}

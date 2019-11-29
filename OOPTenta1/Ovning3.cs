using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning3
    {
        public void Ovn3()
        {
            TrueOrFalse(25, 40, 13); //Ropar på metoden med indata (siffror)
            Console.ReadLine();

        }

        //En metod med 3 argument.
        public void TrueOrFalse(int a, int b, int c)
        {
            Console.WriteLine($"Om talet är mellan 20-50 så är det True, annars False.");
            
            //Om talet a är mellan 20-50 så skrivs True ut annars false
            if(a > 20 && a < 50)
            {
                Console.WriteLine($"Tal: {a}, True");
            }
            else
            {
                Console.WriteLine($"Tal: {a}, False");
            }

            //Om talet b är mellan 20-50 så skrivs True ut annars false
            if (b > 20 && b < 50)
            {
                Console.WriteLine($"Tal: {b}, True");
            }
            else
            {
                Console.WriteLine($"Tal: {b}, False");
            }

            //Om talet c är mellan 20-50 så skrivs True ut annars false
            if (c > 20 && c < 50)
            {
                Console.WriteLine($"Tal: {c}, True");
            }
            else
            {
                Console.WriteLine($"Tal: {c}, False");
            }

        }
        public static void PrintOvning3()
        {
            Ovning3 Ovn3 = new Ovning3();
            Ovn3.Ovn3();
        }
    }
}

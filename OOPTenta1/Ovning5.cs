using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning5
    {
        public void Ovn5()
        {

            int tal1, tal2;
            int sum;

            //Användare anger tal 1 och 2.
            Console.Write("Ange Tal 1: ");
            tal1 = int.Parse(Console.ReadLine());
            Console.Write("Ange Tal 2: ");
            tal2 = int.Parse(Console.ReadLine());

            //Om tal 1 är större än tal2 skriv ut tal1 annars skriv ut tal2
            if(tal1 > tal2)
            {
                Console.WriteLine(tal1);
            }

            else if (tal2 > tal1)
            {
                Console.WriteLine(tal2);
            }

            //Om tal1 och tal2 är likadana så sätter vi värdet 0 på båda.
            if(tal1 == tal2)
            {
                tal1 = 0;
                tal2 = 0;

                Console.WriteLine("Båda talen är likadana. Vi returnerar talet 0");
            }

            //Förstod inte av uppgiften hur man skulle kunna visa delat med 7 här. I uppgiften står det visa det största av 2 tal.
            //Men något sådant här gissar jag på att man kan göra isåfall.
            if(tal1%7 == 0 && tal2%7 == 0 && tal1 > tal2 || tal1 % 7 == 1 && tal2 % 7 == 1 && tal1 > tal2)
            {
                Console.WriteLine(tal1);
            }
            else if(tal2%7 == 0 && tal1%7 == 0 && tal2 > tal1 || tal2 % 7 == 1 && tal1 % 7 == 1 && tal2 > tal1)
            {
                Console.WriteLine(tal2);
            }
            Console.ReadLine();

        }


        public static void PrintOvning5()
        {
            Ovning5 Ovn5 = new Ovning5();
            Ovn5.Ovn5();
        }
    }
}

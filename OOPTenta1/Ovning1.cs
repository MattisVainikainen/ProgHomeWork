using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning1
    {
        int newNumber;
        int newNumber2;
        int[] elements = new int[2];
        public void Ovn1()
        {
            

            Console.WriteLine("Number 1: ");
            elements[0] = int.Parse(Console.ReadLine()); // Här får indexplats Nr 0 sitt värde som användaren skriver in.
            Console.WriteLine("Number 2: ");
            elements[1] = int.Parse(Console.ReadLine()); // Här får indexplats 1 sitt värde som användaren skriver in.

            //Om indexplats 0 är mindre än 0 så gångrar vi talet med -1 för att göra talet till positivt.
            //Om indexplats 1 är större så gångrar vi bara med 1.
            //Vi sätter värdet i en ny variabel med nya numret.
            if (elements[0] < 0)
            {
                newNumber = elements[0] * -1;
            }
            else if(elements[0] > 0)
            {
                newNumber = elements[0] * 1;
            }

            //Om indexplats 1 är mindre än 0 så gångrar vi talet med -1 för att göra talet till positivt.
            //Om indexplats 1 är större så gångrar vi bara med 1.
            //Vi sätter värdet i en ny variabel med nya numret.
            if (elements[1] < 0)
            {
                newNumber2 = elements[1] * -1;
            }
            else if (elements[1] > 0)
            {
                newNumber2 = elements[1] * 1;
            }

            //Skriver ut vilka som är dina nummer och resultatet.
            Console.WriteLine($"Your numbers are {newNumber} and {newNumber2} ");
            Console.WriteLine($"The result = {newNumber / newNumber2}");
            Console.ReadLine();







        }













        public static void PrintOvning1()
        {
            Ovning1 Ovn1 = new Ovning1();
            Ovn1.Ovn1();
        }
    }
}

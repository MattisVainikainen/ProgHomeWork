using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning66
    {
        public void Print()
        {

            Console.Write("Ange persNumret (YYMMDD-NNNN): ");
            // string personNummer = "780126-4990";
            string userInput = Console.ReadLine(); 
            char[] persNummer = userInput.ToCharArray();
            string check = persNummer[6].ToString();
         
                if(check != "-")
                {
                    Console.WriteLine("Error. Du måste ange rätt format. YYMMDD-NNNN");
                }
                
                if(check == "-")
                {
                    Console.WriteLine("Rätt format.. Tack!");
                }

            Console.ReadLine();
        }

        public static void RunOvning66()
        {
            Ovning66 Ovn66 = new Ovning66();
            Ovn66.Print();
        }
    }
}

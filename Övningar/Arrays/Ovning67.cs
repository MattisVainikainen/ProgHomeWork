using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning67
    {
        public void Print()
        {
            Console.Write("Ange persNumret (YYMMDD-NNNN): ");
            // string personNummer = "780126-4990";
            string userInput = Console.ReadLine();
            char[] persNummer = userInput.ToCharArray();
            string check = persNummer[6].ToString();
            int check1 = persNummer[9];


            if(check1 %2 == 1 && check == "-")
            {
                Console.WriteLine("Rätt format och du är en Man!");
            }

            if(check1 % 2 == 0 && check == "-")
            {
                Console.WriteLine("Rätt format och du är en Kvinna!");
            }

            if (check != "-")
            {
                Console.WriteLine("Error. Du måste ange rätt format. YYMMDD-NNNN");
            }

            Console.ReadLine();
        }
        
        

        public static void RunOvning67()
        {
            Ovning67 Ovn67 = new Ovning67();
            Ovn67.Print();
        }
    }
}

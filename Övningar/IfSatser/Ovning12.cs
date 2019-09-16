using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning12
    {

        public void NollTillNioMenInteFem(int number)
        {
            if(number >= 0 && number <= 4 || number >= 6 && number <= 9)
            {
                Console.WriteLine("Du valde inte numret 5");
            }
            else
            {
                Console.WriteLine("Du valde nummer 5! ");
            }

        }
        public void Print()
        {
            Console.WriteLine("Välj ett nummer mellan 0-9");
            int UserInput = Convert.ToInt32(Console.ReadLine());

            NollTillNioMenInteFem(UserInput);
            Console.ReadLine();
        }
    }
}

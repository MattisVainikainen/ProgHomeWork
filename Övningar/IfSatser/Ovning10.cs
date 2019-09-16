using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning10
    {
        public void CheckNumber(int number)
        {
            if(number >= 0 && number <= 9)
            {
                Console.WriteLine("Du valde ett nummer mellan 0-9!");
            }

            else
            {
                Console.WriteLine("Error! Du angav annat nummer än 0-9");
            }

        }
        public void Print()
        {
            Console.Write("Välj ett nummer mellan 0-9 : ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            CheckNumber(userInput);
            Console.ReadLine();
        }
    }
}

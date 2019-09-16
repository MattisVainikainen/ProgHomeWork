using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning11
    {
        public void CheckNumber(int number)
        {
            if (number < -9 || number > 9)
            {
                Console.WriteLine("Du angav ett 2 siffrigt tal!");
            }

            else
            {
                Console.WriteLine("Du angav ett ensiffrigt tal!");
            }
           
        }
        public void Print()
        {
            Console.Write("Välj ett nummer: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            CheckNumber(userInput);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning18
    {
        public void Temperaturer(int temp)
        {
            if(temp >= 18 && temp <= 25)
            {
                Console.WriteLine("Lagom temperatur! ");
            }

            else if (temp >= 26)
            {
                Console.WriteLine("För varmt! ");
            }

            else
            {
                Console.WriteLine("För kallt! ");
            }
        }
        public void Print()
        {
            Console.Write("Ange temperatur: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Temperaturer(userInput);
            Console.ReadLine();
        }
    }
}

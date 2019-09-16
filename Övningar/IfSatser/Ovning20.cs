using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning20
    {
        public void Under100(int tal)
        {
            if(tal < 100)
            {
                Console.WriteLine("Ditt tal är under 100 ");
            }
            else
            {
                Console.WriteLine("Ditt tal är över 100 ");
            }
        }
        public void Print()
        {
            Console.WriteLine("Ange tal: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Under100(userInput);
            Console.ReadLine();
        }
    }
}

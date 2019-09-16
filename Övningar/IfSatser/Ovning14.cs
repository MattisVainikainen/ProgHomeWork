using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning14
    {
        public void Kroppstemperatur(int temp)
        {
            if(temp < 35 || temp > 42)
            {
                Console.WriteLine("WARNING!");
            }

        }
        public void Print()
        {
            Console.WriteLine("Ange din kroppstemperatur: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            Kroppstemperatur(userInput);
            Console.ReadLine();
        }
    }
}

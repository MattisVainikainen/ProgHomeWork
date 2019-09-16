using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning15
    {
        public void PositivtEllerNegativt(int number)
        {
            if(number < 0)
            {
                Console.WriteLine("Ett Negativt tal");
            }
            else
            {
                Console.WriteLine("Ett positivt tal");
            }
        }
        public void Print()
        {
            Console.WriteLine("Ange tal: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            PositivtEllerNegativt(userInput);
            Console.ReadLine();
        }
    }
}

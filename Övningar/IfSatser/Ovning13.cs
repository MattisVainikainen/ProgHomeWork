using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning13
    {
        public void DelaTaletMed3(int number)
        {
            if(number %3 == 0 && number %30 != 0)
            {
                number = number / 3;
                Console.WriteLine("Ditt tal är delbart med 3");
            }
        
            
        }
        public void Print()
        {
            Console.WriteLine("Ange ett tal: ");
            int tal = int.Parse(Console.ReadLine());

            DelaTaletMed3(tal);
            Console.ReadLine();
        }
    }
}

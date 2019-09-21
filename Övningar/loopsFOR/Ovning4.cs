using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.loopsFOR
{
    class Ovning4
    {
        public void Print()
        {
            int Resultat;

            for (int i = 1; i <= 9; i++)
            {
                Resultat = i * i;
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine($"Kvadraten för {i} är: {Resultat}");
            }
            Console.ReadLine();
        }
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning58
    {
        double störstaTal;

        public void Print()
        {
            //Läs in 10 st tal
            Console.WriteLine("Läs in 10 tal.");
            Console.WriteLine("Läs in första talet: ");
            double input = int.Parse(Console.ReadLine());

            //Säger att input på första talet är det största talet
            input = störstaTal;
            //Här kör vi loop 10 gånger
            for (int i = 1; i <= 10; i++)
            { 

                //Skriver ut och läser in värdet som tal
                Console.WriteLine($"Ange tal {i}: ");
                double tal = int.Parse(Console.ReadLine());
                
                //Om värdet är större än störstatal så sätt störstatal som tal
                if(tal > störstaTal)
                {
                    störstaTal = tal;
                }

                               
                Console.WriteLine(störstaTal);
                
                
            }
            Console.WriteLine(störstaTal);
            Console.ReadLine();
        }
    }
}

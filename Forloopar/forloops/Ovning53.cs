using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forloopar.forloops
{
    class Ovning53
    {
        public void Print()
        {
            int korrektaTal = 0;
            int summa = 0;


            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Ange tal {i}:  ");
                int tal = int.Parse(Console.ReadLine());

                if(tal >= 5000 && tal <= 10000)
                {
                    summa += tal;
                    korrektaTal++;
                    
                }
             /*   else
                {
                    i--;
                    Console.WriteLine($"Du angav felaktigt tal. ");
                }*/
                
            }

            Console.WriteLine($"Antal korrekta tal = {korrektaTal} och summan = {summa}");
            Console.WriteLine($"Medelvärdet av dessa korrekta tal blir = {summa / korrektaTal} ");
            Console.ReadLine();
        }
    }
}

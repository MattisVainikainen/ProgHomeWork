using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTenta1
{
    class Ovning2
    {
        int[] elements = new int[5];
        List<int> biggerNumbers = new List<int>();
        int index = 1;
        public void Ovn2()
        {
            Console.WriteLine("Ange 5 st tal: ");
            Console.WriteLine();

            //Användaren anger första talet.
            Console.Write("Ange Tal 1: ");
            elements[0] = int.Parse(Console.ReadLine());

            //Här loopar vi övriga talen som användaren får skriva in.
            //Vi ökar index med 1 varje varv för att få Tal2, Tal3 osv.
            //Om elements[i] är större än första talet (elements[0]) så lägger vi till talet i en ny Lista.
            for (int i = 1; i < elements.Length; i++)
            {
                index++;               
                Console.Write($"Ang Tal {index}: ");
                elements[i] = int.Parse(Console.ReadLine());   
                if(elements[i] > elements[0])
                {
                    biggerNumbers.Add(elements[i]);
                }
            }

            //Skriver ut alla talen som är större än första talet (elements[0].
            foreach (var number in biggerNumbers)
            {
                Console.WriteLine($"Dessa tal är större än första inlästa talet {number}");
            }
            
            Console.ReadLine();











        }


        public static void PrintOvning2()
        {
            Ovning2 Ovn2 = new Ovning2();
            Ovn2.Ovn2();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    public class Ovning1
    {
      
        void IsValBigger(double t1, double t2)
        {
            
            if(t1 > t2)
            {
                Console.WriteLine("Största talet är " + t1);
            }

            else if (t2 > t1)
            {
                Console.WriteLine("Största talet är " + t2);
            }

            else
            {
                Console.WriteLine("Talen du skrev är lika stora ");
            }
            Console.WriteLine("Klicka på enter för att komma tillbaks till meny");
           
        }

        public void Print()
        {
            Console.Write("Skriv in tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Skriv in tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());
               
            IsValBigger(tal1, tal2);
            
        }

        public static void RunOvning1()
        {
            Ovning1 Ovning1 = new Ovning1();
            Ovning1.Print();

        }
        
    }
}

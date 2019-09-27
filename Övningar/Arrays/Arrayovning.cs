using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Arrayovning
    {
        public void ArrayOvning()
        {
            Console.WriteLine("_________________________________________");

            double[] Laps = new double[3];
            Laps[0] = 3.25;
            Laps[1] = 3.76;
            Laps[2] = 4.56;

            double[] machSpeed = { 5.1, 1.0, 4.3 };

            Array.Sort(machSpeed);
            foreach (var m in machSpeed)
            {               
                Console.WriteLine($"Machspeed is: {m}");             
            }

            Console.WriteLine("_________________________________________");
            Console.WriteLine();

            Array.Reverse(machSpeed);
            foreach (var m in machSpeed)
            {              
                Console.WriteLine($"Machspeed is: {m}");
            }

            Console.WriteLine("________________________________________");
            Console.WriteLine();

            for (int i = 0; i < Laps.Length; i++)
            {
                Console.WriteLine($"LapTime är: {Laps[i]}");
            }

            Console.ReadLine();
           
        }
        public static void RunArrayOvning()
        {
            Arrayovning array = new Arrayovning();
            array.ArrayOvning();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Ovning78
    {
        public void Print()
        {
            double[] Olikatal = new double[2];

            for (int i = 0; i < Olikatal.Length; i++)
            {
                Console.Write($"Ange tal {1}: ");
                Olikatal[i] = double.Parse(Console.ReadLine());
            }

            if(Olikatal[1] == 0)
            {
                Console.WriteLine("Error. Nämnaren kan inte vara en 0a.");
            }

            Console.ReadLine();
        }

        public static void RunOvning78()
        {
            Ovning78 Ovn78 = new Ovning78();
            Ovn78.Print();
        }
    }
}

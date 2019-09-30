using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.Arrays
{
    class Arrays1
    {
        public void Print()
        {
            string[] namn = { "Mattis", "Jennica", "Alice", "Kian" };

            foreach (var name in namn)
            {
                Console.WriteLine(name);
            }
        }
        
        public static void RunArray1()
        {
            Arrays1 array1 = new Arrays1();
            array1.Print();
        }
    }
}

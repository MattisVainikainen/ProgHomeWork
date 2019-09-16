using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning8
    {
        public int XOchY(int x,int y)
        {
            int A;
            if(x > 5 + y)
            {
                A = 2;
            }

            else
            {
                A = 5;
            }

            return A;
        }


        public void PrintXOchY()
        {
            Console.WriteLine("Ange x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A = {0} ", XOchY(x, y));
            Console.ReadLine();
        }
    }
}

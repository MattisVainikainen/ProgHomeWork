using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.RandomOvningar
{
    class Klubben
    {
        
        public void Print()
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
            Console.ForegroundColor = ConsoleColor.Green;
            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                PARTY PARTY PARTY                  |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("|                                                   |");
                Console.WriteLine("_____________________________________________________");
                Console.Clear();
            } while (true);
            
        }
    }
}

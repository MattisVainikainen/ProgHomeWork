using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetOvning
{
    class Program
    {
        static void Main(string[] args)
        {

            User charles = new User(100, "Charles");
            Console.WriteLine($"User: {charles.Name} with HealtPoints: {charles.Health}");
            


            Console.ReadLine();
        }
    }
}

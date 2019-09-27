using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchOvning
{
    public class Menu
    {
        public void PrintMenu()
        {
            
                string control;
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("Wr1: If satser");
                Console.WriteLine("Wr1: for loop");
                Console.WriteLine("Wr1: while loopar");
                Console.WriteLine();
                control = Console.ReadLine();
            do
            {
                Console.Write("Välj ett val: ");

                switch (control)
                {
                    case "1":

                        break;

                    case "2":

                        break;

                    case "3":

                        break;

                    default:

                        break;
                }
            } while (true);
            
        }
    }
}

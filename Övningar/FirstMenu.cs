using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar
{
    class FirstMenu
    {
        public void MainMenu()
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                            MENY                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1) If satser ");
            Console.WriteLine("2) ForLoops ");
            Console.Write("Choose Menu: ");
            int menuChoice = int.Parse(Console.ReadLine());

            switch(menuChoice)
            {

                case 1:
                    Övningar.IfSatser.IfSatsMenu ifsats = new Övningar.IfSatser.IfSatsMenu();
                    Console.Clear();
                    ifsats.IfSats();
                    
                    break;

                case 2:
                    Övningar.IfSatser.Ovning2 Ovning2 = new Övningar.IfSatser.Ovning2();
                    Ovning2.PrintDouble();
                    break;

                

                default:
                    Console.WriteLine("Välj bland meny: ");
                    break;
            }
        }
    }
}

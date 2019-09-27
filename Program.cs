using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowMenu();
        }


        private static void ShowMenu()
        {
            Console.Clear();
            string control;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("1: If satser");
                Console.WriteLine("2: for loop");
                Console.WriteLine("3: while loopar");
                Console.WriteLine("4: Avsluta");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.Write("Välj ett val: ");
                control = Console.ReadLine();
             

                switch (control)
                {
                    case "1":
                        ShowIfSatsMenu();
                        
                        break;

                    case "2":
                        Console.WriteLine("Du valde for loopar");
                        
                        break;

                    case "3":
                        Console.WriteLine("Du valde for while loopar");
                        
                        break;

                    default:
                        Console.WriteLine("Du måste välja ett val bland menyn");
                        
                        break;
                }
               
                Console.ReadKey();
                Console.Clear();


            } while (control != "4");
        }


        public static void ShowIfSatsMenu()
        {
            Console.Clear();
            string controlIfSats;
            do
            {
            Console.WriteLine("Menu");
            Console.WriteLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("1: Övning 1");
            Console.WriteLine("2: Övning 2");
            Console.WriteLine("3: Övning 3");
            Console.WriteLine("4: Gå tillbaks till Main Menu");
            Console.WriteLine("5: Avsluta programmet");
            Console.WriteLine("--------------------");
            Console.WriteLine();
            Console.Write("Välj ett val: ");
            controlIfSats = Console.ReadLine();

            switch(controlIfSats)
            {
                case "1":
                        Övningar.IfSatser.Ovning1.RunOvning1();
                        
                    break;

                case "2":
                        Console.WriteLine("Du valde Övning 2");
                        
                    break;

                case "3":
                        Console.WriteLine("Du valde Övning 3");
                        
                        break;

                case "4":
                        ShowMenu();
                        break;

                default:
                        Console.WriteLine("Du måste välja ett val som finns i menyn.");
                    break;
            }
            Console.ReadKey();
            } while (controlIfSats != "5");
        } 
        
    }
}

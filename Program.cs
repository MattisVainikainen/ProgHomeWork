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
            string control;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("1: If satser");
                Console.WriteLine("2: for loop");
                Console.WriteLine("3: while loopar");
                Console.WriteLine("4: Random Övningar");
                Console.WriteLine("5: Arrays");
                Console.WriteLine("6: Avsluta");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.Write("Välj ett val: ");
                control = Console.ReadLine();


                switch (control)
                {
                    case "1":
                        Console.Clear();
                        ShowIfSatsMenu();

                        break;

                    case "2":
                        Console.WriteLine("Du valde for loopar");

                        break;

                    case "3":
                        Console.WriteLine("Du valde for while loopar");
                        break;

                    case "4":
                        Console.WriteLine("Du valde Random Övningar");
                        break;

                    case "5":
                        Övningar.Arrays.Arrayovning.RunArrayOvning();
                        break;

                    case "6":
                        Console.WriteLine("Du valde att avsluta programmet. klicka vidare...");
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

                switch (controlIfSats)
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
                        Console.Clear();
                        ShowMenu();

                        break;

                    default:
                        Console.WriteLine("Du måste välja ett val som finns i menyn.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (controlIfSats != "5");
        }

        public static void ShowRandomOvningMenu()
        {
            string controlRandomOvningar;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine();
                Console.WriteLine("--------------------");
                Console.WriteLine("1: Övning Åldersgräns");
                Console.WriteLine("2: Övning Klubben");
                Console.WriteLine("3: Övning Login");
                Console.WriteLine("4: Övning Mobile");
                Console.WriteLine("5: Övning Random namn");
                Console.WriteLine("6: Gå tillbaks till Main Menu");
                Console.WriteLine("7: Avsluta programmet");
                Console.WriteLine("--------------------");
                Console.WriteLine();
                Console.Write("Välj ett val: ");
                controlRandomOvningar = Console.ReadLine();

                switch (controlRandomOvningar)
                {
                    case "1":
                        Övningar.RandomOvningar.Aldersgrans.RunAldersGrans();
                        break;

                    case "2":
                        Console.WriteLine("Du valde Övning 2");

                        break;

                    case "3":
                        Console.WriteLine("Du valde Övning 3");

                        break;

                    case "4":
                        Console.Clear();
                        ShowMenu();

                        break;

                    default:
                        Console.WriteLine("Du måste välja ett val som finns i menyn.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (controlRandomOvningar != "7");

        }
    }
}

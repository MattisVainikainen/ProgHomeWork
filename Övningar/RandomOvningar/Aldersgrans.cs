using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.RandomOvningar
{
    class Aldersgrans
    {

        public void HarDuAldernInne(int alder, string ID)
        {
            if(alder != 16 || ID == "VIP" || ID == "Mattis")
            {
                
                Console.WriteLine("Du har ålder inne och är VIP");
                Console.WriteLine("1) Grön");
                Console.WriteLine("2) Röd" );
                Console.Write("Ange Färg: ");
                
                int color = int.Parse(Console.ReadLine());

                switch(color)
                {
                    case 1:
                        Console.WriteLine("Du valde Grön");
                        Console.WriteLine("Klicka på enter för att gå till Klubben");
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Övningar.RandomOvningar.Klubben club = new Övningar.RandomOvningar.Klubben();
                        club.Print();
                        break;

                    case 2:
                        Console.WriteLine("Du valde Röd");
                        break;
                }
                
                
            }

            else { Console.WriteLine("error"); }
           
        }
        public void Print()
        {
            Console.WriteLine("Välkommen till CLUB 5");
            Console.WriteLine("Du måste ange Ålder och Namn för att ens få chansen att komma in");
            Console.WriteLine();
            Console.WriteLine("Ange ålder: ");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange ditt ID: ");
            string userName = Console.ReadLine();
            HarDuAldernInne(userAge, userName);
            Console.ReadKey();
        }
    }
}

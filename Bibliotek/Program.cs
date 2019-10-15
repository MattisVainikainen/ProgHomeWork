using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotek
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
          
            Console.WriteLine("_________________________________________");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|      Welcome to Newton Library        |");
            Console.WriteLine("|                                       |");
            Console.WriteLine("|_______________________________________|");

            Console.WriteLine("1) Check books in library");
            Console.WriteLine("2) Loan some books");
            Console.WriteLine("3) Return books");
            int userChoice = int.Parse(Console.ReadLine());

            switch(userChoice)
            {
                case 1:
                    Books.RunCheckBooks();
                        Console.Clear();
                    break;

                case 2:

                    break;

                case 3:

                    break;
            }
            } while (true);

        }
    }
}

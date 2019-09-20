using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.RandomOvningar
{
    class Login
    {
        public void createUser()
        {
            
        }

        public void Print()
        {
            string Mattis = "Mattis";
            int password = 345;

            Console.Write("Username: ");
            string _userName = Console.ReadLine();
            Console.Write("Password: ");
            int _password = int.Parse(Console.ReadLine());

            if(_userName  == Mattis && _password == password)
            {
                Console.WriteLine("Funkade");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Username och password matchade ej");
                Console.WriteLine("Programmet avslutas!");
                Console.ReadKey();
                Environment.Exit(-2);
            }
        }
    }

}

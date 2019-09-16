using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning6
    {
        int totalPrice;
        public int TotalPrice(int prisPerEnhet, int enheter)
        {
            totalPrice = prisPerEnhet * enheter;
            if(totalPrice > 1000)
            {
                totalPrice = (int)(totalPrice * 0.9);
            }

            return totalPrice;
        }

        public void Print()
        {
            Console.WriteLine("Ange Antal: ");
            int antal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ange Pris per Enhet: ");
            int enhetsPris = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Totalpriset med rabatt är : " + TotalPrice(antal, enhetsPris));
            Console.ReadLine();
        }
    }
}

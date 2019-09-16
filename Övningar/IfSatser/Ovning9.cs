using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning9
    {
        double heltid = 40;
        public double RaknaUtLon(double timLon, double antalTimmar)
        {
            double heltidsLön = heltid * timLon;

            if(antalTimmar >40)
            {
                double antalTimmarÖverTid = antalTimmar - heltid;
                double totalÖvertidsLön = (antalTimmarÖverTid * timLon) * 1.5;
                double totalt = heltidsLön + totalÖvertidsLön;
                Console.WriteLine("Lön med övertid: " + totalt);
                Console.ReadLine();
            }

            return heltid * timLon;
            
           
        }
        public void Print()
        {
            Console.Write("Ange din Tim Lön: ");
            double timLon = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ange antal timmar du jobbar: ");
            double antalTimmar = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total lön utan övertid: {0}", RaknaUtLon(timLon, antalTimmar));
            Console.ReadLine();
        }





            /*En anställd som har timlön får, när arbetstiden överstiger 40 timmar per  vecka,
            övertidsbetalning för tiden utöver 40 timmar med en och halv timme  
            Läs in timlön och en veckas arbetstid.
            Den totala veckolönen beräkans och skrivs ut.*/
    }
}

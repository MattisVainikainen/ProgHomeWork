using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgHomeWork.Övningar.IfSatser
{
    class Ovning19
    {
        int arrHour, arrMin;

        public void TrainTime(int depHour, int depMin, int travelHour, int travelMin)
        {
            arrHour = depHour + travelHour;
            arrMin = depMin + travelMin;
            if(arrMin >= 60)
            {
                arrMin = arrMin - 60;
                arrHour = arrHour + 1;
            }

            if(arrHour >= 24)
            {
                arrHour = arrHour - 24;
                Console.WriteLine("Arrival NEXT DAY");
            }
            Console.WriteLine($"Arrival is at: {arrHour}: {arrMin}");
        }

        public void Print()
        {
            Console.Write("Depature time in H: ");
            int dh = int.Parse(Console.ReadLine());

            Console.Write("Depature time in Min: ");
            int dm = int.Parse(Console.ReadLine());

            Console.Write("Travel time in H: ");
            int th = int.Parse(Console.ReadLine());

            Console.Write("Travel time in Min: ");
            int tm = int.Parse(Console.ReadLine());

            TrainTime(dh, dm, th, tm);
            Console.ReadLine();
        }
    }
}

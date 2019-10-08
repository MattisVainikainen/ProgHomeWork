using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetExamples1
{
    class CarsToRent
    {
        public string carName;
        private string carColor;
        private int carPrice;

        public void RentCar()
        {

        }

        public void ReturnCar()
        {

        }

        public void ListOfCars(string _carName, string _carColor, int _carPrice)
        {
            carName = _carName;
            carColor = _carColor;
            carPrice = _carPrice;
        }

        public int CarPrice
        {
            get { return carPrice; }
            set
            {
                carPrice = value;
            }
        }
    }
}

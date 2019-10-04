using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetExamples
{
    class RentMovies
    {
        public string name;
        private string rating;

        

        public RentMovies(string _name, string _rating)
        {
            name = _name;
            Rating = _rating;
           
        }
  
        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR, Please add valid Rating. G, PG, PG-13, R";
                }
            }
        }
    }
    
}

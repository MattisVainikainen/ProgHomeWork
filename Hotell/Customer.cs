using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class Customer
    {
        public string Name;
        public int CustomerId;

        public Customer(string cn, int sid)
        {
            Name = cn;
            CustomerId = sid;
        }

        public Customer()
        {

        }
        public Customer(string name)
        {
            Name = name;
        }
    }
}

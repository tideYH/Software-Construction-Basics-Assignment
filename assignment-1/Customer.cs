using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment6
{
    public class Customer
    {
        public string Name { get; set; }

        public Customer(string name) {
            Name = name;        
        }

        public override string ToString()
        {
            return Name;
        }
    }
}

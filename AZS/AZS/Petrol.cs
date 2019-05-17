using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZS
{
    public class Petrol
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Petrol(){}
        public Petrol (string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}

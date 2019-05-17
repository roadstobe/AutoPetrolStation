using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZS
{
    class MiniCafe
    {
        static int id;
        public int Id { get; }
        public string Name { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double Money { get; set; }
        public MiniCafe() { }
        public MiniCafe(string name, double count, double price, double amount)
        {
            Name = name;
            Count = count;
            Price = price;
            Money = amount;
            Id = id;
            id++;
        }
        public override string ToString()
        {
            return $"{id} Паливо: {Name} Кількість: {Count} \nЦіна: {Price} До оплати: {Money}";
        }
    }
}

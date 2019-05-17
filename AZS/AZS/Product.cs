using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZS
{
    public class Product
    {
        static int id;
        int Id;
        public string Name { get; set; }
        public double Count { get; set; }
        public double Price { get; set; }
        public double Money { get; set; }
        public Product(){ }
        public Product(string name, double count, double price, double amount)
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
            return $"{Id} Продукт: {Name} Кількість: {Count} \nЦіна: {Price} До оплати: {Money}";
        }
    }
}

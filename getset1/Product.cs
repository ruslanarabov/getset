using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace getset1
{
    public class Product
    {
        public int Id;
        public string Name;
        private double _price;
        public int _count;

        public int Count
        {
            get 
            {
                return _count;
            }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    System.Console.WriteLine("Cannot be a negative count!");
                }
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    System.Console.WriteLine("There can be no negative price!");
                }
            }
        }

        public Product(int id, string name, double price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}